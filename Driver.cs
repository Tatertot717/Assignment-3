using System;
using System.ComponentModel.Design;

namespace Assignment_3
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();

            static void Menu(List<Customer> list){
                Console.WriteLine("1. Take test for new license\r\n2. Renew existing license\r\n3. Move from out of state\r\n4. Answer citation/suspended license\r\n5. See current queue\r\n6. Quit\r\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("What is your name ?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is your date of birth?");
                        string other = Console.ReadLine();
                        list.Add(new NewTest(name, other));
                        break;
                    case 2:
                        Console.WriteLine("What is your name ?");
                        name = Console.ReadLine();
                        list.Add(new Renew(name));
                        break;
                    case 3:
                        Console.WriteLine("What is your name?");
                        name = Console.ReadLine();
                        Console.WriteLine("What state did you move from?");
                        other = Console.ReadLine();
                        list.Add(new Move(name,other));
                        break;
                    case 4:
                        Console.WriteLine("What is your name?");
                        name = Console.ReadLine(); 
                        Console.WriteLine("What violation did you commit?");
                        other = Console.ReadLine();
                        list.Add(new Suspended(name, other));
                        break;
                    case 5:
                        foreach (Customer customer in list) {
                            Console.WriteLine(customer.getCustomerInfo()+"\n");
                        }
                        break;
                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not a valid choice");
                        break;

                }
            }

            while (true)
            {
                Menu(list);
            }
        }
    }
}