namespace Rhbyte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario kleber = new Funcionario("Kleber", 29);
            kleber.Cargo();

            Diretor ze = new Diretor("ze", 36);
            ze.Cargo();
        }
    }
}