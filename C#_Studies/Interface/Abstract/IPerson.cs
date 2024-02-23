using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface public yapılınca içindeki metotların public yazılmasına gerek yoktur. 

namespace InterfaceStudy.Abstract
{
    public interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
}
