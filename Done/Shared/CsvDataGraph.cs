using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Done.Shared
{
    public class CsvDataGraph
    {

       
        [Name("uid")]
        public string Uid { get; set; }

        [Name("first_name")]
        public string FirstName { get; set; }

        [Name("last_name")]
        public string LastName { get; set; }

        [Name("gender")]
        public string Gender { get; set; }

        [Name("b_day")]
        public DateTime Birthday { get; set; }

        [Name("city")]
        public string City { get; set; }

        [Name("state")]
        public string State { get; set; }

        [Name("zip")]
        public string Zip { get; set; }

        [Name("subs_date")]
        public DateTime SubscriptionDate { get; set; }
    

}
}
