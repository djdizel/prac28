using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Введите имя:");
                string name = Console.ReadLine();
                Console.Write($"Введите фамилию:");
                string surname = Console.ReadLine();
                Console.Write($"Введите возраст:");
                int age = Convert.ToInt32(Console.ReadLine());
                person.Add(new Person(name, surname, age));
                person[i].Print();
            }
            Console.WriteLine();


            //List<Employee> employee = new List<Employee>();
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.Write($"Введите имя:");
            //    string name = Console.ReadLine();
            //    Console.Write($"Введите фамилию:");
            //    string surname = Console.ReadLine();
            //    Console.Write($"Введите возраст:");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"Введите название предприятия:");
            //    string company = Console.ReadLine();
            //    Console.Write($"Введите должность:");
            //    string post = Console.ReadLine();
            //    employee.Add(new Employee(name, surname, age,company,post));
            //    employee[i].Print();
            //}

            while (true)
            {
                Console.WriteLine("\nВыберите класс (S - Student, E-Employee, Q-выход):");
                string choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "S":
                        List<Student> student = new List<Student>();
                        for (int i = 0; i < 1; i++)
                        {
                            Console.Write($"Введите имя:");
                            string name = Console.ReadLine();
                            Console.Write($"Введите фамилию:");
                            string surname = Console.ReadLine();
                            Console.Write($"Введите возраст:");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"Введите год рождения:");
                            int birthday = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"Введите курс:");
                            int stage = Convert.ToInt32(Console.ReadLine()); ;
                            student.Add(new Student(name, surname, age, birthday, stage));
                            student[i].Print();
                        }
                        break;

                    case "E":
                        List<Employee> employee = new List<Employee>();
                        for (int i = 0; i < 1; i++)
                        {
                            Console.Write($"Введите имя:");
                            string name = Console.ReadLine();
                            Console.Write($"Введите фамилию:");
                            string surname = Console.ReadLine();
                            Console.Write($"Введите возраст:");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"Введите название предприятия:");
                            string company = Console.ReadLine();
                            Console.Write($"Введите должность:");
                            string post = Console.ReadLine();
                            employee.Add(new Employee(name, surname, age, company, post));
                            employee[i].Print();
                        }
                        break;

                    case "Q": // Добавлена кнопка для выхода
                        Console.WriteLine("Выход из программы...");
                        return; // или Environment.Exit(0); в зависимости от контекста программы
                        break;

                    default: // Опционально: обработка неверного ввода
                        Console.WriteLine("Неверный выбор. Используйте S для студентов, E для сотрудников или Q для выхода.");
                        break;
                }
            }
            }
        }
    }
