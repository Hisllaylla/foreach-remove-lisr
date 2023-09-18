namespace ForeachRemoveList
{
    public class Program
    {
        public static void Main()
        {
            var cliente = new Cliente // criar cliente
            {
                Nome = "Hisllaylla",
                Idade = "19",
                Profissao = "Estudante",
                EstadoCivil = "solteira",
                Documento = "12345678901"
            };
            cliente.ListaEndereco = new List<Endereco>(); // listar 5 endereços

            var endereco1 = new Endereco
            {
                Id = 1,
                Logradouro = "Rua da Imprensa",
                Numero = "224",
                Bairro = "Monte Castelo",
                Cidade = "Campo Grande",
                Estado = "MS"
            };
            cliente.ListaEndereco.Add(endereco1);

            var endereco2 = new Endereco
            {
                Id = 2,
                Logradouro = "Rua Maria Luísa do Val Penteado",
                Numero = "123",
                Bairro = "Cidade São Mateus",
                Cidade = "São Paulo",
                Estado = "SP"
            };
            cliente.ListaEndereco.Add(endereco2);

            var endereco3 = new Endereco
            {
                Id = 3,
                Logradouro = "Avenida Rio Branco",
                Numero = "456",
                Bairro = "Centro",
                Cidade = "Rio de Janeiro",
                Estado = "RJ"
            };
            cliente.ListaEndereco.Add(endereco3);

            var endereco4 = new Endereco
            {
                Id = 4,
                Logradouro = "Avenida Governador José Malcher",
                Numero = "789",
                Bairro = "Nazaré",
                Cidade = "Belém",
                Estado = "PA"
            };
            cliente.ListaEndereco.Add(endereco4);

            var endereco5 = new Endereco
            {
                Id = 5,
                Logradouro = "Rua Carlos Augusto Cornelsen",
                Numero = "1011",
                Bairro = "Bom Retiro",
                Cidade = "Curitiba",
                Estado = "PR"
            };
            cliente.ListaEndereco.Add(endereco5);

            // revelar endereços
            foreach (var totalEnderecos in cliente.ListaEndereco)
            {
                Console.WriteLine($"{totalEnderecos}");
            }

            if (cliente.ListaEndereco.Count >= 3)
            {
                cliente.ListaEndereco.RemoveAt(2); // Remove o terceiro item da lista (índice 2)
            }

            
            foreach (var endereco in cliente.ListaEndereco)
            {
                Console.WriteLine("Id: " + endereco.Id);
                Console.WriteLine("Logradouro: " + endereco.Logradouro);
                Console.WriteLine("Número: " + endereco.Numero);
                Console.WriteLine("Bairro: " + endereco.Bairro);
                Console.WriteLine("Cidade: " + endereco.Cidade);
                Console.WriteLine("Estado: " + endereco.Estado);
                Console.WriteLine();

                if (endereco.Id == 4) // verificação do ID
                {
                    break;
                }
            }
        }
    }
}
