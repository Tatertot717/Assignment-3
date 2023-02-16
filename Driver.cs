using System.ComponentModel.Design;

namespace Assignment_3
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            List<Customer> list = new List<Customer>();

            static void Menu(){
                Console.WriteLine("1. Take test for new license\r\n2. Renew existing license\r\n3. Move from out of state\r\n4. Answer citation/suspended license\r\n5. See current queue\r\n6. Quit\r\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
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
                Menu();
            }
        }
    }
}