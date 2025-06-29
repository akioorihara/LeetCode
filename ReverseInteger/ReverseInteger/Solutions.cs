using System.Net.Mail;
using System.Reflection.Metadata;
using System.Text;

public class Solutions
{
    public int Reverse(int x)
    {

        bool isNegative = x < 0;
        string str = Math.Abs((long)x).ToString();

        string rev = new string(str.Reverse().ToArray());

        if (long.TryParse(rev, out long reversed))
        {
            if (isNegative)
                reversed = -reversed;

            if (reversed < int.MinValue || reversed > int.MaxValue)
                return 0;

            return (int)reversed;
        }
        else
        {
            return 0;
        }


    }

}

