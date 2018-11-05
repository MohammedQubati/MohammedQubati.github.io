namespace institute
{
    partial class Update_Stu
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
            this.txtStu_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYear = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtSex = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtstu_age = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtstuname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtLevl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textDep = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.FTN_Search = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(25, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(198, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Update Student  that Student_ID is";
            // 
            // txtStu_ID
            // 
            // 
            // 
            // 
            this.txtStu_ID.Border.Class = "TextBoxBorder";
            this.txtStu_ID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStu_ID.Location = new System.Drawing.Point(207, 30);
            this.txtStu_ID.Name = "txtStu_ID";
            this.txtStu_ID.Size = new System.Drawing.Size(86, 20);
            this.txtStu_ID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.txtstu_age);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.txtstuname);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.txtLevl);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.textDep);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(25, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtYear.Border.Class = "TextBoxBorder";
            this.txtYear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtYear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtYear.Location = new System.Drawing.Point(131, 194);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(182, 21);
            this.txtYear.TabIndex = 17;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelX4.Location = new System.Drawing.Point(40, 195);
            this.labelX4.Name = "labelX4";
            this.labelX4.SingleLineColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelX4.Size = new System.Drawing.Size(65, 20);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Years";
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtSex.Border.Class = "TextBoxBorder";
            this.txtSex.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSex.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSex.Location = new System.Drawing.Point(131, 158);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(182, 21);
            this.txtSex.TabIndex = 15;
            this.txtSex.TextChanged += new System.EventHandler(this.textBoxX3_TextChanged);
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelX9.Location = new System.Drawing.Point(40, 159);
            this.labelX9.Name = "labelX9";
            this.labelX9.SingleLineColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelX9.Size = new System.Drawing.Size(65, 20);
            this.labelX9.TabIndex = 14;
            this.labelX9.Text = "Stu_Sex";
            // 
            // txtstu_age
            // 
            this.txtstu_age.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtstu_age.Border.Class = "TextBoxBorder";
            this.txtstu_age.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtstu_age.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstu_age.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtstu_age.Location = new System.Drawing.Point(131, 122);
            this.txtstu_age.Name = "txtstu_age";
            this.txtstu_age.Size = new System.Drawing.Size(182, 21);
            this.txtstu_age.TabIndex = 23;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelX6.Location = new System.Drawing.Point(40, 123);
            this.labelX6.Name = "labelX6";
            this.labelX6.SingleLineColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelX6.Size = new System.Drawing.Size(65, 20);
            this.labelX6.TabIndex = 22;
            this.labelX6.Text = "Stu_Age";
            // 
            // txtstuname
            // 
            this.txtstuname.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtstuname.Border.Class = "TextBoxBorder";
            this.txtstuname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtstuname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstuname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtstuname.Location = new System.Drawing.Point(131, 86);
            this.txtstuname.Name = "txtstuname";
            this.txtstuname.Size = new System.Drawing.Size(182, 21);
            this.txtstuname.TabIndex = 21;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelX3.Location = new System.Drawing.Point(40, 86);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelX3.Size = new System.Drawing.Size(80, 20);
            this.labelX3.TabIndex = 20;
            this.labelX3.Text = "Stu_Name";
            // 
            // txtLevl
            // 
            this.txtLevl.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtLevl.Border.Class = "TextBoxBorder";
            this.txtLevl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLevl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLevl.Location = new System.Drawing.Point(131, 53);
            this.txtLevl.Name = "txtLevl";
            this.txtLevl.Size = new System.Drawing.Size(182, 21);
            this.txtLevl.TabIndex = 17;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelX2.Location = new System.Drawing.Point(40, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.SingleLineColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelX2.Size = new System.Drawing.Size(65, 20);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Level_ID";
            // 
            // textDep
            // 
            this.textDep.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.textDep.Border.Class = "TextBoxBorder";
            this.textDep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textDep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDep.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textDep.Location = new System.Drawing.Point(131, 19);
            this.textDep.Name = "textDep";
            this.textDep.Size = new System.Drawing.Size(182, 21);
            this.textDep.TabIndex = 15;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelX8.Location = new System.Drawing.Point(40, 19);
            this.labelX8.Name = "labelX8";
            this.labelX8.SingleLineColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelX8.Size = new System.Drawing.Size(65, 20);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "Dep_ID";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(302, 328);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Update";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonX2.Location = new System.Drawing.Point(218, 328);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "Cancel";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // FTN_Search
            // 
            this.FTN_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.FTN_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.FTN_Search.Location = new System.Drawing.Point(302, 29);
            this.FTN_Search.Name = "FTN_Search";
            this.FTN_Search.Size = new System.Drawing.Size(75, 23);
            this.FTN_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.FTN_Search.TabIndex = 5;
            this.FTN_Search.Text = "show";
            this.FTN_Search.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // Update_Stu
            // 
            this.AcceptButton = this.FTN_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonX2;
            this.ClientSize = new System.Drawing.Size(421, 357);
            this.Controls.Add(this.FTN_Search);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStu_ID);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Name = "Update_Stu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Stu";
            this.Load += new System.EventHandler(this.Update_Stu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStu_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtstu_age;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtstuname;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLevl;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textDep;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtYear;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSex;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX FTN_Search;
    }
}