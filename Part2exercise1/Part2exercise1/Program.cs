using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean widthBo = false;
            Boolean heightBo = false;
            Boolean lengthBo = false;
            Console.WriteLine("-----BOX-----");
            int width = 0;
            int height = 0;
            int length = 0;
            do
            {
                Console.Write("Please enter the Width: ");
                string widthTemp = Console.ReadLine();
                try
                {
                    width = int.Parse(widthTemp);
                    if (width > 0)
                    {
                        widthBo = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than 0!");
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex);
                    Console.WriteLine("Please enter a valid number!");
                }
                
            }while(widthBo == false);

            do
            {
                Console.Write("Please enter the Height: ");
                string heightTemp = Console.ReadLine();
                try
                {
                    height = int.Parse(heightTemp);
                    if (height > 0)
                    {
                        heightBo = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than 0!");
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex);
                    Console.WriteLine("Please enter a valid number!");
                }

            } while (heightBo == false);

            do
            {
                Console.Write("Please enter the Length: ");
                string lengthTemp = Console.ReadLine();
                try
                {
                    length = int.Parse(lengthTemp);
                    if (length > 0)
                    {
                        lengthBo = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number greater than 0!");
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex);
                    Console.WriteLine("Please enter a valid number!");
                }

            } while (lengthBo == false);

            Box box1 = new Box(width, height, length);

            Console.Clear();
            Console.WriteLine("-----BOX-----");
            Console.WriteLine("Surface area: " + box1.SurfaceArea());
            Console.WriteLine("Volume: " + box1.Volume());
            Console.ReadLine();
        }
    }

    class Box {
        internal int Width { private get; set; }
        internal int Height { private get; set; }
        internal int Length { private get; set; }

        internal int SurfaceArea()
        {
            return 2 * (Height * Width) + 2 * (Height * Length) + 2 * (Width * Length);
        }

        internal int Volume()
        {
            return Length * Width * Height;
        }

        internal Box(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;
        }
    }
}
