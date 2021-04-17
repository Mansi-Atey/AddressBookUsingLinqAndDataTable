using System;
using System.Data;

namespace UC4_EditContactUsingName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System using Linq and DataTable");
            AddressBookDataTable addressBookDataTable = new AddressBookDataTable();
            DataTable table = addressBookDataTable.CreateAddressBookDataTable();
            addressBookDataTable.DisplayContacts(table);
            addressBookDataTable.EditContact(table);
            Console.WriteLine("\n**************************************************");
        }
    }
}
