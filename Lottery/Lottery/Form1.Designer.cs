namespace Lottery
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn539Confirm = new System.Windows.Forms.Button();
            this.btn539Reset = new System.Windows.Forms.Button();
            this.btn539Auto = new System.Windows.Forms.Button();
            this.tb539Number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbox539 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBigConfirm = new System.Windows.Forms.Button();
            this.btnBigReset = new System.Windows.Forms.Button();
            this.btnBigAuto = new System.Windows.Forms.Button();
            this.tbBigNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboxBig = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBingoReset = new System.Windows.Forms.Button();
            this.btnBingoConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBingoAuto = new System.Windows.Forms.Button();
            this.tbBingoNumber = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lboxBingo = new System.Windows.Forms.ListBox();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LimeGreen;
            this.tabPage3.Controls.Add(this.btn539Confirm);
            this.tabPage3.Controls.Add(this.btn539Reset);
            this.tabPage3.Controls.Add(this.btn539Auto);
            this.tabPage3.Controls.Add(this.tb539Number);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1036, 635);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "今彩539";
            // 
            // btn539Confirm
            // 
            this.btn539Confirm.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn539Confirm.Location = new System.Drawing.Point(277, 558);
            this.btn539Confirm.Name = "btn539Confirm";
            this.btn539Confirm.Size = new System.Drawing.Size(145, 68);
            this.btn539Confirm.TabIndex = 12;
            this.btn539Confirm.Text = "儲存";
            this.btn539Confirm.UseVisualStyleBackColor = true;
            this.btn539Confirm.Click += new System.EventHandler(this.btn539Confirm_Click);
            // 
            // btn539Reset
            // 
            this.btn539Reset.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn539Reset.Location = new System.Drawing.Point(487, 558);
            this.btn539Reset.Name = "btn539Reset";
            this.btn539Reset.Size = new System.Drawing.Size(145, 68);
            this.btn539Reset.TabIndex = 11;
            this.btn539Reset.Text = "清空";
            this.btn539Reset.UseVisualStyleBackColor = true;
            this.btn539Reset.Click += new System.EventHandler(this.btn539Reset_Click);
            // 
            // btn539Auto
            // 
            this.btn539Auto.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btn539Auto.Location = new System.Drawing.Point(67, 558);
            this.btn539Auto.Name = "btn539Auto";
            this.btn539Auto.Size = new System.Drawing.Size(145, 68);
            this.btn539Auto.TabIndex = 10;
            this.btn539Auto.Text = "自動選號";
            this.btn539Auto.UseVisualStyleBackColor = true;
            this.btn539Auto.Click += new System.EventHandler(this.btn539Auto_Click);
            // 
            // tb539Number
            // 
            this.tb539Number.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb539Number.Location = new System.Drawing.Point(67, 506);
            this.tb539Number.Margin = new System.Windows.Forms.Padding(4);
            this.tb539Number.Name = "tb539Number";
            this.tb539Number.ReadOnly = true;
            this.tb539Number.Size = new System.Drawing.Size(565, 47);
            this.tb539Number.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(62, 475);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "選擇的號碼";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbox539);
            this.groupBox3.Location = new System.Drawing.Point(669, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(357, 616);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "歷史紀錄";
            // 
            // lbox539
            // 
            this.lbox539.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbox539.FormattingEnabled = true;
            this.lbox539.ItemHeight = 27;
            this.lbox539.Location = new System.Drawing.Point(8, 35);
            this.lbox539.Margin = new System.Windows.Forms.Padding(4);
            this.lbox539.Name = "lbox539";
            this.lbox539.Size = new System.Drawing.Size(341, 382);
            this.lbox539.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.btnBigConfirm);
            this.tabPage2.Controls.Add(this.btnBigReset);
            this.tabPage2.Controls.Add(this.btnBigAuto);
            this.tabPage2.Controls.Add(this.tbBigNumber);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1036, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "大樂透";
            // 
            // btnBigConfirm
            // 
            this.btnBigConfirm.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btnBigConfirm.Location = new System.Drawing.Point(277, 558);
            this.btnBigConfirm.Name = "btnBigConfirm";
            this.btnBigConfirm.Size = new System.Drawing.Size(145, 68);
            this.btnBigConfirm.TabIndex = 11;
            this.btnBigConfirm.Text = "儲存";
            this.btnBigConfirm.UseVisualStyleBackColor = true;
            this.btnBigConfirm.Click += new System.EventHandler(this.btnBigConfirm_Click);
            // 
            // btnBigReset
            // 
            this.btnBigReset.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btnBigReset.Location = new System.Drawing.Point(487, 558);
            this.btnBigReset.Name = "btnBigReset";
            this.btnBigReset.Size = new System.Drawing.Size(145, 68);
            this.btnBigReset.TabIndex = 10;
            this.btnBigReset.Text = "清空";
            this.btnBigReset.UseVisualStyleBackColor = true;
            this.btnBigReset.Click += new System.EventHandler(this.btnBigReset_Click);
            // 
            // btnBigAuto
            // 
            this.btnBigAuto.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.btnBigAuto.Location = new System.Drawing.Point(67, 558);
            this.btnBigAuto.Name = "btnBigAuto";
            this.btnBigAuto.Size = new System.Drawing.Size(145, 68);
            this.btnBigAuto.TabIndex = 9;
            this.btnBigAuto.Text = "自動選號";
            this.btnBigAuto.UseVisualStyleBackColor = true;
            this.btnBigAuto.Click += new System.EventHandler(this.btnBigAuto_Click);
            // 
            // tbBigNumber
            // 
            this.tbBigNumber.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBigNumber.Location = new System.Drawing.Point(67, 506);
            this.tbBigNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbBigNumber.Name = "tbBigNumber";
            this.tbBigNumber.ReadOnly = true;
            this.tbBigNumber.Size = new System.Drawing.Size(565, 47);
            this.tbBigNumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(62, 475);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "選擇的號碼";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxBig);
            this.groupBox2.Location = new System.Drawing.Point(669, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(357, 616);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "歷史紀錄";
            // 
            // lboxBig
            // 
            this.lboxBig.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxBig.FormattingEnabled = true;
            this.lboxBig.ItemHeight = 27;
            this.lboxBig.Location = new System.Drawing.Point(8, 35);
            this.lboxBig.Margin = new System.Windows.Forms.Padding(4);
            this.lboxBig.Name = "lboxBig";
            this.lboxBig.Size = new System.Drawing.Size(341, 382);
            this.lboxBig.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage1.Controls.Add(this.btnBingoReset);
            this.tabPage1.Controls.Add(this.btnBingoConfirm);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnBingoAuto);
            this.tabPage1.Controls.Add(this.tbBingoNumber);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1036, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BINGO BINGO賓果賓果";
            // 
            // btnBingoReset
            // 
            this.btnBingoReset.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBingoReset.Location = new System.Drawing.Point(487, 558);
            this.btnBingoReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnBingoReset.Name = "btnBingoReset";
            this.btnBingoReset.Size = new System.Drawing.Size(145, 68);
            this.btnBingoReset.TabIndex = 0;
            this.btnBingoReset.Text = "清空";
            this.btnBingoReset.UseVisualStyleBackColor = true;
            this.btnBingoReset.Click += new System.EventHandler(this.btnBingoReset_Click);
            // 
            // btnBingoConfirm
            // 
            this.btnBingoConfirm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBingoConfirm.Location = new System.Drawing.Point(277, 558);
            this.btnBingoConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnBingoConfirm.Name = "btnBingoConfirm";
            this.btnBingoConfirm.Size = new System.Drawing.Size(145, 68);
            this.btnBingoConfirm.TabIndex = 0;
            this.btnBingoConfirm.Text = "儲存";
            this.btnBingoConfirm.UseVisualStyleBackColor = true;
            this.btnBingoConfirm.Click += new System.EventHandler(this.btnBingoConfirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxBingo);
            this.groupBox1.Location = new System.Drawing.Point(669, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(357, 616);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "歷史紀錄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(62, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "選擇的號碼";
            // 
            // btnBingoAuto
            // 
            this.btnBingoAuto.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBingoAuto.Location = new System.Drawing.Point(67, 558);
            this.btnBingoAuto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBingoAuto.Name = "btnBingoAuto";
            this.btnBingoAuto.Size = new System.Drawing.Size(145, 68);
            this.btnBingoAuto.TabIndex = 0;
            this.btnBingoAuto.Text = "自動選號";
            this.btnBingoAuto.UseVisualStyleBackColor = true;
            this.btnBingoAuto.Click += new System.EventHandler(this.btnBingoAuto_Click);
            // 
            // tbBingoNumber
            // 
            this.tbBingoNumber.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbBingoNumber.Location = new System.Drawing.Point(67, 506);
            this.tbBingoNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbBingoNumber.Name = "tbBingoNumber";
            this.tbBingoNumber.ReadOnly = true;
            this.tbBingoNumber.Size = new System.Drawing.Size(565, 47);
            this.tbBingoNumber.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(59, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // lboxBingo
            // 
            this.lboxBingo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxBingo.FormattingEnabled = true;
            this.lboxBingo.ItemHeight = 27;
            this.lboxBingo.Location = new System.Drawing.Point(8, 35);
            this.lboxBingo.Margin = new System.Windows.Forms.Padding(4);
            this.lboxBingo.Name = "lboxBingo";
            this.lboxBingo.Size = new System.Drawing.Size(341, 382);
            this.lboxBingo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1155, 764);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbBingoNumber;
        private System.Windows.Forms.Button btnBingoReset;
        private System.Windows.Forms.Button btnBingoConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnBingoAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbox539;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lboxBig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb539Number;
        private System.Windows.Forms.TextBox tbBigNumber;
        private System.Windows.Forms.Button btn539Confirm;
        private System.Windows.Forms.Button btn539Reset;
        private System.Windows.Forms.Button btn539Auto;
        private System.Windows.Forms.Button btnBigConfirm;
        private System.Windows.Forms.Button btnBigReset;
        private System.Windows.Forms.Button btnBigAuto;
        private System.Windows.Forms.ListBox lboxBingo;
    }
}

