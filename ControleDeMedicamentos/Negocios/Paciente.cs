using ControleDeMedicamentos.Negocios.MeuProjeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.Negocios
{
    public class Paciente
    {
        public int IdPaciente { get; set; }
        public string NomePaciente { get; set; }
        public string CpfPaciente { get; set; }
        public string EnderecoPaciente { get; set; }
        public string TelefonePaciente { get; set; }
        public string EmailPaciente { get; set; }

        //Criar lista pacientes
        private List<Paciente> listaPacientes;

        // Construtor da classe Paciente
        public Paciente(int idFornecedor, string nomeFornecedor, string cpfPaciente,string enderecoPaciente, string telefoneFornecedor, string emailFornecedor)
        {
            IdPaciente = idFornecedor;
            NomePaciente = nomeFornecedor;
            CpfPaciente = cpfPaciente;
            EnderecoPaciente = enderecoPaciente;
            TelefonePaciente = telefoneFornecedor;
            EmailPaciente = emailFornecedor;
        }

        // Construtor vazio da classe Paciente
        public Paciente()
        {
            // Inicializa a lista de pacientes vazia
            listaPacientes = new List<Paciente>();
        }
    }
}
    


