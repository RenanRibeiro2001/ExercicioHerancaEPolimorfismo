using System;
using System.Collections.Generic;
using Curso8.Entities;

namespace Curso8
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Product ${i} data: ");
                Console.Write("Common, used or imported (c/u/i) ? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                
                if(tipo == 'i')
                {
                    Console.WriteLine("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customFee));
                }else if(tipo == 'u')
                {
                    Console.WriteLine("ManufactureDate (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }else
                {
                    list.Add(new Product(name, price));   
                }
            }

            Console.WriteLine("Price Tags: ");
            foreach(Product pro in list)
            {
                Console.WriteLine(pro.priceTag());
            }
        }
    }
}