using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using E_Divison.Classes;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace E_Divison.UserControls
{
    public sealed partial class PageActivityUserControl : UserControl
    {
        private int categoryID;
        private MainPage mainPage;
        public PageActivityUserControl(MainPage mainPage, int categoryID)
        {
            this.InitializeComponent();
            this.categoryID = categoryID;
            this.mainPage = mainPage;
            LoadCategory();
        }

        private void LoadCategory()
        {
            Category category = new Category();
            category.categoryID = categoryID;
            category.GetCategory();

            //if (categoryID == 1)
            //{
                //ImageManager imageManager = new ImageManager();
                //.Visibility = Visibility.Collapsed;
                //imageManager.SetImage(imgHome, category.categoryImage);
                //imgHome.Source = new BitMap(category.categoryImage);
            //}
        }
        
        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    mainPage.PageLoader(2);
        //}
    }
}
