using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDocumentor
{
    public class Program
    {
        static string GoalOfProject = @"

The primary goal of the project is to get more familier with Microsoft.SqlServer.Management.SqlParser
The secondary goal of the project is to build a tool that can document the computation flow through a complex SQL Script
   
";

        public static void Main(string[] args)
        {
             Console.WriteLine(GoalOfProject.Trim());
        }
    }
}
