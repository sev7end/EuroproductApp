using MetroSet_UI.Forms;
using MetroSet_UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuroproductsPCL.Services;
using EuroproductsPCL.Models;

namespace EuroproductApp
{
    public partial class MainPage : MetroSetForm
    {
       
        private CategoryServices service;
        private List<PictureBox> images = new List<PictureBox>();



        public MainPage()
        {
            InitializeComponent();
            service = new CategoryServices();

        }
        public void ShowCategory(object id)
        {
            BrowsePanel.Controls.Clear();
            //BrowsePanel.Controls.Add();
        }
        public void CreateCategories()
        {
            try
            {
                foreach (var item in AppStart.Instance.recipesCategories)
                {
                    var Butt = new Button()
                    {
                        Size = new Size(180, 43),
                        Text = item.Name,
                        Name = item.Id + "Button",
                        Tag = item.Id,
                    };
                    Butt.Click += (s, e) => MessageBox.Show(Butt.Tag.ToString());//ShowCategory(Butt.Tag);
                    RecipesCatPanel.Controls.Add(Butt);
                }

                foreach (var item in AppStart.Instance.productsCategories)
                {
                    var Butt = new Button()
                    {
                        Size = new Size(180, 43),
                        Text = item.Name,
                        Name = item.Id + "Button",
                        Tag = item.Id,
                    };
                    Butt.Click += (s, e) => MessageBox.Show(Butt.Tag.ToString());//ShowCategory(Butt.Tag);
                    ProductsCatPanel.Controls.Add(Butt);
                }
                ProductsCatPanel.AutoScroll = true;
                RecipesCatPanel.AutoScroll = true;
                RecipesCatPanel.Refresh();
                ProductsCatPanel.Refresh();
            }
            catch (Exception ex)
            {
            }
        }

        public void CreateContainerForProducts(List<Product> products)
        {
            Point picturePoint = new Point(3, -147);
            Point productNamePoint = new Point(162, -147);
            Point productDescPoint = new Point(162, -124);
            Point ButtonPoint = new Point(835, -50);
            BrowsePanel.Controls.Clear();
            foreach(var item in products)
            {
                picturePoint = new Point(3, picturePoint.Y + 150);
                productNamePoint = new Point(productNamePoint.X, productNamePoint.Y + 150);
                productDescPoint = new Point(productDescPoint.X, productDescPoint.Y + 150);
                ButtonPoint = new Point(ButtonPoint.X, ButtonPoint.Y + 150);

                PictureBox picture = new PictureBox();
                MetroSetLabel productName = new MetroSetLabel();
                MetroSetLabel productDesc = new MetroSetLabel();
                MetroSetButton viewButton = new MetroSetButton();

                picture.Location = picturePoint;
                picture.Name = item.Name;
                picture.Size = new System.Drawing.Size(153, 144);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.TabIndex = 0;
                picture.ImageLocation = item.MainImageUrl;
                picture.TabStop = false;

                productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                productName.Location = productNamePoint;
                productName.Size = new System.Drawing.Size(100, 23);
                productName.Style = MetroSet_UI.Design.Style.Light;
                productName.StyleManager = null;
                productName.Text = item.Name;
                productName.ThemeAuthor = "Narwin";
                productName.ThemeName = "MetroLite";

                productDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                productDesc.Location = productDescPoint;
                productDesc.Size = new System.Drawing.Size(100, 23);
                productDesc.Style = MetroSet_UI.Design.Style.Light;
                productDesc.StyleManager = null;
                productDesc.Text = item.ShortDescription;
                productDesc.ThemeAuthor = "Narwin";
                productDesc.ThemeName = "MetroLite";

                viewButton.DisabledBackColor = Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
                viewButton.DisabledBorderColor = Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
                viewButton.DisabledForeColor = Color.Gray;
                viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                viewButton.HoverBorderColor = Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
                viewButton.HoverColor = Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
                viewButton.HoverTextColor = Color.White;
                viewButton.Location = ButtonPoint;
                viewButton.Name = "metroSetButton1";
                viewButton.NormalBorderColor = Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
                viewButton.NormalColor = Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
                viewButton.NormalTextColor = Color.White;
                viewButton.PressBorderColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
                viewButton.PressColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
                viewButton.PressTextColor = Color.White;
                viewButton.Size = new System.Drawing.Size(110, 47);
                viewButton.Style = MetroSet_UI.Design.Style.Light;
                viewButton.StyleManager = null;
                viewButton.TabIndex = 4;
                viewButton.Text = "View";
                viewButton.ThemeAuthor = "Narwin";
                viewButton.ThemeName = "MetroLite";

                BrowsePanel.Controls.Add(picture);
                BrowsePanel.Controls.Add(productName);
                BrowsePanel.Controls.Add(productDesc);
                BrowsePanel.Controls.Add(viewButton);
            }
            BrowsePanel.AutoScroll = true;
            BrowsePanel.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {

        }
    }
}
