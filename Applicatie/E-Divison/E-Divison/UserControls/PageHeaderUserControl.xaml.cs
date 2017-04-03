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
using Windows.UI.Xaml.Media.Imaging;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace E_Divison.UserControls
{
    public sealed partial class PageHeaderUserControl : UserControl
    {
        private int categoryID;
        private MainPage mainPage;
        public PageHeaderUserControl(MainPage mainPage, int categoryID)
        {
            this.InitializeComponent();
            this.categoryID = categoryID;
            this.mainPage = mainPage;
            LoadCategory();
        }

        private void LoadCategory()
        {

            if (categoryID == 1)
            {
                imgBack.Visibility = Visibility.Collapsed;
                imgHome.Source = new BitmapImage(new Uri("ms-appx:///Assets/Image636228400665325432.jpg"));
                imgHome.Width = 200;
                //imgHome.Source = new BitmapImage(new Uri("/MyProject;Assets/Image636228400664674921.jpg", UriKind.Relative));
            }
            else
            {
                //click event kk homo
            }
        }


    }
}
