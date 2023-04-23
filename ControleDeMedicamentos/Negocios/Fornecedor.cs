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

            public void AdicionarFornecedor(Fornecedor fornecedor)
            {
                // Código para adicionar fornecedor ao sistema
                listaFornecedores.Add(fornecedor);
                Console.WriteLine($"Fornecedor {fornecedor.NomeFornecedor} adicionado com sucesso!");
            }

            // Método para editar um Fornecedor
            public void AtualizarFornecedor(Fornecedor fornecedor)
            {
                // Código para atualizar fornecedor no sistema

                // Busca o fornecedor na lista pelo seu Id
                Fornecedor fornecedorBuscado = listaFornecedores.Find(f => f.IdFornecedor == fornecedor.IdFornecedor);

                // Verifica se o fornecedor foi encontrado
                if (fornecedorBuscado != null)
                {
                    // Atualiza todas as informações do fornecedor
                    fornecedorBuscado = fornecedor;
                    Console.WriteLine($"Fornecedor {fornecedorBuscado.NomeFornecedor} atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Fornecedor não encontrado.");
                }
            }

            // Método para excluir um fornecedor da lista
            public void RemoverFornecedor(int id)
            {
                // Busca o fornecedor na lista pelo id
                Fornecedor fornecedor = listaFornecedores.Find(f => f.IdFornecedor == id);

                // Verifica se o fornecedor foi encontrado
                if (fornecedor != null)
                {
                    // Remove o fornecedor da lista
                    listaFornecedores.Remove(fornecedor);
                    Console.WriteLine("Fornecedor excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("Fornecedor não encontrado!");
                }
            }

            // Método para consultar um fornecedor da lista
            public void ConsultarFornecedor(int id)
            {
                // Busca o fornecedor na lista pelo id
                Fornecedor fornecedor = listaFornecedores.Find(f => f.IdFornecedor == id);

                // Verifica se o fornecedor foi encontrado
                if (fornecedor != null)
                {
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("Dados do fornecedor de ID: " + fornecedor.IdFornecedor);
                    Console.WriteLine("Nome: " + fornecedor.NomeFornecedor);
                    Console.WriteLine("Telefone: " + fornecedor.TelefoneFornecedor);
                    Console.WriteLine("E-mail: " + fornecedor.EmailFornecedor);
                    Console.WriteLine("-----------------------------------");
                }
                else
                {
                    Console.WriteLine("Fornecedor não encontrado!");
                }
            }
        }
    }
}
