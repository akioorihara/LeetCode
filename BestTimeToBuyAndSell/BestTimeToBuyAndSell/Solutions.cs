public class Solutions
{


    /// <summary>
    /// 
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public int MaxProfix(int[] prices)
    {

        int nextIndex = 1;
        int profit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            if (prices[i] < prices[nextIndex])
            {
                profit += prices[nextIndex] - prices[i];
            }
            nextIndex++;
        }
        return profit;
    } 





}