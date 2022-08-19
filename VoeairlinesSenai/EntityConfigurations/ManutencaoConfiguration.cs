using VoeAirlinesSenai.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeairlinesSenai.Entities;

namespace VoeAirlinesSenai.Entityconfigurations;

public class ManutencaoConfiguration : IEntityTypeConfiguration<Manutencao>
{
    public void Configure(EntityTypeBuilder<Manutencao> builder)
    {
        builder.ToTable("Manutencoes");

        builder.HasKey(m => m.Id);

        builder.Property(m => m.Datahora)
                .IsRequired();

        builder.Property(m => m.Tipo)
                .IsRequired();

        builder.Property(m => m.Observacoes)
                .HasMaxLength(100);


    }
}