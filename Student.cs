using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac28
{
    internal class Student : Person
    {
        /// <summary>
        /// поля
        /// </summary>
        int birthday;
        int stage;
        /// <summary>
        /// свойства
        /// </summary>
        public int Birthday { get; set; }
        public int Stage { get; set; }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="birthday"></param>
        /// <param name="stage"></param>
        public Student(string name, string surname, int age, int birthday, int stage) : base(name, surname, age)
        {
            Birthday = birthday;
            Stage = stage;
        }
        /// <summary>
        /// вывод
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name}\nФамилия:{Surname}\nВозраст:{Age}\nДень рождения:{Birthday}\nКурс:{Stage}");
        }
    }
}
