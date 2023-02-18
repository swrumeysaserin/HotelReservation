using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Otel.Business.ExtensionMethods
{
    public static class ConvertExtensionMethods
    {
        public static int ToInt32(this object o)
        {
            return Convert.ToInt32(o);
        }
        public static byte[] ToByte(this Image image)
        {
            //using tab tab
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static Image ToImage(this byte[] imageData)
        {
            using (var ms = new MemoryStream(imageData))
            {
                var image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
