namespace JCD1._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso
            double a = 1;
            double b = -3;
            double c = 2;

            double result = QuadraticEquationNeg(a, b, c);

            if (!double.IsNaN(result))
            {
                Console.WriteLine("A raiz negativa da equação quadrática é: " + result);
            }
            else
            {
                Console.WriteLine("A equação quadrática não possui raízes reais negativas.");
            }
        }

        static double QuadraticEquationNeg(double a, double b, double c)
        {
            // Calcula o discriminante
            double discriminant = b * b - 4 * a * c;

            // Verifica se a equação tem raízes reais
            if (discriminant < 0)
            {
                // Retorna um valor especial (por exemplo, NaN) para indicar que não há raízes reais negativas
                return double.NaN;
            }

            // Calcula as raízes
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            // Retorna a raiz negativa (a que possui sinal negativo)
            return (root1 < root2) ? root1 : root2;
        }
    }
}