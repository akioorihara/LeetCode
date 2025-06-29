

using System.Security.Cryptography.X509Certificates;

public class Reverse
{

    public int ReverseInteger(int x)
    {

        //Outside of the 32-bit         
        if (x >= int.MaxValue || x <= int.MinValue)
            return 0;

        bool isNegative = x < 0;

        //reverse the int by casting the string array
        string str = Math.Abs((long)x).ToString();
        string reversed = new string (str.Reverse().ToArray());

        try
        {
            Int32.TryParse(reversed, out x);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        if (isNegative)
        {
            Console.WriteLine(-x);
            return -x;
        }
        else
        {
            Console.WriteLine(x);
            return x;
        }
    }






}

