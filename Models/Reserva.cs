namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            // Verifica se a lista de hóspedes é nula, e atribui uma lista vazia caso seja
            Hospedes = Hospedes ?? new List<Pessoa>();

            // Adiciona os elementos da lista de hóspedes à propriedade Hospedes da classe
            Hospedes.AddRange(hospedes);

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
        // *IMPLEMENTE AQUI*
        public int ObterQuantidadeHospedes() => Hospedes.Count;


        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor *= 0.9m;
            }
            return valor;

        }
    }
}