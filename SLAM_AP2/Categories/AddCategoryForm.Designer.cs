namespace SLAM_AP2
{
    partial class AddCategoryForm
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
            this.CreateCategory = new System.Windows.Forms.Button();
            this.LibTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodeTxtBox);
            this.groupBox1.Controls.Add(this.CreateCategory);
            this.groupBox1.Controls.Add(this.LibTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CodeTxtBox
            // 
            this.CodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodeTxtBox.Location = new System.Drawing.Point(136, 85);
            this.CodeTxtBox.Name = "CodeTxtBox";
            this.CodeTxtBox.Size = new System.Drawing.Size(110, 35);
            this.CodeTxtBox.TabIndex = 13;
            // 
            // CreateCategory
            // 
            this.CreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateCategory.Location = new System.Drawing.Point(136, 179);
            this.CreateCategory.Name = "CreateCategory";
            this.CreateCategory.Size = new System.Drawing.Size(245, 43);
            this.CreateCategory.TabIndex = 17;
            this.CreateCategory.Text = "Ajouter Categorie";
            this.CreateCategory.UseVisualStyleBackColor = true;
            this.CreateCategory.Click += new System.EventHandler(this.CreateCategory_Click);
            // 
            // LibTxtBox
            // 
            this.LibTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LibTxtBox.Location = new System.Drawing.Point(127, 129);
            this.LibTxtBox.Name = "LibTxtBox";
            this.LibTxtBox.Size = new System.Drawing.Size(343, 35);
            this.LibTxtBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(476, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(243, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Code";
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCategoryForm";
            this.Text = "AddCategorieForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CodeTxtBox;
        private System.Windows.Forms.Button CreateCategory;
        private System.Windows.Forms.TextBox LibTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}