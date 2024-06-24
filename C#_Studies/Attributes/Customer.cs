using Attributes.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes;

[ToTable("Customers")]
[ToTable("Users")]
public class Customer
{
    public int Id { get; set; }
    [RequiredProperty] //FirstName girmek zorunludur
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


}
