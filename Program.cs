using System;
using System.Collections.Generic;

namespace Laboration2
{
    class Program
    {
        static void Main(string[] args)
        {
            //The following code is to see if an abstact class can be substituded with a class that has inherited from it
            Employee Emp = new Employee("Bengt", "Tester");
            List<Employee> EmpList = new List<Employee>(0);
            EmpList.Add(Emp);
            Division Div = new Division("Testing", EmpList);
            List<AbstractDivision> DivList = new List<AbstractDivision>(0);
            DivList.Add(Div);
            Organization Org = new Organization("Da Testers", "Testingstreet 101", 73367, "www.DaTesters.org", DivList);
            Console.WriteLine(Org.GetDivisions());      //Returns "System.Collections.Generic.List`1[Laboration2.AbstractDivision]"
            Console.WriteLine(Org.GetDivisions()[0].ToString());    //Returns "Laboration2.Division"
            // This throws the error "Cannot implicitly convert type 'Laboration2.AbstractDivision' to 'Laboration2.Division'. An explicit conversion exists (are you missing a cast?) [Laboration2]csharp(CS0266)"
            // Division TestDiv = Org.GetDivisions()[0];    //Does it assume all objects within are of the abstract class? <- What I wanted to say at the end
        }
    }
}
