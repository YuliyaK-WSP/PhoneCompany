using PhonsCompany.Data;
using PhonsCompany.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonsCompany.ViewModel
{
    public class StreetViewModel
    {
        public ObservableCollection<StreetInfo> StreetInfos { get; set; }

        public StreetViewModel()
        {
            StreetInfos = new ObservableCollection<StreetInfo>();
            foreach (var street in DataTest.Streets)
            {
                int abonentCount = DataTest.Adresses.Count(a => a.StreetId == street.Id);
                StreetInfos.Add(new StreetInfo(street, abonentCount));
            }
        }
    }
}
