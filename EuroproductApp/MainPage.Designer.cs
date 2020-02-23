using MetroSet_UI.Controls;
using System.Windows.Forms;

namespace EuroproductApp
{
    partial class MainPage
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
            this.ProductsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProductsCatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RecipesCatPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BrowsePanel = new System.Windows.Forms.Panel();
            this.SearchBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.ProductsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsTab
            // 
            this.ProductsTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductsTab.Controls.Add(this.tabPage1);
            this.ProductsTab.Controls.Add(this.tabPage2);
            this.ProductsTab.Location = new System.Drawing.Point(15, 88);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.SelectedIndex = 0;
            this.ProductsTab.Size = new System.Drawing.Size(227, 590);
            this.ProductsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProductsCatPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(219, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProductsCatPanel
            // 
            this.ProductsCatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsCatPanel.Location = new System.Drawing.Point(3, 3);
            this.ProductsCatPanel.Name = "ProductsCatPanel";
            this.ProductsCatPanel.Size = new System.Drawing.Size(213, 551);
            this.ProductsCatPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RecipesCatPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(219, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recipes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RecipesCatPanel
            // 
            this.RecipesCatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecipesCatPanel.Location = new System.Drawing.Point(3, 3);
            this.RecipesCatPanel.Name = "RecipesCatPanel";
            this.RecipesCatPanel.Size = new System.Drawing.Size(213, 551);
            this.RecipesCatPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1166, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowsePanel
            // 
            this.BrowsePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowsePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BrowsePanel.Location = new System.Drawing.Point(248, 117);
            this.BrowsePanel.Name = "BrowsePanel";
            this.BrowsePanel.Size = new System.Drawing.Size(952, 557);
            this.BrowsePanel.TabIndex = 2;
            // 
            // SearchBox
            // 
            this.SearchBox.AutoCompleteCustomSource = null;
            this.SearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SearchBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SearchBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SearchBox.Image = null;
            this.SearchBox.Lines = null;
            this.SearchBox.Location = new System.Drawing.Point(248, 84);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.Multiline = false;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ReadOnly = false;
            this.SearchBox.Size = new System.Drawing.Size(866, 27);
            this.SearchBox.Style = MetroSet_UI.Design.Style.Light;
            this.SearchBox.StyleManager = null;
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBox.ThemeAuthor = "Narwin";
            this.SearchBox.ThemeName = "MetroLite";
            this.SearchBox.UseSystemPasswordChar = false;
            this.SearchBox.WatermarkText = "Search";
            this.SearchBox.Click += new System.EventHandler(this.SearchBox_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 708);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.BrowsePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductsTab);
            this.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "MainPage";
            this.SmallLineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SmallLineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Text = "EuroProduct";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ProductsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl ProductsTab;
        private Button button1;
        private Panel BrowsePanel;
        private MetroSetTextBox SearchBox;
        public FlowLayoutPanel ProductsCatPanel;
        private FlowLayoutPanel RecipesCatPanel;
    }
}

