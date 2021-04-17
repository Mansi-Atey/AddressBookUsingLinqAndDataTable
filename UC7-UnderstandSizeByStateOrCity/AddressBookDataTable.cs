using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UC7_UnderstandSizeByStateOrCity
{
    class AddressBookDataTable
    {
        public DataTable CreateAddressBookDataTable()
        {
            DataTable addressBookTable = new DataTable();

            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("PhoneNumber", typeof(long));
            addressBookTable.Columns.Add("Email", typeof(string));

            addressBookTable.Rows.Add("Mansi", "Atey", "New India", "Mumbai", "Maharashtra", 400058, 9876543210, "manu@gmail.com");
            addressBookTable.Rows.Add("Rashi", "Nagar", "Venus Hights", "Pune", "Maharashtra", 763222, 933343210, "rash@gmail.com");
            addressBookTable.Rows.Add("Neha", "Adhav", "KGN society", "Nagpur", "Maharashtra", 403222, 6776543210, "neha@gmail.com");
            addressBookTable.Rows.Add("Asha", "Neghi", "Neer Road", "Benglore", "Karnataka", 40002, 999000880, "ash@gmail.com");
            addressBookTable.Rows.Add("Prakash", "Swami", "Panji", "Panaji", "Goa", 43254, 7777743210, "asd@gmail.com");
            addressBookTable.Rows.Add("Rama", "Magare", "Indor", "Indore", "MP", 43254, 7877743990, "Rama@gmail.com");
            addressBookTable.Rows.Add("Rekha", "Swami", "GH road", "Baroda", "Gujrat", 43254, 7888743210, "rekha@gmail.com");

            //Return AddressBook DataTable
            return addressBookTable;
        }
       
        public void CountContactsFromPerticularCityANDState(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["City"].Equals("Baroda") && x["State"].Equals("Gujrat")).Count();
            Console.WriteLine("Count of Persons Beloning to City 'Baroda' and State 'Gujrat' : {0} ", contacts);
        }
    }
}
