
using InterfaceStudy.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IPerson sınıfı implement edilen sınıfları bilir. 

namespace InterfaceStudy
{
    public class PersonManager
    {
        public void Add(IPerson person) //Implement edilen sınıflar yazılır.   
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
        }
    }
}
