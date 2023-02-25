namespace GasescUnNumeCandva.Scripts;

public class Functions
{
    public static int[] ConvertToBinary(int nr)
    {
        int[] array;
        int[] aux = new int[2];
        int size = 0;

        while (nr != 0)
        {
            if (size == aux.Length)
            {
                Console.WriteLine("Am marit dimensiunea!");
                int[] aux2 = new int[aux.Length * 2];
                for (int i = 0; i < size; i++)
                {
                    aux2[i] = aux[i];
                }

                aux = aux2;
            }

            aux[size++] = Int32.Abs(nr % 2);
            nr = nr / 2;
        }

        array = new int[size+1];
        if (nr >= 0)
        {
            array[0] = 0;
        }
        else
        {
            array[0] = 1;
        }

        for (int i = size - 1; i >= 0; i--)
        {
            array[size - i] = aux[i];
        }
        
        Console.WriteLine("binary number: " + array);
        
        return array;
    }
    
    public static int[] MakeArray(int nr)
    {   
        int[] array = new int[2];
        int size = 0;

        while (nr != 0)
        {
            if (size == array.Length)
            {
                int[] aux = new int[array.Length * 2];
                for (int i = 0; i < size; i++)
                {
                    aux[i] = array[i];
                }

                array = aux;
            }

            array[size++] = nr % 10;
            nr = nr / 10;
        }

        return array;
    }

    public static void Rshift(int[] A, int[] Q)
    {
        for(int i = Q.Length - 1; i > 0; i--) {
            Q[i] = Q[i-1];
        }
        Q[0] = A[A.Length-1];
        for (int i = A.Length - 1; i > 0; i--)
        {
            A[i] = A[i - 1];
        }
        
    }

    public static void Add(int[] A, int[] M)
    {
        int aux = 0;
        int c_in = 0;
        for(int i = A.Length-1; i > 0; i--) {
            aux = (A[i] + M[i] + c_in);
            A[i] = aux%2;
            if(aux >= 2) {
                c_in = 1;
            } else {
                c_in = 0;
            }
        }
        A[0] = c_in;
    }

    public static String Afiseaza(int[] A, int[] Q, int[] M)
    {
        String str = "";
        //"A\t\t\tQ\t\t\tM\n";
        for (int i = 0; i < A.Length; i++)
        {
            str += A[i];
        }
        str += "\t\t\t";
        for (int i = 0; i < Q.Length; i++)
        {
            str += Q[i];
        }
        /*
         * Console.Out.Write("\t\t\t");
        for (int i = 0; i < M.Length; i++)
        {
            str += M[i];
        }

         */
        return str;
    }
}