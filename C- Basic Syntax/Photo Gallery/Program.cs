using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPhoto = int.Parse(Console.ReadLine());
            int dayTaken = int.Parse(Console.ReadLine());
            int monthTaken = int.Parse(Console.ReadLine()); ;
            int yearTaken = int.Parse(Console.ReadLine()); ;
            int hours = int.Parse(Console.ReadLine()); ;
            int minutes = int.Parse(Console.ReadLine()); ;
            double sizeInBytes = double.Parse(Console.ReadLine());
            double widthInPixels = double.Parse(Console.ReadLine());
            double heightInPixels = double.Parse(Console.ReadLine());


            Console.WriteLine("Name: DSC_{0, 0:D4}.jpg", numberPhoto);
            Console.WriteLine("Date Taken: {0,0:D2}/{1,0:D2}/{2,0:D4} {3,0:D2}:{4,0:D2}",
                dayTaken, monthTaken, yearTaken, hours, minutes);


            if (sizeInBytes < 1000)
            {
                Console.WriteLine("Size: {0}B", sizeInBytes);
            }
            else if (sizeInBytes < 1000000)
            {
                sizeInBytes /= 1000;
                Console.WriteLine("Size: {0}KB", sizeInBytes);
            }
            else
            {
                sizeInBytes /= 1000000;
                Console.WriteLine("Size: {0}MB", sizeInBytes);
            }

            string orientation = "";

            if (widthInPixels > heightInPixels)
            {
                orientation = "landscape";
            }
            else if (widthInPixels < heightInPixels)
            {
                orientation = "portrait";
            }
            else if (widthInPixels == heightInPixels)
            {
                orientation = "square";
            }

            Console.WriteLine($"Resolution: {widthInPixels}x{heightInPixels} ({orientation})");

        }
    }
}
