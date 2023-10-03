namespace ForeachRemoveList;

// classes são tipos de referência, se uma váriavel é alterada, a outra é automaticamente afetada
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Idade { get; set; }
    public string Profissao { get; set; }
    public string EstadoCivil { get; set; }
    public string Documento { get; set; }
    public List<Endereco> ListaEndereco { get; set; } // referência tipo List
}
