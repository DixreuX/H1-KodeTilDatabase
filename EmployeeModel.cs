using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class EmployeeModel : Person
    {
        // Medarbejder oplysninger til database

        int employee_ID;
        int employee_ZipCode;
        int employee_PhoneNumber;

        string employee_Street;
        string employee_StreetNumber;
        string employee_City;
        string employee_Name;
        string employee_Email;
        string employee_ContactPerson;
    }
}
