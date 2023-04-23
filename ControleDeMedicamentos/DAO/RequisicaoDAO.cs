using ControleDeMedicamentos.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.DAO
{
    internal class RequisicaoDAO
    {
        private List<Requisicao> requisicoes { get; set; }

        public RequisicaoDAO(List<Requisicao> listaRequisicoes)
        {
            requisicoes = listaRequisicoes;
        }

        public void RegistrarRequisicao(Requisicao requisicao)
        {
            requisicao.MedicamentoRequisitado.HistoricoDeRequisicoes.Add(requisicao);
            requisicao.MedicamentoRequisitado.QuantidadeDeRequisicoes += 1;
            requisicoes.Add(requisicao);
        }
    }
}
