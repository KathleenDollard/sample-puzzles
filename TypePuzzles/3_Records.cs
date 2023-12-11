using System.Runtime.CompilerServices;
using System.Text;

namespace IntrinsicTypeTests;

// This puzzle is a bit different. Copy this code into 
// https://sharplab.io/ and look at "Decompile/C#" on
// the right to see what code is emitted

// Explore different IL for different approaches to this simple type

public class Person
{
    public string SurName { get; set; }
    public string GivenName { get; set; }
}

// Add a default value to quiet the nullable warning
public class Person2
{
    public string SurName { get; set; } = string.Empty;
    public string GivenName { get; set; } = string.Empty;
}

// Then see what happens with the primary constructor
public class Person3(string surName, string givenName)
{
    public string SurName { get; set; } = surName;
    public string GivenName { get; set; } = givenName;
}

// Then, do all the above adding the `record` modifier 

// Also, play with `with`

public record class Person4
{
    public string SurName { get; set; } = String.Empty;
    public string GivenName { get; set; } = String.Empty;

    public Person4 F()
    {
        var PersonA = new Person4 { GivenName = "Mads", SurName = "K" };
        var PersonB = PersonA with { SurName = "T" };
        return PersonB;
    }

}
