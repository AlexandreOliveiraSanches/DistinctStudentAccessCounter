using DistinctStudentAccessCounter.Entities;
using System;
using System.IO;

namespace AccessCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Student> set = new HashSet<Student>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    int codeUser = int.Parse(Console.ReadLine());
                    set.Add(new Student(codeUser));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    int codeUser = int.Parse(Console.ReadLine());
                    set.Add(new Student(codeUser));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                try
                {
                    int codeUser = int.Parse(Console.ReadLine());
                    set.Add(new Student(codeUser));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Total students: " + set.Count);

        }
    }
}