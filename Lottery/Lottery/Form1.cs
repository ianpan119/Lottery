using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        List<Button> myDButtonList1 = new List<Button>();
        List<Button> myDButtonList2 = new List<Button>();
        List<Button> myDButtonList3 = new List<Button>();
        List<int> myNumList1 = new List<int>();
        List<int> myNumList2 = new List<int>();
        List<int> myNumList3 = new List<int>();
        List<int> myNumTemp = new List<int>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_Bingo_dButton(8, 10);
            generate_Big_dButton(7, 7);
            generate_539_dButton(5, 8);
        }

        private void dButton_Bingo_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            string strNum = "";
            if (myButton.BackColor == Color.White)
            {
                if (myNumList1.Count == 10)
                {
                    MessageBox.Show("請選擇10個數字");
                } else
                {
                    myButton.BackColor = Color.Red;
                    myNumList1.Add(Convert.ToInt32(myButton.Text));
                }
                
            } else
            {
                myButton.BackColor = Color.White;
                myNumList1.Remove(Convert.ToInt32(myButton.Text));
            }

            foreach (int myNum in myNumList1)
            {
                strNum += string.Format("{0:D2}, ", myNum);
            }
            tbBingoNumber.Text = strNum;
        }

        private void dButton_Big_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            string strNum = "";
            if (myButton.BackColor == Color.White)
            {
                if (myNumList2.Count == 6)
                {
                    MessageBox.Show("請選擇6個數字");
                }
                else
                {
                    myButton.BackColor = Color.Red;
                    myNumList2.Add(Convert.ToInt32(myButton.Text));
                }

            }
            else
            {
                myButton.BackColor = Color.White;
                myNumList2.Remove(Convert.ToInt32(myButton.Text));
            }

            foreach (int myNum in myNumList2)
            {
                strNum += string.Format("{0:D2}, ", myNum);
            }
            tbBigNumber.Text = strNum;
        }

        private void dButton_539_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            string strNum = "";
            if (myButton.BackColor == Color.White)
            {
                if (myNumList3.Count == 5)
                {
                    MessageBox.Show("請選擇5個數字");
                }
                else
                {
                    myButton.BackColor = Color.Red;
                    myNumList3.Add(Convert.ToInt32(myButton.Text));
                }

            }
            else
            {
                myButton.BackColor = Color.White;
                myNumList3.Remove(Convert.ToInt32(myButton.Text));
            }

            foreach (int myNum in myNumList3)
            {
                strNum += string.Format("{0:D2}, ", myNum);
            }
            tb539Number.Text = strNum;
        }

        private void generate_Bingo_dButton(int row, int col)
        {
            int Num = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button dButton = new Button();

                    dButton.BackColor = Color.White;
                    dButton.ForeColor = Color.Black;
                    dButton.Location = new Point(40 + 45 * j, 20 + 45 * i);
                    dButton.Size = new Size(45, 45);
                    dButton.Text = Num.ToString();
                    dButton.Name = "btn" + "Bingo" + Num.ToString();
                    dButton.Font = new Font("微軟正黑體", 12);
                    dButton.Click += new EventHandler(dButton_Bingo_Click);

                    Num++;
                    tabPage1.Controls.Add(dButton);
                    
                    myDButtonList1.Add(dButton);

                }
            }
        }

        private void generate_Big_dButton(int row, int col)
        {
            int Num = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button dButton = new Button();

                    dButton.BackColor = Color.White;
                    dButton.ForeColor = Color.Black;
                    dButton.Location = new Point(70 + 50 * j, 20 + 50 * i);
                    dButton.Size = new Size(50, 50);
                    dButton.Text = Num.ToString();
                    dButton.Name = "btn" + "Big" + Num.ToString();
                    dButton.Font = new Font("微軟正黑體", 12);
                    dButton.Click += new EventHandler(dButton_Big_Click);

                    Num++;
                    tabPage2.Controls.Add(dButton);

                    myDButtonList2.Add(dButton);

                }
            }
        }

        private void generate_539_dButton(int row, int col)
        {
            int Num = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button dButton = new Button();

                    dButton.BackColor = Color.White;
                    dButton.ForeColor = Color.Black;
                    dButton.Location = new Point(20 + 60 * j, 20 + 60 * i);
                    dButton.Size = new Size(60, 60);
                    dButton.Text = Num.ToString();
                    dButton.Name = "btn" + "539" + Num.ToString();
                    dButton.Font = new Font("微軟正黑體", 12);
                    dButton.Click += new EventHandler(dButton_539_Click);

                    Num++;
                    tabPage3.Controls.Add(dButton);

                    myDButtonList3.Add(dButton);

                    if (Num == 40) break;
                }
            }
        }

        private void btnBingoAuto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            myNumList1.Clear();
            string strNum = "";
            do
            {
                int Number = R.Next(1, 81);
                if (myNumList1.IndexOf(Number) < 0)
                {
                    myNumList1.Add(Number);
                }

            } while (myNumList1.Count < 10);

            myNumList1.Sort();

            foreach (int myList in myNumList1)
            {
                strNum += string.Format("{0:D2}, ", myList);
            }
            tbBingoNumber.Text = strNum;

            myNumList1.Clear();
        }

        private void btnBingoConfirm_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";


            myNumList1.Clear();
        }

        private void btnBingoReset_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";
            myNumList1.Clear();
        }

        private void btnBigAuto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            //tbBingoNumber.Text = "";
            myNumList2.Clear();
            string strNum = "";
            do
            {
                int Number = R.Next(1, 49);
                if (myNumList2.IndexOf(Number) < 0)
                {
                    myNumList2.Add(Number);
                }

            } while (myNumList2.Count < 6);

            myNumList2.Sort();

            foreach (int myList in myNumList2)
            {
                strNum += string.Format("{0:D2}, ", myList);
            }
            tbBigNumber.Text = strNum;

            myNumList2.Clear();
        }

        private void btnBigConfirm_Click(object sender, EventArgs e)
        {
            tbBigNumber.Text = "";


            myNumList2.Clear();
        }

        private void btnBigReset_Click(object sender, EventArgs e)
        {
            tbBigNumber.Text = "";
            myNumList2.Clear();
        }

        private void btn539Auto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            //tbBingoNumber.Text = "";
            myNumList3.Clear();
            string strNum = "";
            do
            {
                int Number = R.Next(1, 39);
                if (myNumList3.IndexOf(Number) < 0)
                {
                    myNumList3.Add(Number);
                }

            } while (myNumList3.Count < 5);

            myNumList3.Sort();

            foreach (int myList in myNumList3)
            {
                strNum += string.Format("{0:D2}, ", myList);
            }
            tb539Number.Text = strNum;

            myNumList3.Clear();
        }

        private void btn539Confirm_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";


            myNumList3.Clear();
        }

        private void btn539Reset_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";
            myNumList3.Clear();
        }

    }
}
