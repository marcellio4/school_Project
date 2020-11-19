using System.Collections.Generic;

namespace VirtualProxy
{
    public class ContactsProxyImpl: IContacts
    {
        private IContacts _contacts;
        
        public IList<Employee> Employees()
        {
           return new ContactsImpl().Employees();
        }
    }
}