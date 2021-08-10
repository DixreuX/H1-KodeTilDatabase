using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class CustomerModel : Person
    {
        // Kundeoplysninger til database

        int customer_ID;
        int customer_ZipCode;
        int customer_CVRNumber;
        int customer_PhoneNumber;
        
        string customer_Street;
        string customer_StreetNumber;
        string customer_City;
        string customer_Name;
        string customer_Email;
        string customer_ContactPerson;
    }
}
