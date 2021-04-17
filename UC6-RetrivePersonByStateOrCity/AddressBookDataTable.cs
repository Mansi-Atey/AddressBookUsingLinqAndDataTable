using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UC6_RetrivePersonByStateOrCity
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

            //Add Values for Columns
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
        public void RetrieveContactBelonginhToPerticularCityORState(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>()
                             .Where(x => x["City"].Equals("Pune") || x["State"].Equals("Maharashtra")).CopyToDataTable();
            Console.WriteLine("Following Contacts belonginh to perticular City or State ");
            DisplayContacts(contacts);
        }
        public void DisplayContacts(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>();
            foreach (var contact in contacts)
            {
                Console.WriteLine("\n------------------------------------");
                Console.Write("First Name : " + contact.Field<string>("FirstName") + " " + "Last Name : " + contact.Field<string>("LastName") + " " + "Address : " + contact.Field<string>("Address") + " " + "City : " + contact.Field<string>("City") + " " + "State : " + contact.Field<string>("State")
                    + " " + "Zip : " + contact.Field<int>("Zip") + " " + "Phone Number : " + contact.Field<long>("PhoneNumber") + " " + "Email : " + contact.Field<string>("Email") + " ");
                Console.WriteLine("\n------------------------------------");
            }
        }
    }
}
