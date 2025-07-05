
/// <summary>
/// 
/// </summary>
public class Solutions
{


    /// <summary>
    /// 
    /// </summary>
    /// <param name="board"></param>
    /// <returns></returns>
    public bool isValidSudoku(char[][] board)
    {
        // each row must contain the digits 1-9 without repetition 
        int size = board.Length;

        int rowCount = 0;
        for (int i = 0; i < size; i++)
        {

            for (int j = 0; j < board.Length; j++)
            {
                
            }


            Dictionary<char, int> dict = new Dictionary<char, int>();
            if (dict.ContainsKey(board[i][rowCount]))
            {


            }
            else
            {

            }
            rowCount++;
        }    




        return false;
    }


 

}