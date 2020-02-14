using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Contact :PdaItem , IListable
    {
        public string firstName { get; set; }
        public string surName { get; set; }
        public string address { get; set; }
        public  string phone { get; set; }
        public Contact(string firstName, string surName, string address, string phone) : base(null)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.address = address;
            this.phone = phone;
        }

        public string[] ColumnValues
        {
            get
            {
                return new string[] { firstName, surName, phone, address };
            }
        }
        public static string[] Headers
        {
            get
            {
                return new string[] { "First Name", "Sur Name", "Phone", "Address" };
            }
        }
    }
}
