using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string Name;
        public int Age;
        public int Weight;


        public string GetValue()
        {
            string value;
            value = "Имя:" + this.Name + "  Возраст:" + this.Age + "  Вес:" + this.Weight + "\n";
            return value;
        }
    }
}
