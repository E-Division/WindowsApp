using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace E_Divison.Classes
{
    public class ImageManager
    {
        private async void SetImage(byte[] image)
        {
            if (image != null)
            {
                BitmapImage imagemap = new BitmapImage();
                imagemap.SetSource(await ConvertTo(image));
                //img_ProductImage.Source = imagemap;
            }
        }

        private async Task<InMemoryRandomAccessStream> ConvertTo(byte[] arr)
        {
            InMemoryRandomAccessStream randomAccessStream = new InMemoryRandomAccessStream();
            await randomAccessStream.WriteAsync(arr.AsBuffer());
            randomAccessStream.Seek(0);
            return randomAccessStream;
        }
    }
}
