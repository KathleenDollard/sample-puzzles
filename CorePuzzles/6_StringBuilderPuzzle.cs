namespace IntrinsicTypeTests;

// This puzzle is a bit different. Copy this code into 
// https://sharplab.io/ and look at "Decompile/C#" on
// the right to see what code is emitted


// DateTime.Hour.ToString() is used to create a string that
// will not be optimized away. 
public class C
{
    public void M()
    {

        // This does not need StringBuilder, compiler does the concat
        var x = "1" + "2" + "3";

        // This does not need StringBuilder, single concat
        var y = DateTime.Now.Hour.ToString() +
                DateTime.Now.Hour.ToString() +
                DateTime.Now.Hour.ToString();

        // This could benefit from StringBuilder
        var z = DateTime.Now.Hour.ToString();
        z += DateTime.Now.Hour.ToString();
        z += DateTime.Now.Hour.ToString();

    }
}