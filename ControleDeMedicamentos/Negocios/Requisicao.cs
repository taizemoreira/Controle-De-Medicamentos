using ControleDeMedicamentos.Negocios.MeuProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.Negocios
{
    public class Requisicao
    {
        public Medicamento MedicamentoRequisitado { get; set; }
        public Paciente? PacienteRequisitante { get; set; }
        public Fornecedor? FornecedorRequisitante { get; set; }
        public string? TituloRequisicao { get; set; }
        public DateTime DataRequisicao { get; set; }

        private List<Requisicao> listaRequisicoes { get; set; }

        public Requisicao(Medicamento medicamento, Paciente paciente, Fornecedor fornecedor, string titulo)
        {
            MedicamentoRequisitado = medicamento;
            PacienteRequisitante = paciente;
            FornecedorRequisitante = fornecedor;
            TituloRequisicao = titulo;
            DataRequisicao = DateTime.Now;
        }

        public Requisicao()
        {

        }

        public void RegistrarRequisicao(Requisicao requisicao)
        {
            requisicao.MedicamentoRequisitado.HistoricoDeRequisicoes.Add(requisicao);
            requisicao.MedicamentoRequisitado.QuantidadeDeRequisicoes += 1;
            listaRequisicoes.Add(requisicao);
        }
    }
}

