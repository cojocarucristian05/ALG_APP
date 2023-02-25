namespace GasescUnNumeCandva.Scripts;

public class SignMagnitude
{
    private int number_type;
    private int format_type;
    private int nr1, nr2;
    private int count = 0;
    //private Functions _functions;

    public SignMagnitude(int nr1, int nr2, int numberType, int formatType)
    {
        this.nr1 = nr1;
        this.nr2 = nr2;
        this.number_type = numberType;
        this.format_type = formatType;
    }
    
    public String Calculate()
    {
        int[] A = new int[10];
        int[] Q = new int[10];
        int[] M = new int[10];
        if (format_type == 1)
        {   
            A = Functions.MakeArray(nr2);
            //Console.WriteLine(A);
            Q = Functions.MakeArray(nr1);
            //Console.WriteLine(A);
            M = Functions.MakeArray(nr2);
            //Console.WriteLine(A);
        }
        else 
        {
            A = Functions.ConvertToBinary(nr2);
            Q = Functions.ConvertToBinary(nr1);
            M = Functions.ConvertToBinary(nr2);
        }
        
        while (count < Q.Length - 1)
        {
            if (Q[Q.Length - 1] == 1)
            {
                Functions.Add(A, M);
            }
            
            Functions.Rshift(A, Q);
            A[0] = 0;
            count++;
        }
        
        int aux1 = Q[Q.Length-1];
        int aux2 = M[0];

        if (number_type == 1)
        {
            Functions.Rshift(A, Q);
        }
        else
        {
            Q[Q.Length - 1] = 0;
        }
        
        if((aux1 == 0 && aux2 == 0) || (aux1 == 1 && aux2 == 1)) {
            A[0] = 0;
        } else {
            A[0] = 1;
        }
        
        return Functions.Afiseaza(A, Q, M);
    }
}