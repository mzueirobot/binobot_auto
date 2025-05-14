
using System;
using System.Threading;

namespace BinobotAuto
{
    public class Bot
    {
        public double Capital { get; set; } = 1000;  // Capital inicial para compras
        public double ValorCompra { get; set; } = 50;  // Valor de cada compra (em moeda)
        public double PrecoCompra { get; set; } = 50;  // Preço de compra atual (simulado)
        public double PrecoVenda { get; set; } = 60;  // Preço de venda (simulado)
        
        public void Start()
        {
            Console.WriteLine("Bot iniciado...");
            MonitorarMercado();
        }

        // Método para monitorar o mercado e realizar compras e vendas
        public void MonitorarMercado()
        {
            Random rand = new Random();

            while (true)
            {
                // Simula variação de preços
                PrecoCompra += rand.NextDouble() * 2 - 1;  // Alteração aleatória de preço entre -1 e +1
                PrecoVenda += rand.NextDouble() * 2 - 1;   // Alteração aleatória de preço entre -1 e +1

                // Lógica de compra
                if (PrecoCompra < 50)
                {
                    Comprar();
                }

                // Lógica de venda
                if (PrecoVenda > 60)
                {
                    Vender();
                }

                // Exibe as atualizações no console
                Console.WriteLine($"Preço de Compra: {PrecoCompra:C} | Preço de Venda: {PrecoVenda:C} | Capital: {Capital:C}");

                Thread.Sleep(5000);  // Simula a execução de cada operação a cada 5 segundos
            }
        }

        public void Comprar()
        {
            if (Capital >= ValorCompra)
            {
                Capital -= ValorCompra;
                Console.WriteLine($"Comprado {ValorCompra} unidades a {PrecoCompra:C}. Capital restante: {Capital:C}");
            }
            else
            {
                Console.WriteLine("Capital insuficiente para realizar a compra.");
            }
        }

        public void Vender()
        {
            Capital += ValorCompra * PrecoVenda / PrecoCompra;
            Console.WriteLine($"Vendido {ValorCompra} unidades a {PrecoVenda:C}. Novo Capital: {Capital:C}");
        }
    }
}
