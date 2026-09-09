namespace Laboratorio3_Juego_de_Craps
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de Craps!\n");
            Craps juego = new Craps();
            juego.Jugar();
        }
    }
}
