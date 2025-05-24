using System.Windows.Forms;

namespace SLAM_AP2
{
    partial class MainMenu
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
            this.GbArticles = new System.Windows.Forms.GroupBox();
            this.FiltrerBtn = new System.Windows.Forms.Button();
            this.LibTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbUnite = new System.Windows.Forms.ComboBox();
            this.BtnCreateArticle = new System.Windows.Forms.Button();
            this.DgvArticles = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbFabricant = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbCategorie = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifierTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerTSMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ArticlesSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FabSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepotsSTMIem = new System.Windows.Forms.ToolStripMenuItem();
            this.MvtSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StockSTMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbDepots = new System.Windows.Forms.GroupBox();
            this.GbArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticles)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbArticles
            // 
            this.GbArticles.Controls.Add(this.FiltrerBtn);
            this.GbArticles.Controls.Add(this.LibTxtBox);
            this.GbArticles.Controls.Add(this.label3);
            this.GbArticles.Controls.Add(this.CbUnite);
            this.GbArticles.Controls.Add(this.BtnCreateArticle);
            this.GbArticles.Controls.Add(this.DgvArticles);
            this.GbArticles.Controls.Add(this.label5);
            this.GbArticles.Controls.Add(this.label4);
            this.GbArticles.Controls.Add(this.CbFabricant);
            this.GbArticles.Controls.Add(this.label2);
            this.GbArticles.Controls.Add(this.label1);
            this.GbArticles.Controls.Add(this.CbCategorie);
            this.GbArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbArticles.Location = new System.Drawing.Point(12, 52);
            this.GbArticles.Name = "GbArticles";
            this.GbArticles.Size = new System.Drawing.Size(1431, 605);
            this.GbArticles.TabIndex = 1;
            this.GbArticles.TabStop = false;
            this.GbArticles.Text = "Menu Principale";
            this.GbArticles.UseCompatibleTextRendering = true;
            // 
            // FiltrerBtn
            // 
            this.FiltrerBtn.Location = new System.Drawing.Point(788, 68);
            this.FiltrerBtn.Name = "FiltrerBtn";
            this.FiltrerBtn.Size = new System.Drawing.Size(230, 41);
            this.FiltrerBtn.TabIndex = 14;
            this.FiltrerBtn.Text = "Filtrer";
            this.FiltrerBtn.UseVisualStyleBackColor = true;
            this.FiltrerBtn.Click += new System.EventHandler(this.FiltrerBtn_Click);
            // 
            // LibTxtBox
            // 
            this.LibTxtBox.Location = new System.Drawing.Point(146, 71);
            this.LibTxtBox.Name = "LibTxtBox";
            this.LibTxtBox.Size = new System.Drawing.Size(478, 35);
            this.LibTxtBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "unite";
            // 
            // CbUnite
            // 
            this.CbUnite.FormattingEnabled = true;
            this.CbUnite.Location = new System.Drawing.Point(146, 199);
            this.CbUnite.Name = "CbUnite";
            this.CbUnite.Size = new System.Drawing.Size(478, 37);
            this.CbUnite.TabIndex = 11;
            // 
            // BtnCreateArticle
            // 
            this.BtnCreateArticle.Location = new System.Drawing.Point(1083, 68);
            this.BtnCreateArticle.Name = "BtnCreateArticle";
            this.BtnCreateArticle.Size = new System.Drawing.Size(230, 41);
            this.BtnCreateArticle.TabIndex = 10;
            this.BtnCreateArticle.Text = "Nouvel article";
            this.BtnCreateArticle.UseVisualStyleBackColor = true;
            this.BtnCreateArticle.Click += new System.EventHandler(this.BtnCreateArticle_Click);
            // 
            // DgvArticles
            // 
            this.DgvArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticles.Location = new System.Drawing.Point(37, 272);
            this.DgvArticles.Name = "DgvArticles";
            this.DgvArticles.RowHeadersWidth = 62;
            this.DgvArticles.RowTemplate.Height = 28;
            this.DgvArticles.Size = new System.Drawing.Size(1350, 294);
            this.DgvArticles.TabIndex = 9;
            this.DgvArticles.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvArticles_CellMouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "libelle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "fabricant";
            // 
            // CbFabricant
            // 
            this.CbFabricant.FormattingEnabled = true;
            this.CbFabricant.Location = new System.Drawing.Point(146, 156);
            this.CbFabricant.Name = "CbFabricant";
            this.CbFabricant.Size = new System.Drawing.Size(478, 37);
            this.CbFabricant.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "categorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtres";
            // 
            // CbCategorie
            // 
            this.CbCategorie.FormattingEnabled = true;
            this.CbCategorie.Location = new System.Drawing.Point(146, 112);
            this.CbCategorie.Name = "CbCategorie";
            this.CbCategorie.Size = new System.Drawing.Size(478, 37);
            this.CbCategorie.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifierTSMItem,
            this.SupprimerTSMItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 68);
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
            // MainMenuStrip
            // 
            this.MainMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticlesSTMItem,
            this.DepotsSTMIem,
            this.MvtSTMItem,
            this.StockSTMItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1455, 40);
            this.MainMenuStrip.TabIndex = 2;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // ArticlesSTMItem
            // 
            this.ArticlesSTMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CatSTMItem,
            this.FabSTMItem,
            this.UnitSTMItem});
            this.ArticlesSTMItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ArticlesSTMItem.Name = "ArticlesSTMItem";
            this.ArticlesSTMItem.Size = new System.Drawing.Size(107, 36);
            this.ArticlesSTMItem.Text = "Articles";
            this.ArticlesSTMItem.Click += new System.EventHandler(this.ArticlesSTMItem_Click);
            // 
            // CatSTMItem
            // 
            this.CatSTMItem.Name = "CatSTMItem";
            this.CatSTMItem.Size = new System.Drawing.Size(270, 40);
            this.CatSTMItem.Text = "Categories";
            this.CatSTMItem.Click += new System.EventHandler(this.CatSTMItem_Click);
            // 
            // FabSTMItem
            // 
            this.FabSTMItem.Name = "FabSTMItem";
            this.FabSTMItem.Size = new System.Drawing.Size(270, 40);
            this.FabSTMItem.Text = "Fabricants";
            this.FabSTMItem.Click += new System.EventHandler(this.FabSTMItem_Click);
            // 
            // UnitSTMItem
            // 
            this.UnitSTMItem.Name = "UnitSTMItem";
            this.UnitSTMItem.Size = new System.Drawing.Size(270, 40);
            this.UnitSTMItem.Text = "Unites";
            this.UnitSTMItem.Click += new System.EventHandler(this.UnitSTMItem_Click);
            // 
            // DepotsSTMIem
            // 
            this.DepotsSTMIem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DepotsSTMIem.Name = "DepotsSTMIem";
            this.DepotsSTMIem.Size = new System.Drawing.Size(106, 36);
            this.DepotsSTMIem.Text = "Depots";
            this.DepotsSTMIem.Click += new System.EventHandler(this.DepotsSTMIem_Click);
            // 
            // MvtSTMItem
            // 
            this.MvtSTMItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MvtSTMItem.Name = "MvtSTMItem";
            this.MvtSTMItem.Size = new System.Drawing.Size(72, 36);
            this.MvtSTMItem.Text = "Mvt";
            // 
            // StockSTMItem
            // 
            this.StockSTMItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StockSTMItem.Name = "StockSTMItem";
            this.StockSTMItem.Size = new System.Drawing.Size(87, 36);
            this.StockSTMItem.Text = "Stock";
            // 
            // GbDepots
            // 
            this.GbDepots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GbDepots.Location = new System.Drawing.Point(12, 646);
            this.GbDepots.Name = "GbDepots";
            this.GbDepots.Size = new System.Drawing.Size(1425, 605);
            this.GbDepots.TabIndex = 3;
            this.GbDepots.TabStop = false;
            this.GbDepots.Text = "Depots";
            this.GbDepots.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 736);
            this.Controls.Add(this.GbDepots);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.GbArticles);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.GbArticles.ResumeLayout(false);
            this.GbArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticles)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbArticles;
        private System.Windows.Forms.ComboBox CbCategorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbFabricant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvArticles;
        private System.Windows.Forms.Button BtnCreateArticle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbUnite;
        private System.Windows.Forms.TextBox LibTxtBox;
        private System.Windows.Forms.Button FiltrerBtn;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem ModifierTSMItem;
        private ToolStripMenuItem SupprimerTSMItem;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem ArticlesSTMItem;
        private ToolStripMenuItem DepotsSTMIem;
        private ToolStripMenuItem MvtSTMItem;
        private ToolStripMenuItem CatSTMItem;
        private ToolStripMenuItem FabSTMItem;
        private ToolStripMenuItem UnitSTMItem;
        private ToolStripMenuItem StockSTMItem;
        private GroupBox GbDepots;
    }
}