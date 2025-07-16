
/// <summary>
/// Converts a string to a 32-integer assigned integer  
/// </summary>
public class Solutions
{

    /// <summary>
    /// Convert a string to a int  
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public int MyAtoi(string s)
    {
        List<int> ints = new List<int>();

        foreach (var e in s)
        {
            try
            {
                if (Int32.TryParse(e.ToString(), out int result))
                {
                    ints.Add(result);
                }

                //fails - skip and 


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        var x = ints.ToString();
        Int32.TryParse(x, out int final);

        //if contains a negative value, returns a negative 
        return s.Contains('-') ? -1 : 0;

    }



}