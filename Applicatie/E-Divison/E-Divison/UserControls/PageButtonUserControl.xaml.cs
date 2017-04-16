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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace E_Divison.UserControls
{
    public sealed partial class PageButtonUserControl : UserControl
    {
        MainPage mainPage;
        int categoryID;
        public PageButtonUserControl(MainPage mainPage, string pageName, int categoryID)
        {
            this.InitializeComponent();
            txtPageName.Text = pageName;
            this.mainPage = mainPage;
            this.categoryID = categoryID;
        }

        private void buttonGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            mainPage.PageLoader(categoryID);
        }
    }
}
