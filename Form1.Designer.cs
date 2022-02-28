namespace The_Color_Problem
{
    partial class Form1
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
            this.Add_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Color_1_TB = new System.Windows.Forms.TextBox();
            this.Color_2_TB = new System.Windows.Forms.TextBox();
            this.Color_3_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Select_Instructions_LBL = new System.Windows.Forms.Label();
            this.Colors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F);
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Colors of Your Favourites!";
            // 
            // Add_BTN
            // 
            this.Add_BTN.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_BTN.Location = new System.Drawing.Point(350, 224);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(75, 30);
            this.Add_BTN.TabIndex = 1;
            this.Add_BTN.Text = "Add";
            this.Add_BTN.UseVisualStyleBackColor = true;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(263, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color one:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color two:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color three:";
            // 
            // Color_1_TB
            // 
            this.Color_1_TB.Location = new System.Drawing.Point(414, 109);
            this.Color_1_TB.Name = "Color_1_TB";
            this.Color_1_TB.Size = new System.Drawing.Size(100, 20);
            this.Color_1_TB.TabIndex = 5;
            // 
            // Color_2_TB
            // 
            this.Color_2_TB.Location = new System.Drawing.Point(414, 150);
            this.Color_2_TB.Name = "Color_2_TB";
            this.Color_2_TB.Size = new System.Drawing.Size(100, 20);
            this.Color_2_TB.TabIndex = 6;
            // 
            // Color_3_TB
            // 
            this.Color_3_TB.Location = new System.Drawing.Point(414, 189);
            this.Color_3_TB.Name = "Color_3_TB";
            this.Color_3_TB.Size = new System.Drawing.Size(100, 20);
            this.Color_3_TB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 18.25F);
            this.label5.Location = new System.Drawing.Point(229, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter three colors of your choice below:";
            // 
            // Select_Instructions_LBL
            // 
            this.Select_Instructions_LBL.AutoSize = true;
            this.Select_Instructions_LBL.Font = new System.Drawing.Font("Mistral", 18.25F);
            this.Select_Instructions_LBL.Location = new System.Drawing.Point(233, 267);
            this.Select_Instructions_LBL.Name = "Select_Instructions_LBL";
            this.Select_Instructions_LBL.Size = new System.Drawing.Size(321, 30);
            this.Select_Instructions_LBL.TabIndex = 10;
            this.Select_Instructions_LBL.Text = "Now, select your favourite color below:";
            // 
            // Colors
            // 
            this.Colors.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colors.FormattingEnabled = true;
            this.Colors.ItemHeight = 25;
            this.Colors.Location = new System.Drawing.Point(267, 325);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(247, 79);
            this.Colors.TabIndex = 11;
            this.Colors.SelectedIndexChanged += new System.EventHandler(this.Colors_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.Select_Instructions_LBL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Color_3_TB);
            this.Controls.Add(this.Color_2_TB);
            this.Controls.Add(this.Color_1_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Color_1_TB;
        private System.Windows.Forms.TextBox Color_2_TB;
        private System.Windows.Forms.TextBox Color_3_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Select_Instructions_LBL;
        private System.Windows.Forms.ListBox Colors;
    }
}

