using System;

namespace empcsharp
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] names = { "tushar", "parth", "rahul" };
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            int[] list = new int[] { 1, 2, 3, 4, 5 };
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Emp[] emplist = new Emp[]
            {
                new Emp{Id=1,Name="tushar",Salary=2000},
                new Emp{Id=2,Name="suraj",Salary=2400},
                new Emp{Id=3,Name="rohan",Salary=2500},
                new Emp{Id=4,Name="rahul",Salary=2050},
            };

            foreach (Emp e in emplist)
            {
                Console.WriteLine($"{e.Id}  {e.Name}  {e.Salary}");
            }

        }
    }
}


   
        
    

