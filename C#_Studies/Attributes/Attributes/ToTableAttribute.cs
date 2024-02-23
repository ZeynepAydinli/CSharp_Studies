using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ToTableAttribute : Attribute
{
    private string v; // ToTable üstüne gelip otomatik kendi yazar

    public ToTableAttribute(string v)
    {
        this.v = v;
    }
}
