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
