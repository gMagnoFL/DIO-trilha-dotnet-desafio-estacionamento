namespace DesafioFundamentos.Models
{
  public class Estacionamento
  {
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
      this.precoInicial = precoInicial;
      this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
      try
      {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        veiculos.Add(Console.ReadLine());
        Console.WriteLine("Veículo cadastrado com sucesso!");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public void RemoverVeiculo()
    {
      int horas = 0;
      // Pedir para o usuário digitar a placa e armazenar na variável placa
      Console.WriteLine("Digite a placa do veículo para remover:");
      string placa = Console.ReadLine();
      // Verifica se o veículo existe
      if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
      {
        while (true)
        {
          Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

          /*verifica se foi digitada uma hora válida.
          Se sim, atribui à variável horas;
          se não, exibe mensagem de erro e solicita uma hora válida*/
          if (int.TryParse(Console.ReadLine(), out horas))
          {
            // calcula o preço a ser pago
            decimal valorTotal = precoInicial + (precoPorHora * horas);
            // remove o carro da lista de veículos
            veiculos.Remove(placa);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:c2}");
            break;
          }
          Console.WriteLine("Erro! A hora deve ser um número inteiro");
        }
      }
      else
      {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
      }
    }

    public void ListarVeiculos()
    {
      // Verifica se há veículos no estacionamento
      if (veiculos.Any())
      {
        // lista os veiculos no estacionamento
        Console.WriteLine("Os veículos estacionados são:");
        foreach (string placa in veiculos)
        {
          Console.WriteLine(placa);
        }
      }
      else
      {
        Console.WriteLine("Não há veículos estacionados.");
      }
    }
  }
}
