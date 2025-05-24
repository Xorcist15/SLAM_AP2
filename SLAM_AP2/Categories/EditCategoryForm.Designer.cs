namespace SLAM_AP2.Categories
{
    partial class EditCategoryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CodeTxtBox = new System.Windows.Forms.TextBox();
            this.LibTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModifierCatBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifierCatBtn);
            this.groupBox1.Controls.Add(this.CodeTxtBox);
            this.groupBox1.Controls.Add(this.LibTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CodeTxtBox
            // 
            this.CodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodeTxtBox.Location = new System.Drawing.Point(6, 52);
            this.CodeTxtBox.Name = "CodeTxtBox";
            this.CodeTxtBox.Size = new System.Drawing.Size(110, 35);
            this.CodeTxtBox.TabIndex = 21;
            // 
            // LibTxtBox
            // 
            this.LibTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LibTxtBox.Location = new System.Drawing.Point(6, 93);
            this.LibTxtBox.Name = "LibTxtBox";
            this.LibTxtBox.Size = new System.Drawing.Size(343, 35);
            this.LibTxtBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(355, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(113, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Code";
            // 
            // ModifierCatBtn
            // 
            this.ModifierCatBtn.Location = new System.Drawing.Point(134, 196);
            this.ModifierCatBtn.Name = "ModifierCatBtn";
            this.ModifierCatBtn.Size = new System.Drawing.Size(215, 50);
            this.ModifierCatBtn.TabIndex = 25;
            this.ModifierCatBtn.Text = "Modifier Category";
            this.ModifierCatBtn.UseVisualStyleBackColor = true;
            this.ModifierCatBtn.Click += new System.EventHandler(this.ModifierCatBtn_Click);
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 326);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditCategoryForm";
            this.Text = "EditCategoryForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ModifierCatBtn;
        private System.Windows.Forms.TextBox CodeTxtBox;
        private System.Windows.Forms.TextBox LibTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}