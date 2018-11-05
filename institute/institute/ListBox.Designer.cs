namespace institute
{
    partial class ListBox
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
            this.LstBox1 = new System.Windows.Forms.ListBox();
            this.RmoveListBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddListBox = new System.Windows.Forms.Button();
            this.btnClearListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBox1
            // 
            this.LstBox1.FormattingEnabled = true;
            this.LstBox1.Items.AddRange(new object[] {
            ""});
            this.LstBox1.Location = new System.Drawing.Point(44, 59);
            this.LstBox1.Name = "LstBox1";
            this.LstBox1.Size = new System.Drawing.Size(203, 108);
            this.LstBox1.TabIndex = 0;
            this.LstBox1.SelectedIndexChanged += new System.EventHandler(this.LstBox1_SelectedIndexChanged);
            // 
            // RmoveListBox
            // 
            this.RmoveListBox.Location = new System.Drawing.Point(61, 173);
            this.RmoveListBox.Name = "RmoveListBox";
            this.RmoveListBox.Size = new System.Drawing.Size(169, 23);
            this.RmoveListBox.TabIndex = 1;
            this.RmoveListBox.Text = "Remone the Selected Item";
            this.RmoveListBox.UseVisualStyleBackColor = true;
            this.RmoveListBox.Click += new System.EventHandler(this.RmoveListBox_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnAddListBox
            // 
            this.btnAddListBox.Location = new System.Drawing.Point(223, 24);
            this.btnAddListBox.Name = "btnAddListBox";
            this.btnAddListBox.Size = new System.Drawing.Size(102, 23);
            this.btnAddListBox.TabIndex = 4;
            this.btnAddListBox.Text = "Add to ListBox";
            this.btnAddListBox.UseVisualStyleBackColor = true;
            this.btnAddListBox.Click += new System.EventHandler(this.btnAddListBox_Click);
            // 
            // btnClearListBox
            // 
            this.btnClearListBox.Location = new System.Drawing.Point(61, 202);
            this.btnClearListBox.Name = "btnClearListBox";
            this.btnClearListBox.Size = new System.Drawing.Size(169, 23);
            this.btnClearListBox.TabIndex = 5;
            this.btnClearListBox.Text = "Remone all Item";
            this.btnClearListBox.UseVisualStyleBackColor = true;
            this.btnClearListBox.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnClearListBox);
            this.Controls.Add(this.btnAddListBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RmoveListBox);
            this.Controls.Add(this.LstBox1);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBox1;
        private System.Windows.Forms.Button RmoveListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddListBox;
        private System.Windows.Forms.Button btnClearListBox;
    }
}