public class Solutions()
{

    public string GcdofString(string str1, string str2) {

        if ((str1 + str2) != (str2 + str1)){
            return "";
        }

        int len = getLength(str1, str2);

        return str1.Substring(0, len);
    }



    private int getLength(string x, string y)
    {

        int len = x.Length > y.Length ? x.Length : y.Length;

        if (len <= 0)
        {
            return 0;
        }
        return len;

    }

}
