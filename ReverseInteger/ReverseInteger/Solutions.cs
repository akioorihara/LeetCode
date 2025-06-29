using System.Text;

public class Solutions
{
    public int Reverse(int x)
    {

        //
        var nums = x.ToString();
        int size = nums.Length;
        int[] ints = new int[size];
        List<string> strings = new List<string>();

        //Keep track of negative values 
        bool isNegative = false;
        if (x < 0)
        {
            isNegative = true;
        }

        //Loop through to create reversed vals 
        foreach (var each in nums.Reverse())
        {
            // Console.WriteLine(each);
            strings.Add(each.ToString());
        }

        // Console.WriteLine(string.Join("," ,strings));
        try
        {
            Int32.TryParse(strings.ToString(), out x);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        if (isNegative)
        {
            //TODO - negate the value 
        }


        return 0;
    }

}

