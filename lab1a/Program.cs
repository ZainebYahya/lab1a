using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1a
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                double width;
                double length;
                double hight;
                double area;
                double volume;
                double perimeter;
                string answer;

            // input

            do
            {

                Console.WriteLine("Welcome to Grand Circus'Room Detail Generator!");
                Console.WriteLine();
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                width = double.Parse(Console.ReadLine());

                Console.Write("Enter hight: ");

                hight = double.Parse(Console.ReadLine());


                //processing

                Console.WriteLine();
                area = length * width;
                perimeter = 2 * (length * width);
                volume = length * width * hight;


                //output
                Console.WriteLine();
                Console.WriteLine($"Area :{area}");
                Console.WriteLine($"Perimeter {perimeter}");
                Console.WriteLine($"Volume:{volume}");
                Console.WriteLine();
                Console.WriteLine("countinue? Y,N");
                answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                {
                    break;
                }
            }
            while (answer == "Y" || answer == "y");

            
                
            

            
                   
            
            
                
            
            
            
            
       

            

            }
        }
    }


    

