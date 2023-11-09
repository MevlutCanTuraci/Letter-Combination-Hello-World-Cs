Console.Title = "Letter Combination Hello World";

Console.WriteLine("Text to print;");
string targetText = Console.ReadLine()!;

Console.Clear();

char[] alpha = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZabcçdefgğhıijklmnoöpqrşstuüvwxyz ".ToCharArray();

string lastText = string.Empty;

for (int i = 0; i < targetText.Length; i++)
{
    char targetChar = targetText[i];

    if (char.IsLower(targetChar) && alpha[0] == 'A')
    {
        alpha = alpha.Reverse().ToArray();
    }
    else if (char.IsUpper(targetChar) && alpha[0] == ' ')
    {
        alpha = alpha.Reverse().ToArray();
    }

    foreach (var j in alpha)
    {
        Console.WriteLine(string.Concat(lastText, j));
        if (j == targetChar)
        {
            lastText += j;
            break;
        }

        await Task.Delay(13);
    }

    continue;
}

Console.WriteLine(new string('\n', 3));

Console.Read();