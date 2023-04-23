using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.Negocios
{
    using System;

    namespace MeuProjeto
    {
        public class Fornecedor
        {
            public int IdFornecedor { get; set; }
            public string NomeFornecedor { get; set; }
            public string TelefoneFornecedor { get; set; }
            public string EmailFornecedor { get; set; }

            // Lista de fornecedores
            private List<Fornecedor> listaFornecedores;

            // Construtor da classe Fornecedor
            public Fornecedor(int idFornecedor, string nomeFornecedor, string telefoneFornecedor, string emailFornecedor)
            {
                IdFornecedor = idFornecedor;
                NomeFornecedor = nomeFornecedor;
                TelefoneFornecedor = telefoneFornecedor;
                EmailFornecedor = emailFornecedor;
            }

      
            // Construtor vazio da classe Fornecedor
            public Fornecedor()
            {
                // Inicializa a lista de fornecedores vazia
                listaFornecedores = new List<Fornecedor>();
            }
        }
    }
}
