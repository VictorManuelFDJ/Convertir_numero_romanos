namespace Convertir_numero_romanos
{
    public class ConvertirNumeroRomanos
    {
        private static int valorRomanos(char simbolo)
        {
            switch (simbolo)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;

            }
        }

        public static int ConvertirADecimales(string numeroRomano) {
            int resultado = 0;
            for(int i = 0; i < numeroRomano.Length; i++) { 
                int valorActual = valorRomanos(numeroRomano[i]);

                if (i + 1 < numeroRomano.Length)
                {
                    int valorSiguiente = valorRomanos(numeroRomano[i + 1]);

                    if (valorActual < valorSiguiente)
                    {
                        resultado -= valorActual;
                    }
                    else
                    {
                        resultado += valorActual;
                    }
                }
                else
                {
                    resultado += valorActual;
                }
            }
            return resultado;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número romano:");

            string numRomano = Console.ReadLine().ToUpper();

            int numDecimal = ConvertirADecimales(numRomano);

            Console.WriteLine($"El número Romano {numRomano} en decimal es: {numDecimal}");
        }
    }
}