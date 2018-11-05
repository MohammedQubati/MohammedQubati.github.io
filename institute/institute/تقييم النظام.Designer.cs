namespace institute
{
    partial class تقييم_النظام
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chkVGood = new System.Windows.Forms.CheckBox();
            this.chkGood = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(113, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "كيف كان أداء النظام ؟";
            // 
            // chkVGood
            // 
            this.chkVGood.AutoSize = true;
            this.chkVGood.Location = new System.Drawing.Point(193, 61);
            this.chkVGood.Name = "chkVGood";
            this.chkVGood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkVGood.Size = new System.Drawing.Size(62, 17);
            this.chkVGood.TabIndex = 2;
            this.chkVGood.Text = "جيد جدا";
            this.chkVGood.UseVisualStyleBackColor = true;
            // 
            // chkGood
            // 
            this.chkGood.AutoSize = true;
            this.chkGood.Location = new System.Drawing.Point(212, 84);
            this.chkGood.Name = "chkGood";
            this.chkGood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGood.Size = new System.Drawing.Size(43, 17);
            this.chkGood.TabIndex = 3;
            this.chkGood.Text = "جيد";
            this.chkGood.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 269);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 34);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "إرسال";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "جيد جدا",
            "جيد"});
            this.checkedListBox1.Location = new System.Drawing.Point(135, 116);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(195, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "المدينه";
            // 
            // تقييم_النظام
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 315);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.chkGood);
            this.Controls.Add(this.chkVGood);
            this.Controls.Add(this.label1);
            this.Name = "تقييم_النظام";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقييم_النظام";
            this.Load += new System.EventHandler(this.تقييم_النظام_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkVGood;
        private System.Windows.Forms.CheckBox chkGood;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;

    }
}