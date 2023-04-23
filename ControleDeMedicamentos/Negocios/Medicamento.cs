using ControleDeMedicamentos.Negocios.MeuProjeto;

namespace ControleDeMedicamentos.Negocios
{
    public class Medicamento
    {
        // Propriedades da classe Medicamento

        public int IdMedicamento { get; set; }  
        public string? NomeMedicamento { get; set; }
        public string? DescricaoMedicamento { get; set; }
        public int QuantidadeMedicamentoDisponivel { get; set; } = 0;
        public List<Requisicao> HistoricoDeRequisicoes { get; set; }
        public int QuantidadeDeRequisicoes { get; set; }
        public int QuantidadeLimiteMedicamento { get; set; }
        public Fornecedor FornecedorMedicamento { get; set; }

        public Medicamento(int idMedicamento, string nomeMedicamento, string descricaoMedicamento, int quantidadeMedicamentoDisponivel, List<Requisicao> historicoDeRequisicoes, int quantidadeDeRequisicoes, int quantidadeLimiteMedicamento, Fornecedor fornecedorMedicamento)
        {
            IdMedicamento = idMedicamento;
            NomeMedicamento = nomeMedicamento;
            DescricaoMedicamento = descricaoMedicamento;
            QuantidadeMedicamentoDisponivel = quantidadeMedicamentoDisponivel;
            HistoricoDeRequisicoes = historicoDeRequisicoes;
            QuantidadeDeRequisicoes = quantidadeDeRequisicoes;
            QuantidadeLimiteMedicamento = quantidadeLimiteMedicamento;
            FornecedorMedicamento = fornecedorMedicamento;
        }

        public void AdicionarRequisicao(Requisicao requisicao)
        {
            this.HistoricoDeRequisicoes.Add(requisicao);
            this.QuantidadeDeRequisicoes++;
        }

        public void AtualizarQuantidadeMedicamento(int quantidade)
        {
            this.QuantidadeMedicamentoDisponivel += quantidade;
        }

        public void AtualizarFornecedorMedicamento(Fornecedor fornecedor)
        {
            this.FornecedorMedicamento = fornecedor;
        }

        public void AtualizarQuantidadeLimiteMedicamento(int quantidadeLimite)
        {
            this.QuantidadeLimiteMedicamento = quantidadeLimite;
        }

        public void RemoverRequisicao(Requisicao requisicao)
        {
            this.HistoricoDeRequisicoes.Remove(requisicao);
            this.QuantidadeDeRequisicoes--;
        }

        // Método para verificar se o medicamento está em falta
        public bool EstaEmFalta()
        {
            return this.QuantidadeDeRequisicoes < this.QuantidadeLimiteMedicamento;
        }
    }
}




