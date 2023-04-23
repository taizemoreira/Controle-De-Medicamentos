using ControleDeMedicamentos.Negocios.MeuProjeto;
using ControleDeMedicamentos.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.DAO
{
    internal class EstoqueDAO
    {
        private List<Medicamento> medicamentos { get; set; }

        public EstoqueDAO(List<Medicamento> listaMedicamentos)
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
    }
}
