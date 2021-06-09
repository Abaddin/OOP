using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Serializable]
    public class Head
    {
        private string name;
        private string surname;
        private DateTime date;
        private Section sectionType;
        public enum Section
        {
            Малювання,
            Танцювальний,
            Моделювання,
            Мяка_іграшка
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }

        public DateTime Date
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
        
        public Section SectionType
        {
            set
            {
                sectionType = value;
            }
            get
            {
                return sectionType;
            }
        }

        public override string ToString()
        {
            return name + ", " + surname + ", " + date;
        }
    }
}
