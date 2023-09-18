namespace ForeachRemoveList;
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Idade { get; set; }
    public string Profissao { get; set; }
    public string EstadoCivil { get; set; }
    public string Documento { get; set; }
    public List<Endereco> ListaEndereco { get; set; }
}
