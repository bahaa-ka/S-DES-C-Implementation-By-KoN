using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace S_DES_By_KoN
{
    public partial class Form1 : Form
    {
        int[] P10 = { 3, 5, 2, 7, 4, 10, 1, 9, 8, 6 };  // Permutation Table For 10 Bit Key
        int[] P8 = { 6, 3, 7, 4, 8, 5, 10, 9 };         // Permutation Table Reduce Key Size To 8 Bit
        int[] IP = { 2, 6, 3, 1, 4, 8, 5, 7 };          // Initial Permutation Table For Plaintext Block of 8 Bit
        int[] EP = { 4, 1, 2, 3, 2, 3, 4, 1 };          // Expansion Table For Halfs of Block from 4 bit to 8 bit
        string[,] S0 =                                  // S0-Box to reduce the size of right half to 4 bit
        {
                { "01" , "00" , "11" , "10" },
                { "11" , "10" , "01" , "00" },
                { "00" , "10" , "01" , "11" },
                { "11" , "01" , "11" , "10" }
        };
        string[,] S1 =                                  // S1-Box to reduce the size of right half to 4 bit
        {
                { "00" , "01" , "10" , "11" },
                { "10" , "00" , "01" , "11" },
                { "11" , "00" , "01" , "00" },
                { "10" , "01" , "00" , "11" }
        };
        int[] P4 = { 2, 4, 3, 1 };
        int[] IPinvers = { 4, 1, 3, 5, 7, 2, 8, 6 };

        int timer = 0;
        bool converterStatus = false;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            TXT_blockSize.Text = "8 bits";
            TXT_keySize.Text = "10 Bits";
            TXT_type.Text = "Block";
            TXT_numRounds.Text = "2";
        }        

        // Text Conversion And Dividing Methods
        string TextToBinary(Encoding encoding, string text)
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }
        List<string> TextToBlocks(string textInBinary,int sizeOfBlock)
        {
            
            List<string> blocks = (from Match m in Regex.Matches(textInBinary, @"\d{" + sizeOfBlock + "}") select m.Value).ToList();
            return blocks;
        }
        public Byte[] GetBytesFromBinaryString(String binary)
        {
            List<Byte> list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                // Take 8 Bit of The String 
                String t = binary.Substring(i, 8);
                // Add it To List After Convert It To Byte
                list.Add(Convert.ToByte(t, 2));
            }

            return list.ToArray();
        }

        // Other Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult feed =  MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(feed == DialogResult.Yes)
                this.Close();
        }                
        private void TXT_key_TextChanged(object sender, EventArgs e)
        {
            if (TXT_key.Text.Count() == 10)
                LBL_status.Text = "Key Validated Succefully";
            else if (TXT_key.Text.Count() < 10)
                LBL_status.Text = "Key Less Than 10 Bits";
            else
                LBL_status.Text = "Key Bigger Than 10 Bits";

        }
        private void TIM_Operation_Tick(object sender, EventArgs e)
        {
            LBL_elapsedTime.Text = timer++ + " Sec";
        }


        // Encrypt & Decrypt & Convert Buttons Click Events
        private void BTN_decrypt_Click(object sender, EventArgs e)
        {
            TIM_Operation.Enabled = true;
            if (!BGW_Decryption.IsBusy)
                BGW_Decryption.RunWorkerAsync();
            else
                MessageBox.Show("Operation Already Started ..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BTN_encrypt_Click(object sender, EventArgs e)
        {
            TIM_Operation.Enabled = true;
            if (!BGW_Encryption.IsBusy)
                BGW_Encryption.RunWorkerAsync();
            else
                MessageBox.Show("Operation Already Started ..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
       
        private void BTN_plainToText_Click(object sender, EventArgs e)
        {
            if (!converterStatus)
            {
                byte[] textInBinary = GetBytesFromBinaryString(TXT_decryptedText.Text);
                TXT_decryptedText.Text = Encoding.UTF8.GetString(textInBinary);
                converterStatus = true;
            }
            else
            {
                TXT_decryptedText.Text = TextToBinary(Encoding.UTF8, TXT_decryptedText.Text);
                converterStatus = false;
            }
        }


        // Encryption BackGroundWorker Events
        private void BGW_Encryption_DoWork(object sender, DoWorkEventArgs e)
        {
            TXT_cipheredText.Text = null;
            // Converting Text Into Binary And Divide It To Blocks
            string binaryForm = TextToBinary(Encoding.UTF8, TXT_sourceText.Text);
            List<string> blocks = TextToBlocks(binaryForm, 8);

            // Generate The Keys Needed For Encryption
            KeyGenerator generator = new KeyGenerator(TXT_key.Text);
            progressBar1.Maximum = blocks.Count * 10;
            generator.InitialPermutation(P10);
            generator.GenerateKey(1, P8); // Key1
            generator.GenerateKey(3, P8); // Key2

            int progress = 0;
            // Encrypting Each Block
            foreach (string block in blocks)
            {
                Block newBlock = new Block(block);
                newBlock.InitialPermutation(IP);
                LBL_status.Text = "Encrypting this Block : " + block;
                for (int i = 0; i < 2; i++)
                {
                    newBlock.ExpandRight(EP);
                    newBlock.XORWithKey(generator.SubKeys[i]);
                    newBlock.SubstitutionBoxes(S0, S1);
                    newBlock.PermutateS_BoxOutput(P4);
                    newBlock.XORWithLeft();
                    if (i == 1)
                        break;
                    newBlock.Swap();
                }
                newBlock.IrregularSwap();
                newBlock.InversPermutation(IPinvers);
                TXT_cipheredText.Text += newBlock.PlainTextBlock;
                progress += 10;
                BGW_Encryption.ReportProgress(progress);
            }
        }

        private void BGW_Encryption_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_Encryption_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Disable Timer
            TIM_Operation.Enabled = false;
            timer = 0;
            
            LBL_status.Text = "Decryption Completed Successfully";
            MessageBox.Show("Operation Finished With No Error", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            
            // Reset Progress Bar
            progressBar1.Value = 0;

            // Show Cipher Text Info in Information Panel
            TXT_cipherBits.Text = TXT_cipheredText.Text.Count().ToString() + " Bits";
            TXT_cipherBytes.Text = Convert.ToString(TXT_cipheredText.Text.Count() / 8) + " Bytes";
            // Show Source Text Info in Information Panel
            TXT_sourceBits.Text = Convert.ToString(TXT_sourceText.Text.Count() * 8) + " Bits";
            TXT_sourceBytes.Text = Convert.ToString(TXT_sourceText.Text.Count()) + " Bytes";
        }


        // Decryption BackgroundWorker Events
        private void BGW_Decryption_DoWork(object sender, DoWorkEventArgs e)
        {
            TXT_decryptedText.Text = null;
            // Dividing Text To Blocks
            List<string> blocks = TextToBlocks(TXT_sourceText.Text, 8);
            progressBar1.Maximum = blocks.Count * 10;
            // Generating Keys Needed For Decryption (in Revers Order)
            KeyGenerator generator = new KeyGenerator(TXT_key.Text);
            generator.InitialPermutation(P10);
            generator.GenerateKey(3, P8); // Key2
            generator.GenerateKey(1, P8); // Key1
            int progress = 0;

            // Decrypting Each Block
            foreach (string block in blocks)
            {
                Block newBlock = new Block(block);
                LBL_status.Text = "Decrypting this Block : " + block;
                newBlock.InitialPermutation(IP);
                for (int i = 0; i < 2; i++)
                {
                    newBlock.ExpandRight(EP);
                    newBlock.XORWithKey(generator.SubKeys[i]);
                    newBlock.SubstitutionBoxes(S0, S1);
                    newBlock.PermutateS_BoxOutput(P4);
                    newBlock.XORWithLeft();
                    if (i == 1)
                        break;
                    newBlock.Swap();
                }
                newBlock.IrregularSwap();
                newBlock.InversPermutation(IPinvers);
                TXT_decryptedText.Text += newBlock.PlainTextBlock;
                progress += 10;
                BGW_Decryption.ReportProgress(progress);
            }
        }

        private void BGW_Decryption_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BGW_Decryption_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Disable Timer
            TIM_Operation.Enabled = false;
            timer = 0;

            LBL_status.Text = "Decryption Completed Successfully";
            MessageBox.Show("Operation Finished With No Error", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Reset Progress Bar
            progressBar1.Value = 0;

            // Show Cipher Text Info in Information Panel
            TXT_plainBits.Text = TXT_decryptedText.Text.Count().ToString() + " Bits";
            TXT_plainBytes.Text = Convert.ToString(TXT_decryptedText.Text.Count() / 8) + " Bytes";
            // Show Source Text Info in Information Panel
            TXT_sourceBits.Text = TXT_sourceText.Text.Count().ToString() + " Bits";
            TXT_sourceBytes.Text = Convert.ToString(TXT_sourceText.Text.Count() / 8) + " Bytes";
        }

        

        
    }
}

