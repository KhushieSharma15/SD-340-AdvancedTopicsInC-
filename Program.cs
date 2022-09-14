using System.Text;

public class Program
{
    public delegate string DelegateFunction(string word, int num);
     
    public static void Main()
    {
        DelegateFunction concatWord = new DelegateFunction(ConcateWord);
        string concatenatedWord = concatWord("Khushi", 5);
        Console.WriteLine(concatenatedWord);

        DelegateFunction removeLetterFromEnd = new DelegateFunction(RemoveLetterFromEnd);
        string removedLetterWord = removeLetterFromEnd("KhushiSharma", 5);
        Console.WriteLine(removedLetterWord);
    }

    public static string ConcateWord(string word, int times)
    {
        StringBuilder sb = new StringBuilder();

        for(var i=0; i<times; i++)
        {
            sb.Append(word);
        }

        return sb.ToString();
    }

    public static string RemoveLetterFromEnd(string word, int times)
    {
        return word.Substring(0, word.Length - times);
    }
}