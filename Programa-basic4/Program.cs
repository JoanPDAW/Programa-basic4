namespace Programa_basic4;

class Program
{
    static void Main(string[] args)
    {
        // Entrada de dades
        var llista = new[]  {1, 5, 4, 6, 2};
        // Prsentacio de dades
        Console.WriteLine("Entrada:");
        Console.Write("[");
        var coma = 1;
        var impri = "";
        for (int numero = 0; numero < llista.Length; numero++)
        {
            if ( coma < llista.Length )
            {
                impri = ",";
            }
            else
            {
                impri = "";
                
            }
            Console.Write($"{llista[numero]}{impri}");
            coma++;
        }
        Console.Write("]");
        
        // Calcula el segon numero mes gram numero

        var mesGran = trobaElMesGran(llista);
        var segonMesGran = trobaElSegonMesGran(llista); 
            
        //Sortida
        Console.WriteLine($"\n\nSortida: (El més gran és el {mesGran}, per tant, el {segonMesGran})");
        Console.WriteLine($"{segonMesGran}");
        
        
        Console.WriteLine("\n\nFi.");
    }

    public static int trobaElMesGran(int[] llista)
    {
        var numeroGran = 0;
        for (int numero = 0; numero < llista.Length-1; numero++)
        {
            if (llista[numero] > llista[numero+1])
            {
                numeroGran = llista[numero];
            }
            else
            {
                numeroGran = llista[numero + 1];
            }
        }
        return numeroGran;
    }

    public static int trobaElSegonMesGran(int[] llista)
    {
        var elMesGran = trobaElMesGran(llista);
        var numeroGran = 0;
        for (int numero = 0; numero < llista.Length-1; numero++)
        {
            if (elMesGran != llista[numero] && elMesGran != llista[numero+1])
            {
                if (llista[numero] > llista[numero + 1])
                {
                    numeroGran = llista[numero];
                }
                else
                {
                    numeroGran = llista[numero + 1];
                }
            }
        }
        
        return numeroGran;
    }
}