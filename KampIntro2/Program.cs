internal class Program
{
    static void Main(string[] args)
    {
        int[] myArray = new int[2];
        myArray[0] = 6;
        myArray[1] = 7;
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

        string[] languages = new string[] { "Java", "C#", "Python" };
        foreach (string language in languages) 
        {
            Console.WriteLine(language);
        }
    }
}