class Program 
{
    static void Main(string[] args)
    {
        int contador = 7;

        while (contador >= 1)
        {
            if (contador % 2 == 0)
            {
                Piano.ReproduzTecla(4, contador);
            }
            contador--;
        }
    }
}