using System;
using System.Linq;
using System.Globalization;

namespace FixationLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salaryRange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            List<PeopleData> list = new List<PeopleData>();

            using(StreamReader sr = File.OpenText(path)) {
            
            while(!sr.EndOfStream)
                {
                    string[] Line = sr.ReadLine().Split(',');
                    string name = Line[0];
                    string Email = Line[1];
                    double Salary = double.Parse(Line[2], CultureInfo.InvariantCulture);
                    list.Add(new PeopleData(name, Email, Salary));
                }
            
            }
            var Morethan = list.Where(p => p.Salary > salaryRange).Select(p => p.Email);
            foreach(string Email in Morethan)
            {
                Console.WriteLine(Email);
            }
            var sum = list.Where(p=> p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts in 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
