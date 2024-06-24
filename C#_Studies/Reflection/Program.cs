using Reflection;
using System.Reflection;

//Maths maths = new Maths(2, 3);

//Console.WriteLine(maths.Add2());
//Console.WriteLine(maths.Add(3, 4));

var type = typeof(Maths);

//Maths maths = (Maths)Activator.CreateInstance(type, 6, 7); 

//Console.WriteLine(maths.Add(4, 5));
//Console.WriteLine(maths.Add2());

var instance = Activator.CreateInstance(type, 4,5); //**Activator.CreateInstance obje döndürür

MethodInfo methodInfo = instance.GetType().GetMethod("Add2");

Console.WriteLine(methodInfo.Invoke(instance, null));

Console.WriteLine("---------------------------------");

var methods = type.GetMethods();

foreach (var method in methods)
{
    Console.WriteLine("Method Name: " + method.Name);
}

Console.ReadLine();

