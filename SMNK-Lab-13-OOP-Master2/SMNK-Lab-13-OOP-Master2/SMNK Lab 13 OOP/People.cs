using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMNK_Lab_13_OOP
{
    public class People
    {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Sex { get; set; }
            public string Nationality { get; set; }
            public double YearOfBirth { get; set; }
            public bool Zakordonnyi { get; set; }
            public bool Prava { get; set; }

            public double GetYearIncomePerInhabitant()
            {
                return 2024 - YearOfBirth;
            }
            public People()
            {

            }
            public People(string name, string surname, string sex,
                 string nationality, double yearofbirth, bool zakordonnyi,
                 bool prava)
            {
                Name = name;
                Surname = surname;
                Sex = sex;
                Nationality = nationality;
                YearOfBirth = yearofbirth;
                Zakordonnyi = zakordonnyi;
                Prava = prava;
            }
        }
    }

    
