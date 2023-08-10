public class Produto
{
    private string codigo;
    private string descricao;
    private double preco;
    private double porcentagem;
    private double valor;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }
    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }
    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }
    public double Porcentagem
    {
        get { return porcentagem; }
        set { porcentagem = value; }
    }
    public double Valor
    {
        get { return valor; }
        set { valor = value; }
    }

    public Produto(string codigo, string descricao, double preco, double porcentagem, double valor)
    {
        this.codigo = codigo;
        this.descricao = descricao;
        this.preco = preco;
        this.porcentagem = porcentagem;
        this.valor = valor;
    }
}