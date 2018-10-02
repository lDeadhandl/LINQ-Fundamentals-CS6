using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {

            //using func type used more 
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;


            //using action type used less than func types
            // always returns void
            Action<int> write = x => Console.WriteLine(x);
            write(square(add(3,5)));
             
            //creating an array of Employee using IEnumerable
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott"},
                new Employee { Id = 2, Name = "Chris"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };

            Console.WriteLine(developers.Count());
            // Using only method of IEnumerable,GetEnumerator, that allows us to iterate
            // through and collection of things
            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.Write(enumerator.Current.Name);
            }

            // Complicated way of filtering without lambda
            foreach(var employee in developers.Where(
                delegate (Employee employee)
            {
                return employee.Name.StartsWith("S");
            }))
            {
                Console.WriteLine(employee.Name);
            }

            //instead use lambda expression to simplify above expression
            foreach (var employee in developers.Where(
                            e => e.Name.StartsWith("S")))
               { 
                   Console.WriteLine(employee.Name);
               }
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
