using PhonsCompany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.Data
{
    class DataTest
    {
        public static List<Abonent> Abonents { get; } = new()
        {
            new Abonent{Id=1,LastName="Иванов",FirstName="Иван",Patronymic="Иванович"},
            new Abonent{Id=2,LastName="Петров",FirstName="Петр",Patronymic="Петрович"},
            new Abonent{Id=3,LastName="Васильев",FirstName="Василий",Patronymic="Вальевич"},
            new Abonent{Id=4,LastName="Сергеев",FirstName="Сергей",Patronymic="Сергеевич"},

        };
        public static List<PhoneType> PhoneTypes { get; } = new()
        {
            new PhoneType{Id=1,TypeName="Домашний"},
            new PhoneType{Id=2,TypeName="Рабочий"},
            new PhoneType{Id=3,TypeName="Мобильный"}
        };
        public static List<Street> Streets { get; } = new()
        {
            new Street{Id=1,Name = "Молодежная"},
            new Street{Id=2,Name = "Ленина"},
            new Street{Id=3,Name = "Чайковского"}
        };
        public static List<PhoneNumber> PhoneNumbers { get; } = new()
        { 
            new PhoneNumber { Id=1, AbonentId = 1, TypeId = 2, Number = "+7(999)777-99-55" },
            new PhoneNumber { Id=2, AbonentId = 1, TypeId = 3, Number = "+7(999)777-99-44" },
            new PhoneNumber { Id=3, AbonentId = 2, TypeId = 1, Number = "+7(495)888-71-55" },
            new PhoneNumber { Id=4, AbonentId = 2, TypeId = 2, Number = "+7(999)321-00-10" },
            new PhoneNumber { Id=5, AbonentId = 2, TypeId = 3, Number = "+7(903)777-99-55" },
            new PhoneNumber { Id=6, AbonentId = 3, TypeId = 2, Number = "+7(495)007-14-10" },
            new PhoneNumber { Id=7, AbonentId = 4, TypeId = 3, Number = "+7(909)777-33-11" }
        };
        public static List<Adress> Adresses { get; } = new()
        {
            new Adress{ AbonentId=1, City ="Москва", Region = "РФ", StreetId = 1, HousNumber = "5а" },
            new Adress{ AbonentId=2, City ="Москва", Region = "РФ", StreetId = 2, HousNumber = "10б" },
            new Adress{ AbonentId=3, City ="Москва", Region = "РФ", StreetId = 3, HousNumber = "15а" },
            new Adress{ AbonentId=4, City ="Москва", Region = "РФ", StreetId = 1, HousNumber = "7а" },
        };
    }
}
