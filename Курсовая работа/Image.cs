using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Курсовая_работа
{
    class Image
    {

        protected static Bitmap image;

        public static void Init(Bitmap Image)
        {
            image = Image;
        }

        public static Bitmap Get_Image()
        {
            return image;
        }

        public static int Get_Widht()
        {
            return image.Width;
        }

        public static int Get_Height()
        {
            return image.Height;
        }

        //получение пикселей
        public static byte[] GetArrayPixel()
        {
            int height, widht;
            height = image.Height;
            widht = image.Width;
            byte[] res = new byte[widht * height];

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < widht; y++)
                {
                    Color color = image.GetPixel(y, x);

                    if (color.R == 0 && color.G == 0 && color.B == 0)
                        res[x*widht + y] = 1;
                    else
                        res[x * widht + y] = 0;

                }
            }
            return res;
        }


}
}
