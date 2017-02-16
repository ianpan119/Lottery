using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lottery
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder scsb;
        List<Button> myDButtonList1 = new List<Button>();
        List<Button> myDButtonList2 = new List<Button>();
        List<Button> myDButtonList3 = new List<Button>();
        List<int> myNumList1 = new List<int>();
        List<int> myNumList2 = new List<int>();
        List<int> myNumList3 = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_Bingo_dButton(8, 10);
            generate_Big_dButton(7, 7);
            generate_539_dButton(5, 8);

            /*
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"IAN-PC\MSSQLSERVER16";
            scsb.InitialCatalog = "csharp1";
            scsb.IntegratedSecurity = true;
            */
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"(localdb)\MSSQLLocalDB";
            scsb.AttachDBFilename = @"|DataDirectory|\DB\C sharp.mdf";
            scsb.IntegratedSecurity = true;
            
            update_listbox("BingoBingo", lboxBingo);
            update_listbox("BigBingo", lboxBig);
            update_listbox("539", lbox539);
            
        }

        private void dButton_Bingo_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            string strNum = "";

            if (cbStar.SelectedIndex >= 0)
            {
                if (myButton.BackColor == Color.White)
                {
                    if (myNumList1.Count == (cbStar.SelectedIndex + 1))
                    {
                        MessageBox.Show("請選擇" + (cbStar.SelectedIndex + 1) + "個數字");
                    }
                    else
                    {
                        myButton.BackColor = Color.Red;
                        myNumList1.Add(Convert.ToInt32(myButton.Text));
                    }

                }
                else
                {
                    myButton.BackColor = Color.White;
                    myNumList1.Remove(Convert.ToInt32(myButton.Text));
                }
            } else
            {
                MessageBox.Show("請選擇星數");
            }
            
            myNumList1.Sort();
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
            myNumList2.Sort();
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
            myNumList3.Sort();
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
                    dButton.Location = new Point(20 + 45 * j, 20 + 45 * i);
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
                    dButton.Location = new Point(10 + 60 * j, 20 + 60 * i);
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
            string strNum = "";
            myNumList1.Clear();
            int count = cbStar.SelectedIndex + 1;

            foreach (Button myButton in myDButtonList1)
            {
                if (myButton.BackColor == Color.Red)
                {
                    myNumList1.Add(Convert.ToInt32(myButton.Text));

                }
                else
                {
                    myButton.BackColor = Color.White;
                }
            }

            if (count == 0)
            {
                MessageBox.Show("請選擇星數");
            } else if (myNumList1.Count >= count)
            {
                MessageBox.Show("請選擇小於" + count + "個數字");
            }

            while (myNumList1.Count < count)
            {
                int Number = R.Next(1, 81);
                if (myNumList1.IndexOf(Number) < 0)
                {
                    myNumList1.Add(Number);
                    myDButtonList1[Number - 1].BackColor = Color.Orange;
                }
            }

            myNumList1.Sort();

            foreach (int myNum in myNumList1)
            {
                strNum += string.Format("{0:D2}, ", myNum);
            }

            tbBingoNumber.Text = strNum;
        }

        private void btnBigAuto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            string strNum = "";
            myNumList2.Clear();            

            foreach (Button myButton in myDButtonList2)
            {
                if (myButton.BackColor == Color.Red)
                {
                    myNumList2.Add(Convert.ToInt32(myButton.Text));
                    
                } else
                {
                    myButton.BackColor = Color.White;
                }
            }

            if (myNumList2.Count == 6)
            {
                MessageBox.Show("請選擇小於6個數字");
            }

            while (myNumList2.Count < 6)
            {
                int Number = R.Next(1, 50);
                if (myNumList2.IndexOf(Number) < 0)
                {
                    myNumList2.Add(Number);
                    myDButtonList2[Number - 1].BackColor = Color.Orange;
                }
            }

            myNumList2.Sort();

            foreach (int myNum in myNumList2)
            {
                strNum += string.Format("{0:D2}, ", myNum);
            }

            tbBigNumber.Text = strNum;
        }

        private void btn539Auto_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            string strNum = "";
            myNumList3.Clear();

            foreach (Button myButton in myDButtonList3)
            {
                if (myButton.BackColor == Color.Red)
                {
                    myNumList3.Add(Convert.ToInt32(myButton.Text));

                }
                else
                {
                    myButton.BackColor = Color.White;
                }
            }

            if (myNumList3.Count == 5)
            {
                MessageBox.Show("請選擇小於5個數字");
            }

            while (myNumList3.Count < 5)
            {
                int Number = R.Next(1, 40);
                if (myNumList3.IndexOf(Number) < 0)
                {
                    myNumList3.Add(Number);
                    myDButtonList3[Number - 1].BackColor = Color.Orange;
                }
            }

            myNumList3.Sort();

            foreach (int myNum in myNumList3)
            {
                strNum += string.Format("{0:D2}, ", myNum);
            }

            tb539Number.Text = strNum;
        }

        private void btnBingoConfirm_Click(object sender, EventArgs e)
        {
            if (cbStar.SelectedIndex >= 0)
            {
                if (myNumList1.Count == (cbStar.SelectedIndex + 1))
                {
                    insert_date("BingoBingo", myNumList1);

                    tbBingoNumber.Text = "";
                    myNumList1.Clear();

                    foreach (Button myButton in myDButtonList1)
                    {
                        myButton.BackColor = Color.White;
                    }

                    update_listbox("BingoBingo", lboxBingo);
                }
                else
                {
                    MessageBox.Show("請選擇" + (cbStar.SelectedIndex + 1) + "個數字");
                }
            } else
            {
                MessageBox.Show("請選擇星數");
            }
        }

        private void btnBigConfirm_Click(object sender, EventArgs e)
        {
            if (myNumList2.Count == 6)
            {
                insert_date("BigBingo", myNumList2);

                tbBigNumber.Text = "";
                myNumList2.Clear();

                foreach (Button myButton in myDButtonList2)
                {
                    myButton.BackColor = Color.White;
                }

                update_listbox("BigBingo", lboxBig);
            }
            else
            {
                MessageBox.Show("請選擇6個數字");
            }
        }

        private void btn539Confirm_Click(object sender, EventArgs e)
        {
            if (myNumList3.Count == 5)
            {
                insert_date("539", myNumList3);

                tb539Number.Text = "";
                myNumList3.Clear();

                foreach (Button myButton in myDButtonList3)
                {
                    myButton.BackColor = Color.White;
                }

                update_listbox("539", lbox539);
            }
            else
            {
                MessageBox.Show("請選擇5個數字");
            }

        }

        private void btnBingoReset_Click(object sender, EventArgs e)
        {
            tbBingoNumber.Text = "";
            myNumList1.Clear();
            foreach (Button myButton in myDButtonList1)
            {
                myButton.BackColor = Color.White;
            }
        }

        private void btnBigReset_Click(object sender, EventArgs e)
        {
            tbBigNumber.Text = "";
            myNumList2.Clear();
            foreach (Button myButton in myDButtonList2)
            {
                myButton.BackColor = Color.White;
            }
        }

        private void btn539Reset_Click(object sender, EventArgs e)
        {
            tb539Number.Text = "";
            myNumList3.Clear();
            foreach (Button myButton in myDButtonList3)
            {
                myButton.BackColor = Color.White;
            }
        }

        private void insert_date(string lottery, List<int> myNumList)
        {
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = "insert into myLottery values(@Lottery, @Num1, @Num2, @Num3, @Num4, @Num5, @Num6, @Num7, @Num8, @Num9, @Num10)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Lottery", lottery);
            string strNum = "";
            
            for (int count = 1; count <= 10; count++)
            {
                if (count > myNumList.Count)
                {
                    strNum = string.Format("@" + "Num" + count);
                    cmd.Parameters.AddWithValue(strNum, DBNull.Value);
                }
                else
                {
                    strNum = string.Format("@" + "Num" + count);
                    cmd.Parameters.AddWithValue(strNum, myNumList[count - 1]);
                }
            }

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void update_listbox(string lottery, ListBox myListBox)
        {
            myListBox.Items.Clear();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = string.Format("select * from myLottery where 彩券 = '{0}';", lottery);
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            int count = 0;
            while (reader.Read())
            {
                myListBox.Items.Add(string.Format("{0:D2}-{1:D2} {2:D2} {3:D2} {4:D2} {5:D2} {6:D2} {7:D2} {8:D2} {9:D2} {10:D2}",
                    reader["id"], reader["號碼1"], reader["號碼2"], reader["號碼3"], 
                    reader["號碼4"], reader["號碼5"], reader["號碼6"], reader["號碼7"], 
                    reader["號碼8"], reader["號碼9"], reader["號碼10"]));
                count++;
            }
            myListBox.Items.Insert(0, "總共" + count + "筆");
            reader.Close();
            con.Close();                                   
        }

        private void delete_listbox(string lottery, ListBox myListBox)
        {
            int index = myListBox.SelectedIndex;
            
            if (index > 0)
            {
                DialogResult R;
                R = MessageBox.Show("是否刪除資料?", "刪除資料", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (R == DialogResult.Yes)
                {
                    string s = (string)myListBox.Items[index];
                    string[] sArray = s.Split('-');
                    SqlConnection con = new SqlConnection(scsb.ToString());
                    con.Open();
                    string strSQL = string.Format("delete from myLottery where id = '{0}';", sArray[0]);
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@OldNum", sArray[0]);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("資料刪除成功", "刪除資料");

                    update_listbox(lottery, myListBox);
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的筆數");
            }
        }

        private void clear_listbox(string lottery, ListBox myListBox)
        {
            DialogResult R;
            R = MessageBox.Show("是否清除所有資料?", "清除資料",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
            {                
                SqlConnection con = new SqlConnection(scsb.ToString());
                con.Open();
                string strSQL = string.Format("delete from myLottery where 彩券 = '{0}';", lottery);
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@OldLottery", lottery);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料清除成功", "清除資料");

                update_listbox(lottery, myListBox);
            }
        }

        private void lottery(string lottery)
        {
            myNumList2.Clear();
            tbBigNumber.Text = "";

            List<int> myNumList = new List<int>();
            SqlConnection con = new SqlConnection(scsb.ToString());
            con.Open();
            string strSQL = string.Format("select * from myLottery where 彩券 = '{0}';", lottery);
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            int counts = 0;
            int num = 1;
            string strMsg = "本期開獎號碼: ";
            string strNum = "";
            Random R = new Random();

            while (myNumList2.Count < 7)
            {
                int Number = R.Next(1, 50);
                if (myNumList2.IndexOf(Number) < 0)
                {
                    myNumList2.Add(Number);                    
                }
            }
            myNumList2.Sort();
            
            foreach (int myNum in myNumList2)
            {            
                if (num == myNumList2.Count)
                {
                    strMsg += " 特別號:";
                }
                strMsg += myNum.ToString() + " ";
                num++;
            }
            

            while (reader.Read())
            {
                myNumList.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    strNum = "號碼" + i.ToString();
                    
                    if (reader[strNum] == DBNull.Value)
                    {
                        //break;
                    } else
                    {
                        myNumList.Add((int)reader[strNum]);
                    }
                }

                count = 0;
                counts = 0;

                for (int i = 0; i < myNumList2.Count; i++)
                {
                    if (i == (myNumList2.Count - 1))
                    {
                        if (myNumList.IndexOf(myNumList2[i]) >= 0)
                        {
                            counts++;
                        }
                    } else 
                    {
                        if (myNumList.IndexOf(myNumList2[i]) >= 0)
                        {
                            count++;
                        }
                    }
                }
                strMsg += "\n" + count + counts;
                
                switch (count)
                {
                    case 2:
                        if (counts == 1)
                        {
                            strMsg += "您中了\"柒獎\"";
                        }
                        break;

                    case 3:
                        if (counts == 1)
                        { 
                            strMsg += "您中了\"陸獎\"";
                        } else
                        {
                            strMsg += "您中了\"普獎\"";
                        }
                        break;

                    case 4:
                        if (counts == 1)
                        {
                            strMsg += "您中了\"肆獎\"";
                        }
                        else
                        {
                            strMsg += "您中了\"伍獎\"";
                        }
                        break;

                    case 5:
                        if (counts == 1)
                        {
                            strMsg += "您中了\"貳獎\"";
                        }
                        else
                        {
                            strMsg += "您中了\"參獎\"";
                        }
                        break;

                    case 6:                        
                            strMsg += "您中了\"頭獎\"";                        
                        break;

                    default:
                        break;
                }            
                
            }

            MessageBox.Show(strMsg);
            reader.Close();
            con.Close();
        }

        private void btnBingoDelete_Click(object sender, EventArgs e)
        {
            delete_listbox("BingoBingo", lboxBingo);
        }

        private void btnBigDelete_Click(object sender, EventArgs e)
        {
            delete_listbox("BigBingo", lboxBig);
        }        

        private void btn539Delete_Click(object sender, EventArgs e)
        {
            delete_listbox("539", lbox539);
        }

        private void btnBingoLottery_Click(object sender, EventArgs e)
        {

            
        }

        private void btnBigLottery_Click(object sender, EventArgs e)
        {
            lottery("BigBingo");
        }

        private void btn539Lottery_Click(object sender, EventArgs e)
        {

        }

        private void btnBingoClear_Click(object sender, EventArgs e)
        {
            clear_listbox("BingoBingo", lboxBingo);
        }

        private void btnBigClear_Click(object sender, EventArgs e)
        {
            clear_listbox("BigBingo", lboxBig);
        }

        private void btn539Clear_Click(object sender, EventArgs e)
        {
            clear_listbox("539", lbox539);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R;

            R = MessageBox.Show("您確認要關閉表單?", "表單即將關閉",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (R == DialogResult.Yes)
            {
                //關閉
            }
            else
            {
                //取消
                e.Cancel = true;
            }
        }

        private void btn539Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBigClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBingoClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
