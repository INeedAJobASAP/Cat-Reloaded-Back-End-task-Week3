using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CATReloaded_BackendTask_Week3
{
    #region Swap_Task
    /*  internal class Program
      {
          static void Swap<T>(ref T a, ref T b)
          {
              T temp = a;
              a = b;
              b = temp;
          }
          static void Main()
          {
              int num1 = 14132, num2 = 214;
              Console.WriteLine($"before swap:\n num1 = {num1}\n num2 = {num2}");
              Swap(ref num1, ref num2);
              Console.WriteLine($"after swap:\n num1 = {num1}\n num2 = {num2}\n");
              
              string str1 = "one", str2 = "two";
              Console.WriteLine($"before swap:\n str1 = {str1}\n str2 = {str2}");
              Swap(ref str1, ref str2);
              Console.WriteLine($"after swap:\n str1 = {str1}\n str2 = {str2}\n");
          }
      }*/
    #endregion
    #region Dictionary_Task
   /* internal class Program1
    {
        static void FindGrade(Dictionary<string, int> students)
        {
            Console.Write("enter student name: ");
            string name = Console.ReadLine().ToLower();
            foreach (var student in students)
            {
                if (student.Key.ToLower() == name)
                {
                    Console.WriteLine($"{student.Key}'s grade: {student.Value}");
                    return;
                }
            }
            Console.WriteLine("please enter name again.");
            Console.ReadLine();
        }
        static void Main()
        {
            Dictionary<string, int> students = new Dictionary<string, int>
            {
                { "Soly",85 },
                { "Ahmed",90 },
                { "Mohammed",78 },
                { "Amin",92 },
                { "Abdelaziz",88 }
            };
            FindGrade(students);
        }
    }*/
    #endregion
    #region Queue_Task
    /* internal class Program
     {
         static void queue(Queue<string> customerQ)
         {
             Console.WriteLine("Processing customer service queue:");
             while (customerQ.Count > 0)
             {
                 string customer = customerQ.Dequeue();
                 Console.WriteLine($"Serving customer: {customer}");
             }
         }
         static void Main()
         {
             Queue<string> customerQ=new Queue<string>();
             customerQ.Enqueue("Soly");
             customerQ.Enqueue("Ahmed");
             customerQ.Enqueue("Mohammed");
             customerQ.Enqueue("Amin");
             customerQ.Enqueue("Abdelaziz");
            queue(customerQ);
         }
     }*/
    #endregion
}
