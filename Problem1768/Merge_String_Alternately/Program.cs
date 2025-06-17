var word1 = "ab";
var word2 = "pqrs";

int word_len = word1.Length > word2.Length ? word1.Length : word2.Length;

var result = new System.Text.StringBuilder();
int i = 0, j = 0;

while (i < word1.Length && j < word2.Length)
{
    result.Append(word1[i++]);
    result.Append(word2[j++]);
}

if (i < word1.Length)
    result.Append(word1.Substring(i));
if (j < word2.Length)
    result.Append(word2.Substring(j));

// need to return as string()

Console.WriteLine(result);