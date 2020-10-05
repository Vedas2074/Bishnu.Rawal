using System;
using AccessModifierAndMethods;

class Program
{
    static void Main2342()
    {        
        AccessModifier accessModifier = new AccessModifier();
        accessModifier.DoSomething();

        Person person = new Person();
        person.Name = "Bishnu";
        person.Age = 179;

        var x = person.Address;
    }
}
