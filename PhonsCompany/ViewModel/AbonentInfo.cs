using PhonsCompany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.ViewModel
{
    public class AbonentInfo
    {
        public string FullName { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string? HomePhone { get; set; }
        public string? WorkPhone { get; set; }
        public string? MobilePhone { get; set; }

        public AbonentInfo(Abonent abonent, Street street,Adress adress, PhoneNumber homePhone, PhoneNumber workPhone, PhoneNumber mobilePhone)
        {
            FullName = $"{abonent.LastName} {abonent.FirstName} {abonent.Patronymic}";
            Street = street.Name;
            HouseNumber = adress.HousNumber;
            HomePhone = homePhone.Number;
            WorkPhone = workPhone.Number;
            MobilePhone = mobilePhone.Number;
        }
    }
}

