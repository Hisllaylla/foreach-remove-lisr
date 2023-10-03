namespace ForeachRemoveList; // pasta

public class Endereco // reference types
{
    public int Id { get; set; } 
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    // override é utilizado para estilizar a mensagem que será instanciada em outra classe
    public override string ToString() // ToString é um método mais intuitivo para retornar os valores da classe
    {
        return $"{Id}, {Logradouro}, {Numero}, {Bairro}, {Cidade}, {Estado}";
    }

    /*

        Quando você chama ToString() em um objeto, a implementação padrão do método ToString() na classe base Object 
    retorna o nome completo da classe do objeto. No entanto, ao usar override com ToString() em sua própria classe, é possível
    substituir essa implementação e fornecer uma representação de string significativa e útil, especialmente em depuração e exibição.

    */

}