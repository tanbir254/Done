using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace Done.Shared
{
    public class CsvDataModelMap : ClassMap<CsvDataModel>
    {
        public CsvDataModelMap()
        {
            Map(m => m.Uid).Index(0);
            Map(m => m.FirstName).Index(1);
            Map(m => m.LastName).Index(2);
            Map(m => m.Gender).Index(3);
            Map(m => m.Birthday).Index(4);
            Map(m => m.City).Index(5);
            Map(m => m.State).Index(6);
            Map(m => m.Zip).Index(7);
            Map(m => m.SubscriptionDate).Index(8);
        }
    }
}