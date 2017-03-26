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
            //DatabaseManager dM = new DatabaseManager();
            //Classes.Page page = new Classes.Page();
            //page.GetPages(dM.GetCon());
            //SetImage(page.pageImage);

        }

        private async void SetImage(byte[] image)
        {
            if (image != null)
            {
                BitmapImage imagemap = new BitmapImage();
                imagemap.SetSource(await ConvertTo(image));
                imgDivision.Source = imagemap;
            }
        }

        private async Task<InMemoryRandomAccessStream> ConvertTo(byte[] arr)
        {
            InMemoryRandomAccessStream randomAccessStream = new InMemoryRandomAccessStream();
            await randomAccessStream.WriteAsync(arr.AsBuffer());
            randomAccessStream.Seek(0);
            return randomAccessStream;
        }

        private void BtnAutomotive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPrivate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBusiness_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ImgEdivisionHeader_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
