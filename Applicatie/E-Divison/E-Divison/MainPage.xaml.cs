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
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace E_Divison
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            this.InitializeComponent();
            int categoryID = 1;
            PageLoader(categoryID);
            //DatabaseManager dM = new DatabaseManager();
            //Classes.Page page = new Classes.Page();
            //page.GetPages(dM.GetCon());
            //SetImage(page.pageImage);

        }

        public void PageLoader(int categoryID)
        {
            spHeader.Children.Clear();
            spContent.Children.Clear();
            UserControls.PageHeaderUserControl pageHeader = new UserControls.PageHeaderUserControl(this, categoryID);

            spHeader.Children.Add(pageHeader);

            UserControls.PageActivityUserControl pageActivity = new UserControls.PageActivityUserControl(this, categoryID);
            
            spContent.Children.Add(pageActivity);

        }
      
    }
}
