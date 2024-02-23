using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] // AllowMuştiple birden fazla kullanıma izin verir
// [AttributeUsage(AttributeTargets.Class)] *** Sadece class'lara eklenir 
// [AttributeUsage(AttributeTargets.All)] *** Her yerde kullanılır
// AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)] *** Hem property hem de field kullanılabilir

public class RequiredPropertyAttribute : Attribute
{

}
