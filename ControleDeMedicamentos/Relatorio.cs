using ControleDeMedicamentos.Negocios;
using System;
using System.Collections.Generic;

namespace ProjetoExemplo
{
    class Relatorio
    {
        public static void GerarRelatorioMedicamentos(List<Medicamento> medicamentos)
        {
            Console.WriteLine("---- RELATÓRIO DE MEDICAMENTOS ----\n");

            foreach (Medicamento medicamento in medicamentos)
            {
                Console.WriteLine($"Nome do medicamento: {medicamento.NomeMedicamento}");
                Console.WriteLine($"Quantidade disponível: {medicamento.QuantidadeMedicamentoDisponivel}");
                Console.WriteLine($"Quantidade limite: {medicamento.QuantidadeLimiteMedicamento}");
                Console.WriteLine($"Fornecedor: {medicamento.FornecedorMedicamento.NomeFornecedor}\n");
            }
        }
    }
}
