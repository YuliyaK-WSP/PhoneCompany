using System.Collections.ObjectModel;
using PhonsCompany.Data;
using PhonsCompany.Model;

namespace PhonsCompany.ViewModel
{
    public class AbonentViewModel
    {
        public ObservableCollection<AbonentInfo> AbonentInfos { get; set; }

        public AbonentViewModel()
        {
            AbonentInfos = new ObservableCollection<AbonentInfo>();

            foreach (var abonent in DataTest.Abonents)
            {
                var adress = DataTest.Adresses.FirstOrDefault(a => a.AbonentId == abonent.Id);
                var street = DataTest.Streets.FirstOrDefault(s => s.Id == adress.StreetId);
                var homePhone = DataTest.PhoneNumbers.FirstOrDefault(p => p.AbonentId == abonent.Id && p.TypeId == 1);
                var workPhone = DataTest.PhoneNumbers.FirstOrDefault(p => p.AbonentId == abonent.Id && p.TypeId == 2);
                var mobilePhone = DataTest.PhoneNumbers.FirstOrDefault(p => p.AbonentId == abonent.Id && p.TypeId == 3);

                AbonentInfos.Add(new AbonentInfo(abonent, street, adress, homePhone ?? new PhoneNumber(), workPhone ?? new PhoneNumber(), mobilePhone ?? new PhoneNumber()));
            }
        }
        public List<AbonentInfo> FindAbonentsByPhoneNumber(string phoneNumber)
        {
            return AbonentInfos.Where(abonent => abonent.HomePhone == phoneNumber
                                                        || abonent.WorkPhone == phoneNumber
                                                        || abonent.MobilePhone == phoneNumber
                                                        || phoneNumber == "").ToList();
        }

    }
}