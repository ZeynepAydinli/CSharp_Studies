using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Reference_Type;

public class PersonManager
{
    public void Add(BasePerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}
