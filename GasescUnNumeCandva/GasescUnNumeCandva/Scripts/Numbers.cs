namespace GasescUnNumeCandva.Scripts;

public class Numbers
{
    private int[] x, y;
    private string x_in, y_in;

    public Numbers(string xin, string yin)
    {
        x_in = xin;
        y_in = yin;
    }

    private int[] MakeArray1(int nr)
    {   
        int[] array = new int[10];
        int size = 0;

        while (nr != 0)
        {
            if (size == array.Length)
            {
                int[] aux2 = new int[array.Length * 2];
                for (int i = 0; i < size; i++)
                {
                    aux2[i] = array[i];
                }

                array = aux2;
            }
            
            array[size++] = Int32.Abs(nr%2);
            nr = nr / 2;
        }

        return array;
    }
    
    private int[] MakeArray2(int nr)
    {   
        int[] array = new int[10];
        int size = 0;

        while (nr != 0)
        {
            if (size == array.Length)
            {
                int[] aux2 = new int[array.Length * 2];
                for (int i = 0; i < size; i++)
                {
                    aux2[i] = array[i];
                }

                array = aux2;
            }

            array[size++] = nr % 10;
            nr = nr / 10;
        }

        return array;
    }

    public (int[], int[]) Transform(int selectie)
    {
        int nr1, nr2;
        
        int[] aux1 = new int[10];
        int[] aux2 = new int[10];
        
        int[] array1 = new int[10];
        int[] array2 = new int[10];
        
        int size1 = 0, size2 = 0;
        
        if (selectie == 1)
        {
            nr1 = Int32.Parse(x_in);
            nr2 = Int32.Parse(y_in);
            aux1 = MakeArray1(nr1);
            aux2 = MakeArray1(nr2);
            size1 = aux1.Length;
            size2 = aux2.Length;

            if (nr1 >= 0)
            {
                array1[0] = 0; 
            }
            else
            {
                array1[0] = 1;
            }
            
            if (nr2 >= 0)
            {
                array2[0] = 0; 
            }
            else
            {
                array2[0] = 1;
            }

            for (int i = size1 - 1; i >= 0; i--)
            {
                array1[size1 - i] = aux1[i];
            }
            
            for (int i = size2 - 1; i >= 0; i--)
            {
                array2[size2 - i] = aux2[i];
            }
            
            return (array1, array1);
        }

        if (selectie == 2)
        {
            
            nr1 = Int32.Parse(x_in);
            nr2 = Int32.Parse(y_in);
            aux1 = MakeArray2(nr1);
            aux2 = MakeArray2(nr2);
            size1 = aux1.Length;
            size2 = aux2.Length;

            if (nr1 >= 0)
            {
                array1[0] = 0; 
            }
            else
            {
                array1[0] = 1;
            }
            
            if (nr2 >= 0)
            {
                array2[0] = 0; 
            }
            else
            {
                array2[0] = 1;
            }

            for (int i = size1 - 1; i >= 0; i--)
            {
                array1[size1 - i] = aux1[i];
            }
            
            for (int i = size2 - 1; i >= 0; i--)
            {
                array2[size2 - i] = aux2[i];
            }
            
            return (array1, array1);
        }

        return (null, null);
    }
    
}