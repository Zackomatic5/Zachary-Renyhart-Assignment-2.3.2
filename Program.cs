using System.Net.Security;
using System.Numerics;

namespace Zachary_Renyhart_Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {   double total = 45.79;
            Console.WriteLine("Hello and thank you for eating at La Quinta's");
            Console.WriteLine("Your bill after eating with us comes out to $" + total);
            Console.WriteLine("Please enter the % of tip would you like to add?");
            
            double tip = Convert.ToDouble(Console.ReadLine());
            double totalBill = total * (tip / 100); //This takes the percentage and divides it by 100 to give it a . decimal.
            double grandFinalPrice = totalBill + total; //This takes the starting price and addes it w
            Console.WriteLine("Your total bill at La Quinta's with tip will be $" + grandFinalPrice);
           
         
        }


        
    }
}
