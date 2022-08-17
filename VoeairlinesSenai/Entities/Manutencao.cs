namespace VoeairlinesSenai.Entities;

using VoeAirlinesSenai.Entities;
using VoeAirlinesSenai.Entities.Enums;


public class Manutencao{
    public Manutencao(DateTime datahora, string observacoes, TipoManutencao tipo, int aeronaveId)
    {
        Datahora = datahora;
        Observacoes = observacoes;
        Tipo = tipo;
        AeronaveId = aeronaveId;
    }

    public int Id { get; set; }

    public DateTime Datahora {get; set;}

    public string Observacoes {get; set;}

    public TipoManutencao Tipo { get; set; }

    public int AeronaveId { get; set; }

    public Aeronave Aeronave { get; set; }

}
