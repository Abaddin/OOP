using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Serializable]
    public class Circle
    {
        private String name;
        private Head.Section _section;
        private int price;
        private int countLessons;
        private int countStudents;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Head.Section Section
        {
            get => _section;
            set => _section = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public int CountLessons
        {
            get => countLessons;
            set => countLessons = value;
        }

        public int CountStudents
        {
            get => countStudents;
            set => countStudents = value;
        }

        public override string ToString()
        {
            return name + ", " + _section + ", " + price + ", " + countLessons + ", " + countStudents;
        }
    }
}
