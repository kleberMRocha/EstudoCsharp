using Humanizer;
namespace Rhbyte
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MostaLista("teste");
            MostaLista(5656);
            MostaLista(false);

        }
        public static void MostaLista<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}