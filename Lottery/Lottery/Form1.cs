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
        List<int> myNumList1;
        List<int> myNumList2;
        List<int> myNumList3;
        List<int> myNumTemp = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_dButton(8, 10, tabPage1, myDButtonList1);
            generate_dButton(7, 7, tabPage2, myDButtonList2);
            generate_dButton(5, 8, tabPage3, myDButtonList3);

        }

        private void dButton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            //myNumTemp = new List<int>();
            //tbBingoNumber.Text = "";
            string strNum = "";

            if (myButton.BackColor == Color.White)
            {
                if (myNumTemp.Count == 10)
                {
                    MessageBox.Show("數量超出10位");
                }
                else
                {
                    myButton.BackColor = Color.Red;
                    myNumTemp.Add(Convert.ToInt32(myButton.Text));
                }
            } else
            {
                myButton.BackColor = Color.White;
                myNumTemp.Remove(Convert.ToInt32(myButton.Text));                   
            }

            foreach (int myNum in myNumTemp)
            {
                strNum += myNum + ", ";
            }
            tbBingoNumber.Text = strNum;
            
            //MessageBox.Show(string.Format("{0}", myButton.Name));
        }

        private void generate_dButton(int row, int col, TabPage pageNum, List<Button> myDButton)
        {
            int Num = 1;
            myDButton = new List<Button>();
            int intSPointi = 0;
            int intSPointj = 0;
            int intSpace = 0;
            int intSize = 0;
            if (pageNum == tabPage1)
            {
                intSPointi = 20;
                intSPointj = 40;
                intSpace = 45;
                intSize = 45;
            } else if (pageNum == tabPage2)
            {
                intSPointi = 20;
                intSPointj = 70;
                intSpace = 50;
                intSize = 50;
            } else
            {
                intSPointi = 20;
                intSPointj = 20;
                intSpace = 60;
                intSize = 60;
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button dButton = new Button();
                    
                    dButton.BackColor = Color.White;
                    dButton.ForeColor = Color.Black;
                    dButton.Location = new Point(intSPointj + intSpace * j, intSPointi + intSpace * i);
                    dButton.Size = new Size(intSize, intSize);
                    dButton.Text = Num.ToString();
                    dButton.Name = "btn" + pageNum + Num.ToString();
                    dButton.Tag = pageNum;
                    dButton.Font = new Font("微軟正黑體", 12);
                    dButton.Click += new EventHandler(dButton_Click);

                    Num++;
                    pageNum.Controls.Add(dButton);
                    pageNum.Visible = true;
                    myDButton.Add(dButton);

                    if (pageNum == tabPage3 && Num == 40) break;
                }
            }

        }

        private void btnBingoConfirm_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";
        }

        private void btnBingoReset_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";
            myNumTemp.Clear();
        }

        private void btnBingoAuto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            //tbBingoNumber.Text = "";
            myNumList1 = new List<int>();
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
                strNum += myList.ToString() + ", ";
            }
            tbBingoNumber.Text = strNum;
        }
                        
    }
}
