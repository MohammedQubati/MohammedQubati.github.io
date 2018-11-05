namespace institute
{
    partial class Delet_Student
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtDel_Stu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(51, 46);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Enter Student_ID";
            // 
            // txtDel_Stu
            // 
            // 
            // 
            // 
            this.txtDel_Stu.Border.Class = "TextBoxBorder";
            this.txtDel_Stu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDel_Stu.Location = new System.Drawing.Point(153, 47);
            this.txtDel_Stu.Name = "txtDel_Stu";
            this.txtDel_Stu.Size = new System.Drawing.Size(194, 20);
            this.txtDel_Stu.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(374, 46);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "Delete";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Delet_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 124);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtDel_Stu);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "Delet_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delet_Student";
            this.Load += new System.EventHandler(this.Delet_Student_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDel_Stu;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}