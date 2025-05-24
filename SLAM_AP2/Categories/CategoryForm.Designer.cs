namespace SLAM_AP2
{
    partial class CategoryForm
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
            this.DgvCategories = new System.Windows.Forms.DataGridView();
            this.CtxMnStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifierTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FiltrerCatBtn = new System.Windows.Forms.Button();
            this.CodeTxtBox = new System.Windows.Forms.TextBox();
            this.LibTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).BeginInit();
            this.CtxMnStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // DgvCategories
            // 
            this.DgvCategories.AllowUserToResizeRows = false;
            this.DgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategories.Location = new System.Drawing.Point(66, 350);
            this.DgvCategories.Name = "DgvCategories";
            this.DgvCategories.RowHeadersWidth = 62;
            this.DgvCategories.RowTemplate.Height = 28;
            this.DgvCategories.Size = new System.Drawing.Size(587, 150);
            this.DgvCategories.TabIndex = 2;
            this.DgvCategories.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCategories_CellMouseDown);
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
            this.groupBox1.Controls.Add(this.CreateCategory);
            this.groupBox1.Controls.Add(this.FiltrerCatBtn);
            this.groupBox1.Controls.Add(this.CodeTxtBox);
            this.groupBox1.Controls.Add(this.LibTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DgvCategories);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 715);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FiltrerCatBtn
            // 
            this.FiltrerCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FiltrerCatBtn.Location = new System.Drawing.Point(106, 187);
            this.FiltrerCatBtn.Name = "FiltrerCatBtn";
            this.FiltrerCatBtn.Size = new System.Drawing.Size(262, 39);
            this.FiltrerCatBtn.TabIndex = 21;
            this.FiltrerCatBtn.Text = "Filtrer Categories";
            this.FiltrerCatBtn.UseVisualStyleBackColor = true;
            this.FiltrerCatBtn.Click += new System.EventHandler(this.FiltrerCatBtn_Click);
            // 
            // CodeTxtBox
            // 
            this.CodeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CodeTxtBox.Location = new System.Drawing.Point(57, 84);
            this.CodeTxtBox.Name = "CodeTxtBox";
            this.CodeTxtBox.Size = new System.Drawing.Size(110, 35);
            this.CodeTxtBox.TabIndex = 17;
            // 
            // LibTxtBox
            // 
            this.LibTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LibTxtBox.Location = new System.Drawing.Point(57, 125);
            this.LibTxtBox.Name = "LibTxtBox";
            this.LibTxtBox.Size = new System.Drawing.Size(343, 35);
            this.LibTxtBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(406, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(164, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Code";
            // 
            // CreateCategory
            // 
            this.CreateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateCategory.Location = new System.Drawing.Point(699, 187);
            this.CreateCategory.Name = "CreateCategory";
            this.CreateCategory.Size = new System.Drawing.Size(262, 39);
            this.CreateCategory.TabIndex = 22;
            this.CreateCategory.Text = "Nouvelle Categorie";
            this.CreateCategory.UseVisualStyleBackColor = true;
            this.CreateCategory.Click += new System.EventHandler(this.CreateCategory_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 768);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryForm";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategories)).EndInit();
            this.CtxMnStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCategories;
        private System.Windows.Forms.ContextMenuStrip CtxMnStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifierTSMItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerTSMItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FiltrerCatBtn;
        private System.Windows.Forms.TextBox CodeTxtBox;
        private System.Windows.Forms.TextBox LibTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateCategory;
    }
}