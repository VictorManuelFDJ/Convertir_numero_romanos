namespace Convertir_numero_romanos
{
    public class ConvertirNumeroRomanos
    {
        private static int ValorRomano(char simbolo)
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
                int valorActual = ValorRomano(numeroRomano[i]);

                if (i + 1 < numeroRomano.Length)
                {
                    int valorSiguiente = (numeroRomano[i + 1]);

                    if (valorActual < valorSiguiente)
                    {
                        resultado -= valorActual;

                    }
                    else { 
                        resultado += valorActual;
                    }
                }
            }
            return resultado;
        }


        static void Main(string[] args)
        {
            string numeroRomano1 = "III";
            int decimal1 = ConvertirADecimales(numeroRomano1);
            Console.WriteLine($"El número romano {numeroRomano1} es {decimal1} en decimal.");
        }
    }
}