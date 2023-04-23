using ControleDeMedicamentos.Negocios.MeuProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.Negocios
{
    public class Medicamento
    {
        // Propriedades da classe Medicamento

        public int IdMedicamento { get; set; }  
        public string? NomeMedicamento { get; set; }
        public string? DescricaoMedicamento { get; set; }
        public int QuantidadeMedicamentoDisponivel { get; set; }
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
            HistoricoDeRequisicoes.Add(requisicao);
            QuantidadeDeRequisicoes++;
        }

        public void AtualizarQuantidadeMedicamento(int quantidade)
        {
            QuantidadeMedicamentoDisponivel += quantidade;
        }

        public void AtualizarFornecedorMedicamento(Fornecedor fornecedor)
        {
            FornecedorMedicamento = fornecedor;
        }

        public void AtualizarQuantidadeLimiteMedicamento(int quantidadeLimite)
        {
            QuantidadeLimiteMedicamento = quantidadeLimite;
        }

        public void RemoverRequisicao(Requisicao requisicao)
        {
            HistoricoDeRequisicoes.Remove(requisicao);
            QuantidadeDeRequisicoes--;
        }

        // Método para verificar se o medicamento está em falta
        public bool EstaEmFalta()
        {
            return QuantidadeDeRequisicoes < QuantidadeLimiteMedicamento;
        }
    }
}




