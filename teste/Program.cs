using System;
using System.Globalization;

namespace teste {
    class Program {
        static void Main(string[] args) {

            double largura, comprimento, PrecoMetro, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PrecoMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * PrecoMetro;

            Console.WriteLine("Área: "+ area);
            Console.WriteLine("Preço: "+ PrecoMetro);

        }
    }
}
