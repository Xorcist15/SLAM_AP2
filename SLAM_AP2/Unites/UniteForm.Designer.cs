namespace SLAM_AP2.Unites
{
    partial class UniteForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateFabBtn = new System.Windows.Forms.Button();
            this.FiltrerFabBtn = new System.Windows.Forms.Button();
            this.IdTxtBox = new System.Windows.Forms.TextBox();
            this.NomTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvUnites = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CtxMnStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifierSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnites)).BeginInit();
            this.CtxMnStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateFabBtn);
            this.groupBox1.Controls.Add(this.FiltrerFabBtn);
            this.groupBox1.Controls.Add(this.IdTxtBox);
            this.groupBox1.Controls.Add(this.NomTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DgvUnites);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 715);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CreateFabBtn
            // 
            this.CreateFabBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateFabBtn.Location = new System.Drawing.Point(699, 187);
            this.CreateFabBtn.Name = "CreateUnitBtn";
            this.CreateFabBtn.Size = new System.Drawing.Size(262, 39);
            this.CreateFabBtn.TabIndex = 22;
            this.CreateFabBtn.Text = "Nouvelle Unite";
            this.CreateFabBtn.UseVisualStyleBackColor = true;
            this.CreateFabBtn.Click += new System.EventHandler(this.CreateUnitBtn_Click);
            // 
            // FiltrerFabBtn
            // 
            this.FiltrerFabBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FiltrerFabBtn.Location = new System.Drawing.Point(106, 187);
            this.FiltrerFabBtn.Name = "FiltrerUnitBtn";
            this.FiltrerFabBtn.Size = new System.Drawing.Size(262, 39);
            this.FiltrerFabBtn.TabIndex = 21;
            this.FiltrerFabBtn.Text = "Filtrer Fabricant";
            this.FiltrerFabBtn.UseVisualStyleBackColor = true;
            this.FiltrerFabBtn.Click += new System.EventHandler(this.FiltrerUnitBtn_Click);
            // 
            // IdTxtBox
            // 
            this.IdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IdTxtBox.Location = new System.Drawing.Point(57, 84);
            this.IdTxtBox.Name = "IdTxtBox";
            this.IdTxtBox.Size = new System.Drawing.Size(110, 35);
            this.IdTxtBox.TabIndex = 17;
            // 
            // NomTxtBox
            // 
            this.NomTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NomTxtBox.Location = new System.Drawing.Point(57, 125);
            this.NomTxtBox.Name = "NomTxtBox";
            this.NomTxtBox.Size = new System.Drawing.Size(343, 35);
            this.NomTxtBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(406, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nom Fabricant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(164, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id Fabricant";
            // 
            // DgvUnites
            // 
            this.DgvUnites.AllowUserToResizeRows = false;
            this.DgvUnites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUnites.Location = new System.Drawing.Point(66, 350);
            this.DgvUnites.Name = "DgvUnites";
            this.DgvUnites.RowHeadersWidth = 62;
            this.DgvUnites.RowTemplate.Height = 28;
            this.DgvUnites.Size = new System.Drawing.Size(587, 150);
            this.DgvUnites.TabIndex = 2;
            this.DgvUnites.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvUnite_CellMouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(61, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les Categories";
            // 
            // CtxMnStrip
            // 
            this.CtxMnStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CtxMnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifierSTMItem,
            this.SupprimerSTMItem});
            this.CtxMnStrip.Name = "CtxMnStrip";
            this.CtxMnStrip.Size = new System.Drawing.Size(168, 68);
            // 
            // ModifierSTMItem
            // 
            this.ModifierSTMItem.Name = "ModifierSTMItem";
            this.ModifierSTMItem.Size = new System.Drawing.Size(167, 32);
            this.ModifierSTMItem.Text = "Modifier";
            this.ModifierSTMItem.Click += new System.EventHandler(this.ModifierSTMItem_Click);
            // 
            // SupprimerSTMItem
            // 
            this.SupprimerSTMItem.Name = "SupprimerSTMItem";
            this.SupprimerSTMItem.Size = new System.Drawing.Size(167, 32);
            this.SupprimerSTMItem.Text = "Supprimer";
            this.SupprimerSTMItem.Click += new System.EventHandler(this.SupprimerSTMItem_Click);
            // 
            // UniteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 738);
            this.Controls.Add(this.groupBox1);
            this.Name = "UniteForm";
            this.Text = "FabricantForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnites)).EndInit();
            this.CtxMnStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateFabBtn;
        private System.Windows.Forms.Button FiltrerFabBtn;
        private System.Windows.Forms.TextBox IdTxtBox;
        private System.Windows.Forms.TextBox NomTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvUnites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip CtxMnStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifierSTMItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerSTMItem;
    }
}