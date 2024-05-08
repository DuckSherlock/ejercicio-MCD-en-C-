using System;

public class CalculadoraMCD
{
    // Método para calcular el MCD de dos números utilizando el algoritmo de Euclides
    private int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Método para calcular el MCD de cuatro números
    public int MCDDeCuatroNumeros(int a, int b, int c, int d)
    {
        int mcdAB = MCD(a, b);
        int mcdCD = MCD(c, d);
        return MCD(mcdAB, mcdCD);
    }
}

