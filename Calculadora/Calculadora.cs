public class Calculadora
{
    public double Somar(double a, double b) => a + b;

    public double Subtrair(double a, double b) => a - b;

    public double Multiplicar(double a, double b) => a * b;

    public double Dividir(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Não é possível dividir por zero.");
        return a / b;
    }
}
