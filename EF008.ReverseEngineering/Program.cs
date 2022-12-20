using System;

namespace EF008.ReverseEngineering
{
    class Program
    {
        // Step #1: Package Manager Console (PMC)
        //    Tools -> Nuget Package Manager -> Package Manager Console

        // Step #2: Package Manager Console (PMC) Tool 
        //    Install-Package Microsoft.EntityFrameworkCore.Tools

        // Step #3: Install Nuget Page on Project Microsoft.EntityFrameworkCore.Design
        // Microsoft.EntityFrameworkCore.SqlServer

        // Step #4: Install Provider in the project Microsoft.EntityFrameworkCore.SqlServer

        // Step #5: Run Command (Full)
        //    Scaffold-DbContext '[Connection String]' [Provider]



        public static void Main(string[] args)
        {
            //foreach (var item in new AppDbContext().Speakers)
            //{
            //    Console.WriteLine(item.FirstName + " " + item.LastName);
            //}
            Console.ReadKey();
        }
    }
}