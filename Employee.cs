using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac28
{
    internal class Employee : Person
    {
        /// <summary>
        /// Поля
        /// </summary>
        string company;
        string post;
        /// <summary>
        /// Свойства
        /// </summary>
        public string Company { get; set; }
        public string Post { get; set; }
        /// <summary>
        /// конструктор с base
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="company"></param>
        /// <param name="post"></param>
        public Employee(string name,string surname,int age,string company,string post) : base(name,surname,age)
        {
            Company = company;
            Post = post;
        }
        /// <summary>
        /// метод для вывода с override
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name}\nФамилия:{Surname}\nВозраст:{Age}\nНазвание предприятия:{Company}\nДолжность:{Post}");
        }
    }
}
