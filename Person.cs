using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    internal class Person
    {
        /// <summary>
        /// поля
        /// </summary>
        string name;
        string surname;
        int age;
        /// <summary>
        /// свойства
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Person() { }
        /// <summary>
        /// конструктор с парамтерами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        public Person(string name, string surname,int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        /// <summary>
        /// вывод
        /// </summary>
        //public void Print()
        //{
        //    Console.WriteLine($"Имя:{name}\nФамилия:{surname}\nВозраст:{age}");
        //}
        public virtual void Print()
        {
            Console.WriteLine($"Имя:{Name}\nФамилия:{Surname}\nВозраст:{Age}");
        }
    }
}
