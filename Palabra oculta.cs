
class Frase_Oculta
{
    static void Main()
    {
        
        string[] palabras = { "el gato  juega en el jardin" };
        Random generador = new Random();
        int numeroAzar = generador.Next(0, palabras.Length);
        string palabraAdivinar = palabras[numeroAzar];

        string palabraMostrar = "";
        for (int i = 0; i < palabraAdivinar.Length; i++)
            if (palabraAdivinar[i] == ' ')
                palabraMostrar += " ";
            else
                palabraMostrar += "-";

       
        int fallosRestantes = 10;
        char letraActual;
        bool terminado = false;

        
        do
        {
            
            Console.WriteLine("Palabra oculta(pista): El_______ juega____ el____  " );
            Console.WriteLine("Palabra oculta:  " + palabraMostrar);
            Console.WriteLine("Fallos restantes: " + fallosRestantes);

            Console.Write("Introduzca una letra: ");
            letraActual = Convert.ToChar(Console.ReadLine());

           
            if (!palabraAdivinar.Contains(letraActual))
            {
                fallosRestantes--;
                MostrarHorca(fallosRestantes);
            }

            
            string siguienteMostrar = "";

            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                if (letraActual == palabraAdivinar[i])
                    siguienteMostrar += letraActual;
                else
                    siguienteMostrar += palabraMostrar[i];
            }
            palabraMostrar = siguienteMostrar;

            
            if ( ! palabraMostrar.Contains("-"))
            {
                Console.WriteLine("Felicidades, acertaste!  ({0})",
                    palabraAdivinar);
                terminado = true;
            }
            else if (fallosRestantes == 0)
            {
                Console.WriteLine("Lo siento. Era " + palabraAdivinar);
                terminado = true;
            }

            Console.WriteLine();

        }
        while (!terminado);
    }

    static void MostrarHorca(int fallosRestantes)
    {
        switch (fallosRestantes)
        {
            case 7:
                Console.WriteLine("-");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 6:
                Console.WriteLine("-------");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 5:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 4:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 3:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 2:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 1:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / ");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
            case 0:
                Console.WriteLine("-------");
                Console.WriteLine("|    |");
                Console.WriteLine("|    O");
                Console.WriteLine("|   /|\\");
                Console.WriteLine("|   / \\");
                Console.WriteLine("|");
                Console.WriteLine("----");
                break;
        }
    }
}
