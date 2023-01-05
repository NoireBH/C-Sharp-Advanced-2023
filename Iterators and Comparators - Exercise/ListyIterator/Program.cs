using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split()
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(items);

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                    
                    default:
                        break;
                }
            }
        }
    }
}
