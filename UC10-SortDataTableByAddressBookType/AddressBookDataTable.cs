using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UC10_SortDataTableByAddressBookType
{
    class AddressBookDataTable
    {
        public DataTable CreateAddressBookDataTable()
        {
            DataTable addressBookTable = new DataTable();

            //Add Columns to DataTable
            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("PhoneNumber", typeof(long));
            addressBookTable.Columns.Add("Email", typeof(string));
            addressBookTable.Columns.Add("AddressBookType", typeof(string));
            addressBookTable.Columns.Add("AddressBookName", typeof(string));

            addressBookTable.Rows.Add("Mansi", "Atey", "New India", "Mumbai", "Maharashtra", 400058, 9876543210, "manu@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Rashi", "Nagar", "Venus Hights", "Pune", "Maharashtra", 763222, 933343210, "rash@gmail.com", "Friends", "AddressBook2");
            addressBookTable.Rows.Add("Neha", "Adhav", "KGN society", "Nagpur", "Maharashtra", 403222, 6776543210, "neha@gmail.com", "Family", "AddressBook1");
            addressBookTable.Rows.Add("Asha", "Neghi", "Neer Road", "Benglore", "Karnataka", 40002, 999000880, "ash@gmail.com", "Professional", "AddressBook");
            addressBookTable.Rows.Add("Prakash", "Swami", "Panji", "Panaji", "Goa", 43254, 7777743210, "asd@gmail.com", "Friends", "AddressBook1");
            addressBookTable.Rows.Add("Rama", "Magare", "Indor", "Indore", "MP", 43254, 7877743990, "Rama@gmail.com", "Family", "AddressBook2");
            addressBookTable.Rows.Add("Rekha", "Swami", "GH road", "Baroda", "Gujrat", 43254, 7888743210, "rekha@gmail.com", "Professional", "AddressBook3");

            //Return AddressBook DataTable
            return addressBookTable;
        }
        public void CountContactsByAddressBookType(DataTable table)
        {
            var friendsContacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["AddressBookType"].Equals("Friends")).Count();
            Console.WriteLine("Number of Persons belongs to type 'Friends' : {0} ", friendsContacts);
            var familyContact = table.Rows.Cast<DataRow>()
                             .Where(x => x["AddressBookType"].Equals("Family")).Count();
            Console.WriteLine("Number of Persons belongs to type 'Family' : {0} ", familyContact);
            var ProfessionalContact = table.Rows.Cast<DataRow>()
                             .Where(x => x["AddressBookType"].Equals("Professional")).Count();
            Console.WriteLine("Number of Persons belongs to type 'Professional' : {0} ", ProfessionalContact);
        }
    }
}
