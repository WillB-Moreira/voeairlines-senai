using Microsoft.EntityFrameworkCore;
using VoeAirlinesSenai.Entities;

namespace VoeAirlinesSenai.Contexts;

public class VoeAirlinesSenaiContext : DbContext
{

    public DbSet<Aeronave> Aeronaves => Set<Aeronave>();

    public DbSet<Manutencao> Manutencoes => Set<Manutencao>();

    /*public DbSet<Cancelamento> Cancelamentos =>Se<Cancelamento>();
    public DbSet<Pilotos> Pilotos =>Set<Pilotos>();
    public DbSet<Voo> Voos =>Set<Voo>();*/




}