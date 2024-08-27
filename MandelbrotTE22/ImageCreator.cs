using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandelbrotTE22
{
    //Klass för att skapa bilder.
    class ImageCreator
    {
        private int width;
        private int height;

        //I konstruktorn sätts storleken på bilden som ska skapas.
        public ImageCreator(int imageWidth, int imageHeight)
        {
            width = imageWidth;
            height = imageHeight;
        }

        //Metod för att skapa bilden.
        public Bitmap CreateBmpImage()
        {
            //Ett bitmap-objekt med den angivna storleken skapas.
            Bitmap bm = new Bitmap(width, height);

            bm.SetPixel(100, 100, Color.White);



            //Returnera bitmappen som innehåller din bild.
            return bm;
        }

    }
}
