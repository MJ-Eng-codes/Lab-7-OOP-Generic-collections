//MJ Eng[.NET24]

using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Lab_7_OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa 5 Objekt i klass Employee
                Employee employee1 = new Employee(123, "Anna", true, 50000);
                Employee employee2 = new Employee(234, "Beatrice", true, 40000);
                Employee employee3 = new Employee(345, "Claire", true, 30000);
                Employee employee4 = new Employee(456, "David", false, 20000);
                Employee employee5 = new Employee(567, "Eric", false, 10000);

            //Stack (Del 1)
                    //Lägg till 5 objekt med Push()
                    Stack<Employee> Employees = new Stack<Employee>();
                    Employees.Push(employee1);
                    Employees.Push(employee2);
                    Employees.Push(employee3);
                    Employees.Push(employee4);
                    Employees.Push(employee5);


                //Skriv ut alla objekt i Stack (foreach?), efter varje rad/element hur många objekt som finns kvar i stacken
                    int i = 1;
                foreach (var item in Employees)
                {
                    Console.WriteLine($"Employee {i}: {item.Name} with ID: {item.Id}, is Female: {item.IsFemale}, has the salary: {item.Salary}");
                     i++;
                }
                Console.WriteLine();

                Console.WriteLine($"Hur många objekt som finns kvar i stacken? \n {Employees.Count}");

                Console.WriteLine();

                //Hämta alla objekt med POP()
                //efter varje rad/element hur många objekt som finns kvar i stacken
                while (Employees.Count > 0)
                {
                    var item = Employees.Peek();
                    Console.WriteLine($"Översta element i stacken Employee: {item.Name} with ID: {item.Id}, is Female: {item.IsFemale}, has the salary: {item.Salary}. tas bort");
                    Employees.Pop();
                    Console.WriteLine($"Hur många objekt som finns kvar i stacken? \n {Employees.Count}");
                    Console.WriteLine();
                }

                //Lägg till alla objekt igen genom Push()
                Employees.Push(employee1);
                Employees.Push(employee2);
                Employees.Push(employee3);
                Employees.Push(employee4);
                Employees.Push(employee5);

                //Hämta 2 objekt med Peek()
                //efter varje rad/element hur många objekt som finns kvar i stacken
                dynamic topItem = Employees.Peek();
                topItem = Employees.Pop();
                dynamic secondItem = Employees.Peek();

                Console.WriteLine($"Första Objekt: {topItem.Name}, {topItem.Id}, {topItem.Salary}. Employee is Female: {topItem.IsFemale}");
                Console.WriteLine($"Andra Objekt: {secondItem.Name}, {secondItem.Id}, {secondItem.Salary}. Employee is Female: {secondItem.IsFemale}");
                Console.WriteLine($"Hur många objekt som finns kvar i stack Employee?:  {Employees.Count}");
                Employees.Push(topItem);
                Console.WriteLine($"Push Employee 1 tillbaka i stacken. Hur många objekt som finns kvar i stack Employee?:  {Employees.Count}");

                // Kolla om objekt nr 3 finns i stacken eller ej, skriv ut resultat
                bool containsthree = Employees.Contains(employee3);
                Console.WriteLine((containsthree == true) ? $"Objekt nr 3 finns i stacken: {employee3.Name}, {employee3.Id}, {employee3.Salary}, Is female: {employee3.IsFemale}" : "Objekt nr 3 finns ej i stacken");

            Console.WriteLine();

            //List (Del 2)
                List<Employee> Medarbetare = new List<Employee> ();
                    Medarbetare.Add(employee1);
                    Medarbetare.Add(employee2);
                    Medarbetare.Add(employee3);
                    Medarbetare.Add(employee4);
                    Medarbetare.Add(employee5);

                    //Kolla om objekt finns i listan 
                    bool containsE2 = Medarbetare.Contains(employee2);
                    Console.WriteLine((containsE2==true)? $"Employee2 object exists in the list":$"Employee2 object does not exist in the list");

                //Hitta och skriva ut det första objekt i listan som har Gender = male
                Employee findFirstMale = Medarbetare.Find(x => x.IsFemale == false);
                if (findFirstMale != null)
                {
                    Console.WriteLine($"First male employee: {findFirstMale.Name}, {findFirstMale.Id}, {findFirstMale.Salary}, Is female: {findFirstMale.IsFemale}");
                }
                else
                {
                    Console.WriteLine("No male employee found.");
                }
                Console.WriteLine();

                //Hitta och skriva ut all objekt i listan som har Gender = Male
               List<Employee> findMales = Medarbetare.FindAll(x => x.IsFemale == false);
                if (findMales.Count > 0)
                {
                    foreach (var male in findMales)
                    {                    
                        Console.WriteLine($"Male employee: {male.Name}, {male.Id}, {male.Salary}, Is female: {male.IsFemale}");
                    }
                }
                else
                {
                    Console.WriteLine("No male employees found.");
                }
                Console.WriteLine();


        }
    }
}
