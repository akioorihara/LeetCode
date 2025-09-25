using System.Text;



var sb = new StringBuilder();
sb.Append("Hello World!");

//Console.WriteLine(sb);

for(int i = 0; i < 100; i++)
{
    sb.Append($"Line {i} : \n");
}

Console.WriteLine(sb);