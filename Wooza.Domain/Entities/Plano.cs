namespace Wooza.Domain.Entities
{
    public class Plano : BaseEntity
    {
        public string Codigo { get; set; }
        public int Minutos { get; set; }
        public int FranquiaInternet { get; set; }
        public float Valor { get; set; }
        public TipoPlano Tipo { get; set; } // (Controle, Pós, Pré)
        public string Operadora { get; set; }
    }
    public enum TipoPlano
    {
        Controle,
        Pos,
        Pre
    }
}
