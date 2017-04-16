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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace E_Divison.UserControls
{
    public sealed partial class PageActivityMenuUserControl : UserControl
    {
        private int categoryID;
        private MainPage mainPage;
        public PageActivityMenuUserControl(MainPage mainPage,int categoryID)
        {
            this.InitializeComponent();
            this.categoryID = categoryID;
            this.mainPage = mainPage;
            LoadMenu();
        }

        public void LoadMenu()
        {
            Category category = new Category();
            category.categoryID = categoryID;
            List<Category> categoryMenuList = category.GetSubCategories();
            foreach (Category categoryItem in categoryMenuList)
            {
               
               PageButtonUserControl pageButton = new PageButtonUserControl(mainPage,categoryItem.categoryName, categoryItem.categoryID);
                if(spMenuFirst.Children.Count() < 3)
                {
                    spMenuFirst.Children.Add(pageButton);
                }
                else if(spMenuSecond.Children.Count() < 3)
                {

                }
                else if(spMenuThirth.Children.Count() < 3)
                {

                }
            }
        }
    }
}
