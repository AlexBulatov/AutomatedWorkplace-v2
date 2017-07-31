using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMv2
{
    public class Model
    {
        public class AmbulatorCard
        {
            //Переменные для отображения в модели
            private int id;
            private DateTime firstVisitDate;
            private string breeder;
            private string phone;
            private string kindOfAnimal;
            private string address;
            private string breed;
            private string petName;
            private bool gender;
            private DateTime dateOfBirth;
            
            //Для точной даты рождения
            public DateTime DateOfBirth
            { 
                get => dateOfBirth;
                set => dateOfBirth = value;
            }
            // Конвертация нескольких строк в дату (при отсутствии точной даты рождения)
            public static DateTime getBirthFromString(params decimal[] value)
            {
                int year = (int)value[0];
                int month = (int)value[1];
                int day = (int)value[2];
                TimeSpan age = new TimeSpan(year * 365 + month * 30 + day, 0, 0, 0);
                DateTime dayOfBirth = DateTime.Now - age;
                return dayOfBirth;
            }
            public DateTime FirstVisitDate
            {
                get => firstVisitDate;
                set => firstVisitDate = value;
            }
            public string Breeder
            {
                get => breeder;
                set => breeder = value;
            }
            public string Phone
            {
                get => phone;
                set => phone = value;
            }
            public string Address
            {
                get => address;
                set => address = value;
            }
            public string KindOfAnimal {
                get => kindOfAnimal;
                set => kindOfAnimal = value;
            }
            public string PetName{
                get => petName;
                set => petName = value;
            }
            public bool IsMale{
                get => gender;
                set => gender = value;
            }
            public bool StringToGender(string value){
                return (value == "Мужская") ? true : false;
            }

            public string Breed
            {
                get => breed;
                set => breed = value;
            }
            public AmbulatorCard(int id=0){
                this.id = id;
            }
            public int ID{
                get => id;
            }

        }

        public class AmbulatorRecord
        {
            private int id;
            private int toCard;
            private DateTime dateVisit;
            private int payment;
            private int debt;
            public string anamnesis;
            public string assignments;
            public string epicrisis;
           
            
            public int ID
            {
                get => id;
            }

            public int ToCard
            {
                get => toCard;
                set => toCard = value;
            }

            public DateTime DateVisit
            {
                get => dateVisit;
                set => dateVisit = value;
            }
            
            public AmbulatorRecord(int id=0)
            {
                this.id = id;
            }
            public int Payment
            {
                get => payment;
                set => payment = value;
            }
            public int Debt {
                get => debt;
                set => debt = value;
            }

        }
    }
}
