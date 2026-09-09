using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
public class Craps
{
    private Random numerosAleatorios = new Random();
    private enum NombreDados
    {
        DOS_UNO = 2,
        TRES = 3,
        SIETE = 7,
        ONCE = 11,
        DOCE = 12,
    }
    private enum Estado
    {
        CONTINUA,
        GANA,
        PIERDE
    }
    public void Jugar()
    {
        Estado estadoJuego = Estado.CONTINUA;
        int miPunto = 0;
        int sumaDeDados = LanzarDados();

        switch ((NombreDados)sumaDeDados)
        {
            case NombreDados.SIETE:
            case NombreDados.ONCE:
                estadoJuego = Estado.GANA;
                break;
            case NombreDados.DOS_UNO:
            case NombreDados.TRES:
            case NombreDados.DOCE:
                estadoJuego = Estado.PIERDE;
                break;
            default:
                estadoJuego = Estado.CONTINUA;
                miPunto = sumaDeDados;
                Console.WriteLine($"El punto es {miPunto}");
                break;
        }
        while (estadoJuego == Estado.CONTINUA)
        {
            sumaDeDados = LanzarDados();
            if (sumaDeDados == (int)NombreDados.SIETE)
                estadoJuego = Estado.PIERDE;
        }
        if (estadoJuego == Estado.GANA)
            Console.WriteLine("El jugador gana");
        else
            Console.WriteLine("El jugador pierde");
    }
    public int LanzarDados()
    {
        int dado1 = numerosAleatorios.Next(1, 7);
        int dado2 = numerosAleatorios.Next(1, 7);
        int suma  = dado1 + dado2;
        Console.WriteLine($"El jugador lanzó {dado1}+{dado2} = {suma}");
            return suma;
    }
}


