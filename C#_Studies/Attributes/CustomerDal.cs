using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes;

public class CustomerDal
{
    [Obsolete("Do not use Add, instead use AddNew method")] //Hazır attribute
    public void Add(Customer customer)
    {
        Console.WriteLine(
            "Id:" + customer.Id + " " + customer.FirstName + " " + customer.LastName + " age:" + customer.Age);
    }

    public void AddNew(Customer customer)
    {
        Console.WriteLine(
            "Id:" + customer.Id + ", " + customer.FirstName + " " + customer.LastName + " age:" + customer.Age);
    }


}
