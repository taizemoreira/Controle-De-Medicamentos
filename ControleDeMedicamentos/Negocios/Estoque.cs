using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeMedicamentos.Negocios.MeuProjeto;

namespace ControleDeMedicamentos.Negocios
{
    public class Estoque
    {
        private List<Medicamento> medicamentos { get; set; }

        public Estoque(List<Medicamento> listaMedicamentos)
        {
            medicamentos = listaMedicamentos;
        }

        public void AdicionarMedicamento(Medicamento medicamento)
        {
            medicamentos.Add(medicamento);
        }

        public void AtualizarMedicamento(Medicamento medicamento)
        {
            Medicamento medicamentoAtualizar = medicamentos.FirstOrDefault(med => med.NomeMedicamento == medicamento.NomeMedicamento);
            if (medicamentoAtualizar != null)
            {
                medicamentoAtualizar.DescricaoMedicamento = medicamento.DescricaoMedicamento;
                medicamentoAtualizar.QuantidadeMedicamentoDisponivel = medicamento.QuantidadeMedicamentoDisponivel;
                medicamentoAtualizar.HistoricoDeRequisicoes = medicamento.HistoricoDeRequisicoes;
                medicamentoAtualizar.QuantidadeDeRequisicoes = medicamento.QuantidadeDeRequisicoes;
                medicamentoAtualizar.QuantidadeLimiteMedicamento = medicamento.QuantidadeLimiteMedicamento;
                medicamentoAtualizar.FornecedorMedicamento = medicamento.FornecedorMedicamento;
            }
        }

        public void RemoverMedicamento(Medicamento medicamento)
        {
            medicamentos.Remove(medicamento);
        }

        public void ListarTodosMedicamentos()
        {
            Console.WriteLine("Medicamentos em estoque:");
            foreach (Medicamento medicamento in medicamentos)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Medicamento adicionado ao estoque:");
                Console.WriteLine("Nome: " + medicamento.NomeMedicamento);
                Console.WriteLine("Descrição: " + medicamento.DescricaoMedicamento);
                Console.WriteLine("Quantidade disponível: " + medicamento.QuantidadeMedicamentoDisponivel);
                Console.WriteLine("Fornecedor: " + medicamento.FornecedorMedicamento.NomeFornecedor);
                Console.WriteLine("Quantidade limite: " + medicamento.QuantidadeLimiteMedicamento);
                Console.WriteLine("-----------------------------------");
            }
        }

        public List<Medicamento> ListarMedicamentosComPoucasQuantidades(int quantidadeMinima)
        {
            return medicamentos.Where(med => med.QuantidadeMedicamentoDisponivel <= quantidadeMinima).ToList();
        }

        public List<Medicamento> ListarMedicamentosMaisRetirados()
        {
            return medicamentos.OrderByDescending(med => med.QuantidadeDeRequisicoes).ToList();
        }

        // Método para listar os medicamentos em falta
        public void ListarMedicamentosEmFalta()
        {
            int totalMedicamentoEmFalta = 0;
            foreach (Medicamento medicamento in medicamentos)
            {
                // Se o medicamento está em falta avisa em tela.
                if (medicamento.EstaEmFalta())
                {
                    Console.WriteLine("(Atenção!) Medicamento em falta: " + medicamento.NomeMedicamento);
                    totalMedicamentoEmFalta++;
                }
            }

            Console.WriteLine("Total de medicamentos em falta encontrados: " + totalMedicamentoEmFalta);
        }

        public void SolicitarReposicaoMedicamento(Medicamento medicamento, Fornecedor fornecedor)
        {
            medicamento.FornecedorMedicamento = fornecedor;
            // lógica para enviar solicitação de reposição para o fornecedor
            Requisicao requisicao = new Requisicao();
            Requisicao solicitacaoDeRequisicao = new Requisicao(medicamento, null, fornecedor, "Solicitação de Medicamento");
            requisicao.RegistrarRequisicao(solicitacaoDeRequisicao);

        }
    }
}
