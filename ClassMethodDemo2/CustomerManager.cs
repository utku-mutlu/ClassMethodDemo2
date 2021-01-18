using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ClassMethodDemo2
{
    class CustomerManager
    {
        ArrayList customers = new ArrayList();
        public void CustomerAdd(Customer customer)
        {
            customers.Add(customer);
        }
        public void CustomerRemove(Customer customer)
        {
            customers.Remove(customer);
        }
        public void CustumerUpdate(Customer customer, string Name, string Surname, string Email, string Country, string City, string Addres)
        {
            customer.Name = Name;
            customer.Surname = Surname;
            customer.Email = Email;
            customer.Country = Country;
            customer.City = City;
            customer.Address = Addres;
        }
        public void CustormerView()
        {



            foreach (Customer customer in customers)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Customer Information");
                Console.WriteLine("---------------------");
                Console.WriteLine("Customer Name: " + customer.Name);
                Console.WriteLine("Customer Surname: " + customer.Surname);
                Console.WriteLine("Customer Email: " + customer.Email);
                Console.WriteLine("Customer Country: " + customer.Country);
                Console.WriteLine("Customer City: " + customer.City);
                Console.WriteLine("Customer Address: " + customer.Address);
            }
        }
    }
}

