using ControleDeMedicamentos.Negocios.MeuProjeto;
using ControleDeMedicamentos.Negocios;
using System;
using System.Xml;

namespace NomeDoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto da classe Medicamento
            //seria legal colocar um nome real
            List<Requisicao> minhaListaRequisicao = new List<Requisicao>();
            Fornecedor fornecedor = new Fornecedor(1234,"Bayer", "34320058", "fornecedor@bol.com.br");
            Medicamento medicamento1 = new Medicamento(1, "Alprazolam", "descricao do Medicamento", 54, minhaListaRequisicao, 23, 12, fornecedor);
                
           
            Console.WriteLine("Digite o nome do medicamento:");
            string nomeMedicamento = Console.ReadLine();
            medicamento1.NomeMedicamento = nomeMedicamento;

            Console.WriteLine("Digite a descrição do medicamento:");
            string descricaoMedicamento = Console.ReadLine();
            medicamento1.DescricaoMedicamento = descricaoMedicamento;

            Console.WriteLine("Digite a quantidade disponível do medicamento:");
            int quantidadeMedicamento = int.Parse(Console.ReadLine());
            medicamento1.QuantidadeMedicamentoDisponivel = quantidadeMedicamento;

            // Cria a lista de medicamentos para utilizar no estoque
            List<Medicamento> listaDeMedicamentos = new List<Medicamento>();

            // Armazenar as informações das quantidades de remédios disponíveis nos estoques.
            Medicamento medicamento2 = new Medicamento(2,"Vick-vaporub", "descricao do Medicamento", 23, minhaListaRequisicao, 67, 10, fornecedor);

            // Criando um objeto da classe Estoque
            // Controlar o estoque de remédios dos postos de saúde.
            Estoque estoque = new Estoque(listaDeMedicamentos);
            estoque.AdicionarMedicamento(medicamento1);
            estoque.AdicionarMedicamento(medicamento2);


            // Permitir a atualização da quantidade limite do medicamento "Vick-vaporub"
            medicamento2.QuantidadeLimiteMedicamento = 61;
            estoque.AtualizarMedicamento(medicamento2);

            // Registrar novos remédios no estoque.
            // Disponibilizar informações sobre nome, descrição e quantidade de remédios disponíveis.
            Medicamento medicamento3 = new Medicamento(3, "Neosaldina", "Neosaldina é um medicamento com atividade analgésica (diminui a dor) e antiespasmódica.", 23, minhaListaRequisicao, 67, 10, fornecedor);
            Medicamento medicamento4 = new Medicamento(4, "Dipirona", "A Dipirona é um derivado pirazolônico não narcótico com efeitos analgésico, antipirético e espasmolítico.", 23, minhaListaRequisicao, 67, 10, fornecedor);
            Medicamento medicamento5 = new Medicamento(5, "Buscopan", "Buscopan Composto age sobre as contrações dolorosas e aliviando de forma rápida e prolongada as cólicas, dores e desconfortos abdominais. \r\n\r\n ", 23, minhaListaRequisicao, 67, 10, fornecedor);
            estoque.AdicionarMedicamento(medicamento3);
            estoque.AdicionarMedicamento(medicamento4);
            estoque.AdicionarMedicamento(medicamento5);

            // Visualizar medicamentos com poucas quantidades no estoque.
            estoque.ListarMedicamentosComPoucasQuantidades(5);

            // Solicitar a reposição de medicamentos junto a um fornecedor cadastrado no sistema.
            estoque.SolicitarReposicaoMedicamento(medicamento5, fornecedor);


            // Apresentar os medicamentos mais retirados pela comunidade.
            // Lista todos os medicamentos cadastrados no estoque.
            estoque.ListarTodosMedicamentos();

            // Lista os medicamentos em falta do estoque.
            estoque.ListarMedicamentosEmFalta();

            // Cadatrar paciente
            Paciente pacientes = new Paciente();
            Paciente paciente1 = new Paciente(1, "João", "02344345780", "Rua Anastacio Ramos", "88970059", "fornecedortop@hotmail.com");
            pacientes.AdicionarPaciente(paciente1);

            // Editar paciente
            paciente1.NomePaciente = "José";
            paciente1.CpfPaciente = "08978965700";
            pacientes.AtualizarPaciente(paciente1);

            // Consulta paciente
            pacientes.ConsultarPaciente(1);

            // Excluir paciente      
            pacientes.RemoverPaciente(1);
        }
    }
}
