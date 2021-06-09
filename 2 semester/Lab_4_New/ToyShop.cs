using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Serializable]
    public class ToyShop
    {
        private String adress;
        private int studentsAmount = 0;

        public List<Circle> supplies = new List<Circle>();

        public ToyShop()
        {
            Random random = new Random();
            adress = "street, " + random.Next(1, 100);
        }
        
        public override string ToString()
        {
            return "Адреса: " + adress;
        }

        public void CalculateStudents()
        {
            studentsAmount = 0;
            foreach (var i in supplies)
            {
                studentsAmount += i.CountStudents;
            }
        }
        
        public string ToShortString()
        {
            CalculateStudents();

            return supplies.ToString() + ", " + adress + ", " + studentsAmount;
        }
    }
}
