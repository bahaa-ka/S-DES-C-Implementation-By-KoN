using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_DES_By_KoN
{
    class Block
    {
        private string left;
        private string right;
        private string copiedRight;
        private string plainTextBlock;

        public Block(string plainTextBlock)
        {
            PlainTextBlock = plainTextBlock;
        }        
        public string Left { get => left; set => left = value; }
        public string Right { get => right; set => right = value; }        
        public string PlainTextBlock { get => plainTextBlock; set => plainTextBlock = value; }
        public string CopiedRight { get => copiedRight; set => copiedRight = value; }

        public void InitialPermutation(int[] IP)
        {
            char[] permutatedBlock = new char[8];
            for(int i = 0; i < permutatedBlock.Length; i++)
            {
                permutatedBlock[i] = this.PlainTextBlock[IP[i] - 1];
            }
            this.PlainTextBlock = new string(permutatedBlock);
            this.Left = PlainTextBlock.Substring(0, 4);
            this.Right = PlainTextBlock.Substring(4);
            this.CopiedRight = this.Right;
        }
        public void ExpandRight(int[] EP)
        {
            char[] temp = Right.ToArray();
            char[] expandedRight = new char[8];
            for(int i = 0; i< expandedRight.Length; i++)
            {
                expandedRight[i] = temp[EP[i] - 1];
            }
            this.Right = new string(expandedRight);
        }
        public void XORWithKey(string roundKey)
        {
            char[] temp1 = roundKey.ToArray();
            char[] temp2 = this.Right.ToArray();
            int[] temp3 = new int[8];
            this.Right = null;
            for (int i = 0; i < temp3.Length; i++)
            {
                temp3[i] = temp1[i] ^ temp2[i];
                this.Right += temp3[i].ToString();
            }                            
        }
        public void SubstitutionBoxes(string[,] S0,string[,] S1)
        {
            // Dividing The Result of XOR (8 bit) To Right And Left With (4 bit) for each
            string l = this.Right.Substring(0, 4);
            string r = this.Right.Substring(4);

            // Column And Row For S0 (2 bit output)
            int S0Row = Convert.ToInt32(l.First().ToString() + l.Last().ToString(),2);
            int S0Col = Convert.ToInt32(l[1].ToString() + l[2].ToString(),2);

            // Column And Row For S1 (2 bit output)
            int S1Row = Convert.ToInt32(r.First().ToString() + r.Last().ToString(),2);
            int S1Col = Convert.ToInt32(r[1].ToString() + r[2].ToString(),2);

            // Combine S0 And S1 output (4 bit output)
            this.Right = S0[S0Row,S0Col].ToString() + S1[S1Row,S1Col];
        }
        public void PermutateS_BoxOutput(int[] P4)
        {
            char[] temp = this.Right.ToArray();
            char[] permutatedRight = new char[4];
            for(int i = 0; i < permutatedRight.Length; i++)
            {
                permutatedRight[i] = temp[P4[i] - 1];
            }
            this.Right = new string(permutatedRight);
        }
        public void XORWithLeft()
        {
            char[] r = this.Right.ToArray();
            char[] l = this.Left.ToArray();
            int[] result = new int[4];
            this.Right = null;
            for(int i = 0; i < result.Length; i++)
            {
                result[i] = r[i] ^ l[i];
                this.Right += result[i].ToString();
            }                        
        }
        public void Swap()
        {
            this.Left = CopiedRight;
            this.CopiedRight = this.Right;
        }
        public void IrregularSwap()
        {
            this.Left = this.Right;
            this.Right = this.CopiedRight;
        }
        public void InversPermutation(int[] IPinverse)
        {
            PlainTextBlock = this.Left + this.Right;
            //char[] temp = PlainTextBlock.ToArray();
            char[] permutatedText = new char[8];
            for(int i = 0; i < permutatedText.Length; i++)
            {
                permutatedText[i] = this.PlainTextBlock[IPinverse[i] - 1];
            }
            PlainTextBlock = new string(permutatedText);
        }

    }
}
