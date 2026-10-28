
using System;
using System.Collections.Generic;

namespace Lab5StackList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar fem anställda
            Employee employee1 = new Employee(1, "peter", "Male", 28000);
            Employee employee2 = new Employee(2, "Sara", "Female", 30000);
            Employee employee3 = new Employee(3, "Emil", "Male", 27000);
            Employee employee4 = new Employee(4, "Celine", "Female", 32000);
            Employee employee5 = new Employee(5, "Omar", "Male", 29000);


            // Skapar en Stack och lägger till de fem anställda
            Stack<Employee> anstallda = new Stack<Employee>();

            anstallda.Push(employee1);
            anstallda.Push(employee2);
            anstallda.Push(employee3);
            anstallda.Push(employee4);
            anstallda.Push(employee5);


            // Skriver ut alla anställda i Stacken
            Console.WriteLine("Alla anställda i Stacken:");

            foreach (Employee anstalld in anstallda)
            {
                Console.WriteLine(anstalld);
                Console.WriteLine("Antal anställda i Stacken: " + anstallda.Count);
            } // foreach slutar här

            // Hämtar och tar bort alla anställda med Pop()
            Console.WriteLine();
            Console.WriteLine("Hämtar anställda med Pop:");

            while (anstallda.Count > 0)
            {
                Employee borttagen = anstallda.Pop();

                Console.WriteLine(borttagen);
                Console.WriteLine("Antal anställda kvar: " + anstallda.Count);
            } // while slutar här


            // Lägger tillbaka alla anställda i Stacken
            anstallda.Push(employee1);
            anstallda.Push(employee2);
            anstallda.Push(employee3);
            anstallda.Push(employee4);
            anstallda.Push(employee5);

            Console.WriteLine();
            Console.WriteLine("Alla anställda har lagts tillbaka.");
            Console.WriteLine("Antal anställda i Stacken: " + anstallda.Count);


            // Tittar på den översta anställda med Peek()
            Console.WriteLine();
            Console.WriteLine("Tittar på anställda med Peek:");

            Employee första = anstallda.Peek();
            Console.WriteLine(första);
            Console.WriteLine("Antal anställda i Stacken: " + anstallda.Count);

            Employee andra = anstallda.Peek();
            Console.WriteLine(andra);
            Console.WriteLine("Antal anställda i Stacken: " + anstallda.Count);

            // Kontrollerar om anställd nummer 3 finns i Stacken
            if (anstallda.Contains(employee3))
            {
                Console.WriteLine("Anställd nummer 3 finns i Stacken.");
            }
            else
            {
                Console.WriteLine("Anställd nummer 3 finns inte i Stacken.");
            }


            // Skapar en lista med fem anställda
            List<Employee> anstalldaLista = new List<Employee>();

            anstalldaLista.Add(employee1);
            anstalldaLista.Add(employee2);
            anstalldaLista.Add(employee3);
            anstalldaLista.Add(employee4);
            anstalldaLista.Add(employee5);

            // Kontrollerar om employee2 finns i listan
            if (anstalldaLista.Contains(employee2))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }


            // Hittar den första anställda som har könet Male
            Employee förstaMan = anstalldaLista.Find(anställd => anställd.Gender == "Male");

            Console.WriteLine();
            Console.WriteLine("Första anställda med könet Male:");
            Console.WriteLine(förstaMan);

            Console.WriteLine(förstaMan);


            // Hittar alla anställda som har könet Male
            List<Employee> allaMän = anstalldaLista.FindAll(anställd => anställd.Gender == "Male");

            Console.WriteLine();
            Console.WriteLine("Alla anställda med könet Male:");

            foreach (Employee anställd in allaMän)
            {
                Console.WriteLine(anställd);
            }


        }
    }

}
