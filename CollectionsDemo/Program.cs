using System;
using System.Collections.Generic;


namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Linus Torvalds"); //3.1
            names.Add("Donald Knuth");
            names.Add("Grace Hopper");

            names.Add("Donald Knuth");  //3.5
            names.Add("Jean Bartik");

            names.RemoveAt(3);
            names.Remove("Donald Knuth");

            string doAnother = " ";
            do
            {

                DisplayNames(names);

                Console.WriteLine("(A)dd, (R)emove, (S)earch: ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "A":
                        Console.Write("Name: ");
                        names.Add(Console.ReadLine());
                        break;

                    case "R":
                        Console.Write("Name: ");
                        names.Remove(Console.ReadLine());
                        /* int index;
                      if(int.TryParse(nameOrIndex, out index)) //why do we need this?
                      {
                          names.RemoveAt(index - 1);
                      }
                      else
                      {
                          names.Remove(nameOrIndex);

                      }
                     */
                        break;
                    case "S":
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Index is " + names.IndexOf(name) + 1);
                        break;

                }
                Console.WriteLine("Count of list: " + names.Count.ToString()); //3.3
                Console.WriteLine("Capacity of list: " + names.Capacity.ToString());

                names.TrimExcess(); //3.8

                Console.WriteLine("Do another? y/n");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");

        }
        private static void DisplayNames(List<string> names)
        {

            for(int i = 0; i < names.Count; ++i)
            {
                Console.WriteLine((i + 1) + "; " + names[i]);
            }
            Console.WriteLine();
        }
    }
}
