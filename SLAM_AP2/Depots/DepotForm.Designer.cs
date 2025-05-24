namespace SLAM_AP2
{
    partial class DepotForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvDepots = new System.Windows.Forms.DataGridView();
            this.CtxMnStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifierTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaysCmBox = new System.Windows.Forms.ComboBox();
            this.VilleCmBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumTxtBox = new System.Windows.Forms.TextBox();
            this.CreateDepot = new System.Windows.Forms.Button();
            this.NomTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepots)).BeginInit();
            this.CtxMnStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les Categories";
            // 
            // DgvDepots
            // 
            this.DgvDepots.AllowUserToResizeRows = false;
            this.DgvDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepots.Location = new System.Drawing.Point(27, 295);
            this.DgvDepots.Name = "DgvDepots";
            this.DgvDepots.RowHeadersWidth = 62;
            this.DgvDepots.RowTemplate.Height = 28;
            this.DgvDepots.Size = new System.Drawing.Size(1030, 251);
            this.DgvDepots.TabIndex = 2;
            this.DgvDepots.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCategories_CellMouseDown);
            // 
            // CtxMnStrip
            // 
            this.CtxMnStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CtxMnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifierTSMItem,
            this.SupprimerTSMItem});
            this.CtxMnStrip.Name = "CtxMnStrip";
            this.CtxMnStrip.Size = new System.Drawing.Size(168, 68);
            // 
            // ModifierTSMItem
            // 
            this.ModifierTSMItem.Name = "ModifierTSMItem";
            this.ModifierTSMItem.Size = new System.Drawing.Size(167, 32);
            this.ModifierTSMItem.Text = "Modifier";
            this.ModifierTSMItem.Click += new System.EventHandler(this.ModifierTSMItem_Click);
            // 
            // SupprimerTSMItem
            // 
            this.SupprimerTSMItem.Name = "SupprimerTSMItem";
            this.SupprimerTSMItem.Size = new System.Drawing.Size(167, 32);
            this.SupprimerTSMItem.Text = "Supprimer";
            this.SupprimerTSMItem.Click += new System.EventHandler(this.SupprimerTSMItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaysCmBox);
            this.groupBox1.Controls.Add(this.VilleCmBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NumTxtBox);
            this.groupBox1.Controls.Add(this.CreateDepot);
            this.groupBox1.Controls.Add(this.NomTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DgvDepots);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 590);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PaysCmBox
            // 
            this.PaysCmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PaysCmBox.FormattingEnabled = true;
            this.PaysCmBox.Location = new System.Drawing.Point(27, 193);
            this.PaysCmBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaysCmBox.Name = "PaysCmBox";
            this.PaysCmBox.Size = new System.Drawing.Size(343, 37);
            this.PaysCmBox.TabIndex = 44;
            // 
            // VilleCmBox
            // 
            this.VilleCmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VilleCmBox.FormattingEnabled = true;
            this.VilleCmBox.Location = new System.Drawing.Point(27, 140);
            this.VilleCmBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VilleCmBox.Name = "VilleCmBox";
            this.VilleCmBox.Size = new System.Drawing.Size(343, 37);
            this.VilleCmBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(375, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 29);
            this.label7.TabIndex = 42;
            this.label7.Text = "Pays";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(375, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ville";
            // 
            // NumTxtBox
            // 
            this.NumTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NumTxtBox.Location = new System.Drawing.Point(27, 53);
            this.NumTxtBox.Name = "NumTxtBox";
            this.NumTxtBox.Size = new System.Drawing.Size(343, 35);
            this.NumTxtBox.TabIndex = 30;
            // 
            // CreateDepot
            // 
            this.CreateDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateDepot.Location = new System.Drawing.Point(528, 62);
            this.CreateDepot.Name = "CreateDepot";
            this.CreateDepot.Size = new System.Drawing.Size(244, 43);
            this.CreateDepot.TabIndex = 34;
            this.CreateDepot.Text = "Ajouter Categorie";
            this.CreateDepot.UseVisualStyleBackColor = true;
            this.CreateDepot.Click += new System.EventHandler(this.CreateDepot_Click);
            // 
            // NomTxtBox
            // 
            this.NomTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NomTxtBox.Location = new System.Drawing.Point(27, 97);
            this.NomTxtBox.Name = "NomTxtBox";
            this.NomTxtBox.Size = new System.Drawing.Size(343, 35);
            this.NomTxtBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(375, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(377, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Numero";
            // 
            // DepotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 665);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepotForm";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepots)).EndInit();
            this.CtxMnStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDepots;
        private System.Windows.Forms.ContextMenuStrip CtxMnStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifierTSMItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerTSMItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PaysCmBox;
        private System.Windows.Forms.ComboBox VilleCmBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumTxtBox;
        private System.Windows.Forms.Button CreateDepot;
        private System.Windows.Forms.TextBox NomTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}