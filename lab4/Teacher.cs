using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Teacher : Student
    {
        public string TytulNaukowy {  get; set; }

        List<Student> PodwladniUczniowie { get; set; }

        public void setTytulNaukowy(string tytulNaukowy)
        {
            this.TytulNaukowy = tytulNaukowy;
        }

        public void setPodwladniUczniowie(List<Student> podwladniUczniowie)
        {
            this.PodwladniUczniowie = podwladniUczniowie;
        }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck) 
        {
            foreach (Student s in PodwladniUczniowie)
            {
                int year = int.Parse(s.Pesel.Substring(0, 2));
                int month = int.Parse(s.Pesel.Substring(2, 2));
                int day = int.Parse(s.Pesel.Substring(4, 2));

                int currentYear = dateToCheck.Year;

                int age = currentYear - (1900 + year);

                if (age > 12 && s.MozeSamWracacDoDomu) 
                {
                    Console.WriteLine(s.LastName);
                }
            }
        }

        public override string GetEducationInfo()
        {
            return $"Tytul naukowy: {this.TytulNaukowy}";
        }
    }
}
