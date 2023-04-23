using ControleDeMedicamentos.Negocios;

namespace ControleDeMedicamentos.DAO
{
    internal class PacienteDAO
    {

        private List<Paciente> listaPacientes;

        public PacienteDAO()
        {
            listaPacientes = new List<Paciente>();
        }

        public void AdicionarPaciente(Paciente paciente)
        {
            // Código para adicionar paciente ao sistema
            listaPacientes.Add(paciente);
            Console.WriteLine($"Paciente {paciente.NomePaciente} adicionado com sucesso!");
        }

        // Método para editar um paciente
        public void AtualizarPaciente(Paciente paciente)
        {
            // Código para atualizar Paciente no sistema

            // Busca o Paciente na lista pelo seu Id
            Paciente pacienteBuscado = listaPacientes.Find(p => p.IdPaciente == paciente.IdPaciente);

            // Verifica se o Paciente foi encontrado
            if (pacienteBuscado != null)
            {
                // Atualiza todas as informações do Paciente
                pacienteBuscado = paciente;
                Console.WriteLine($"Paciente {pacienteBuscado.NomePaciente} atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Paciente não encontrado.");
            }
        }

        // Método para excluir um paciente da lista
        public void RemoverPaciente(int id)
        {
            // Busca o paciente na lista pelo id
            Paciente paciente = listaPacientes.Find(p => p.IdPaciente == id);

            // Verifica se o paciente foi encontrado
            if (paciente != null)
            {
                // Remove o paciente da lista
                listaPacientes.Remove(paciente);
                Console.WriteLine("Paciente excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
            }
        }

        // Método para consultar um Paciente da lista
        public void ConsultarPaciente(int id)
        {
            // Busca o Paciente na lista pelo id
            Paciente paciente = listaPacientes.Find(f => f.IdPaciente == id);

            // Verifica se o Paciente foi encontrado
            if (paciente != null)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Dados do paciente de ID: " + paciente.IdPaciente);
                Console.WriteLine("Nome: " + paciente.NomePaciente);
                Console.WriteLine("CPF: " + paciente.CpfPaciente);
                Console.WriteLine("Endereço: " + paciente.EnderecoPaciente);
                Console.WriteLine("Telefone: " + paciente.TelefonePaciente);
                Console.WriteLine("E-mail: " + paciente.EmailPaciente);
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado!");
            }
        }
    }
}
