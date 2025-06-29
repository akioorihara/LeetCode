using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;

public class Solutions
{
    public int Reverse(int x)
    {

        bool isNegative = x < 0;
        string str = Math.Abs((long)x).ToString();

        string reversedStr = new string(str.Reverse().ToArray());

        if (long.TryParse(reversedStr, out long reversed))
        {
            if (reversed > int.MaxValue)
                return 0;
            return isNegative ? (int)-reversed : (int)reversed;

            // return isNegative ? -reversed : reversed;
        }
        else
        {
            return 0;
        }

    }

}

