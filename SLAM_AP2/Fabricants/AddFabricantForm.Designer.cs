namespace SLAM_AP2.Fabricants
{
    partial class AddFabricantForm
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
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.CreateFabricant = new System.Windows.Forms.Button();
            this.NomTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdTxtBox);
            this.groupBox1.Controls.Add(this.CreateFabricant);
            this.groupBox1.Controls.Add(this.NomTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(56, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IdTxtBox.Location = new System.Drawing.Point(136, 85);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(110, 35);
            this.IdTxtBox.TabIndex = 13;
            // 
            // CreateFabricant
            // 
            this.CreateFabricant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateFabricant.Location = new System.Drawing.Point(136, 179);
            this.CreateFabricant.Name = "CreateFabricant";
            this.CreateFabricant.Size = new System.Drawing.Size(245, 43);
            this.CreateFabricant.TabIndex = 17;
            this.CreateFabricant.Text = "Ajouter Categorie";
            this.CreateFabricant.UseVisualStyleBackColor = true;
            this.CreateFabricant.Click += new System.EventHandler(this.CreateFabricant_Click);
            // 
            // NomTxtBox
            // 
            this.NomTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NomTxtBox.Location = new System.Drawing.Point(127, 129);
            this.NomTxtBox.Name = "NomTxtBox";
            this.NomTxtBox.Size = new System.Drawing.Size(343, 35);
            this.NomTxtBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(476, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nom fabricant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(243, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id fabricant";
            // 
            // AddFabricantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddFabricantForm";
            this.Text = "AddFabricantForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.Button CreateFabricant;
        private System.Windows.Forms.TextBox NomTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}