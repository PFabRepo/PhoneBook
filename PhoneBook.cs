using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddNewContact(Contact contact)
        {
            Contacts.Add(contact);     
        }

        private void DisplayContactDetails(Contact contact) 
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts) 
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContact(string number) 
        {
            Contact contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts() 
        {
            DisplayContactsDetails(Contacts);
        }

        public void DisplayMatchingContacts(string searchPhrase) 
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }



    }
}
