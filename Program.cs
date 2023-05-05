using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;
            int option, option2, i, indexToRemove;
            string taskToAdd, firstTask;
            string[] list = new string[0];
            while (toContinue)
            {
                Console.WriteLine("Hello and welcome to our ToDo App");
                Console.WriteLine();
                System.Threading.Thread.Sleep(400);
                Console.WriteLine("Choose what you want to:");
                System.Threading.Thread.Sleep(400);
                Console.WriteLine("1: See your ToDo List");
                Console.WriteLine("2: Edit your ToDo list");
                Console.WriteLine("3: Reset your ToDo list");
                Console.WriteLine("4: Quit");
                Console.WriteLine();
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    if (list.Length > 0)
                    {
                        Console.WriteLine("This is your ToDo list:");
                        for (i = 0; i < list.Length; i++)
                        {
                            Console.Write(i + ": ");
                            Console.WriteLine(list[i]);
                        }
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Your list is empty.");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Select what do you want to edit in your list:");
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("1: Ad a task to your ToDo list");
                    Console.WriteLine("2: Remove a task from your ToDo list");
                    Console.WriteLine();
                    option2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (option2 == 1)
                    {
                        Console.WriteLine("What task to Add to the ToDo list?");
                        taskToAdd = Console.ReadLine();
                        Array.Resize(ref list, list.Length + 1);
                        list[list.Length - 1] = taskToAdd;
                        Console.WriteLine();
                    }
                    else if (option2 == 2)
                    {
                        Console.WriteLine("What task number do you want to remove? ");
                        indexToRemove = int.Parse(Console.ReadLine()) - 1 ;
                        string[] newList = new string[list.Length - 1];

                        for (int a = 0, b = 0; a < list.Length; a++)
                        {
                            if (a != indexToRemove)
                            {
                                newList[b] = list[a];
                                b++;
                            }
                        }

                        list = newList;

                        Console.WriteLine("Your list is now updated!");
                        System.Threading.Thread.Sleep(1200);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Please enter only 1 or 2");
                        Console.WriteLine();
                    }
                    Console.Clear();
                }
                else if (option == 3)
                {
                    firstTask = list[0];
                    list = new string[] {firstTask};
                    Console.WriteLine("Your list is now empty.");
                    System.Threading.Thread.Sleep(800);
                    Console.Clear();
                }
                else if (option == 4)
                {
                    toContinue = false;
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
