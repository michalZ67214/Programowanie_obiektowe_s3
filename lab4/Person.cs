using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }

        public void SetFirstName(string firstName)
        {
            this.FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }

        public void SetPesel(string pesel)
        {
            this.Pesel = pesel;
        }

        public int GetAge()
        {
            int year = int.Parse(this.Pesel.Substring(0, 2));
            int month = int.Parse(this.Pesel.Substring(2, 2));
            int day = int.Parse(this.Pesel.Substring(4, 2));

            int currentYear = DateTime.Now.Year;

            int age = currentYear - (1900 + year);

            return age;
        }

        public string GetGender()
        {
            int genderDigite = int.Parse(this.Pesel.Substring(9, 1));
            return (genderDigite % 2 == 0) ? "Kobieta" : "Mezczyzna";
        }

        public virtual string GetEducationInfo()
        {
            return "Edukacja";
        }

        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public virtual bool CanGoAloneToHome()
        {
            return this.GetAge() > 12;
        }
    }
}
