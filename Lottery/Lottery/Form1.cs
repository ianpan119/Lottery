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
        List<int> myNumberList1 = new List<int>();
        List<int> myNumberList2 = new List<int>();
        List<int> myNumberList3 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_dButton(8, 10, tabPage1, myDButtonList1);
            generate_dButton(7, 7, tabPage2, myDButtonList2);
            generate_dButton(4, 10, tabPage3, myDButtonList3);

        }

        private void dButton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            myButton.BackColor = Color.Pink;
            //MessageBox.Show(string.Format("{0}", myButton.Name));
        }

        private void generate_dButton(int row, int col, TabPage pageNum, List<Button> myDButton)
        {
            int Num = 1;
            myDButton = new List<Button>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button dButton = new Button();
                    //dButton.BackgroundImage
                    dButton.BackColor = Color.White;
                    dButton.ForeColor = Color.Black;
                    dButton.Location = new Point(15 + 44 * j, 15 + 44 * i);
                    dButton.Size = new Size(40, 40);
                    dButton.Text = Num.ToString();
                    dButton.Name = "btn" + Num.ToString();
                    dButton.Font = new Font("微軟正黑體", 14);
                    dButton.Click += new EventHandler(dButton_Click);

                    //Controls.Add(dButton);
                    Num++;
                    pageNum.Controls.Add(dButton);
                    myDButton.Add(dButton);

                }
            }

        }

        private void btnBingoConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnBingoReset_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";
        }

        private void btnBingoAuto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            tbBingoNumber.Text = "";

            for (int i = 0; i < 10; i++)
            {
                int indexList = R.Next(1,81);
                tbBingoNumber.Text += indexList.ToString() + " ";
                myDButtonList1[indexList].BackColor = Color.Pink;
                myNumberList1.Add(indexList);                
            }

            foreach (int myList in myNumberList1)
            {
                Console.WriteLine(myList);
            }

        }
    }
}
