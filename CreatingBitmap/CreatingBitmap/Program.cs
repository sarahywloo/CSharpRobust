using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingBitmap {
    class Program {
        static void Main(string[] args) {

            // create bitmap
            //bitmap utilises IDisposable so we place the code inside of a using(){} statement
            using (var bitmap = new Bitmap(500, 500)) {

                // randomly set 1000 pixels
                var rnd = new Random();
                for (var i = 0; i < 10000; i++) {

                    bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.White);
                }

                // save bitmap to current directory (debug directory)
                var currentDirectory = Environment.CurrentDirectory;
                var path = Path.Combine(currentDirectory, "MyImage.png");
                bitmap.Save(path, ImageFormat.Png);
            }
            Console.ReadLine();
        }
    }
}
