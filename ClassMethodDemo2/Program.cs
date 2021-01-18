using System;

namespace ClassMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            CustomerManager manager = new CustomerManager();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();

            customer1.Id = 1;
            customer1.Name = "utku";
            customer1.Surname = "mutlu";
            customer1.Email = "utku.mutlu22@outlook.com.tr";
            customer1.Country = "Turkey";
            customer1.City = "Edirne";
            customer1.Address = "Kıyık Street";

            manager.CustomerAdd(customer1);

            customer2.Id = 2;
            customer2.Name = "arzu";
            customer2.Surname = "mutlu";
            customer2.Email = "arzupinarmutlu@gmail.com";
            customer2.Country = "Turkey";
            customer2.City = "Edirne";
            customer2.Address = "Kıyık Street";

            manager.CustomerAdd(customer2);

            customer3.Id = 3;
            customer3.Name = "fuat";
            customer3.Surname = "mutlu";
            customer3.Email = "fuatmutlu@gmail.com";
            customer3.Country = "Turkey";
            customer3.City = "Edirne";
            customer3.Address = "101. Street";

            manager.CustomerAdd(customer3);

            customer4.Id = 4;
            customer4.Name = "mürvet";
            customer4.Surname = "mutlu";
            customer4.Email = "mürevetmutlu@gmail.com";
            customer4.Country = "Turkey";
            customer4.City = "Edirne";
            customer4.Address = "50. Street";

            manager.CustomerAdd(customer4);

            manager.CustormerView();

            manager.CustomerRemove(customer2);

            manager.CustormerView();

            manager.CustumerUpdate(customer1, "Ahmet", "Yavuz", "ahmetyavuz234@gmail.com", "Almanya", "Berlin", "40.Street");

            manager.CustormerView();
        }
    }
}
