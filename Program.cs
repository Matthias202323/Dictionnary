namespace Dictionnary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,string> Dictionary = new Dictionary<char, string>();
            Dictionary['a'] = "aka";
            Dictionary['b'] = "bouloulou";
            Dictionary['c'] = "calafacarate";
            Dictionary.Remove('c');

        }
    }
}
