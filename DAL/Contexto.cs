using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Coins> Coins { get; set; }

    public Contexto(DbContextOptions<Contexto> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coins>().HasData(
            new Coins()
            {
                MonedaId = 1,
                Descripcion = "Bitcoin",
                Valor = 23000,
                ImgUrl = "https://png.monster/wp-content/uploads/2022/02/png.monster-623.png"
            },
            new Coins()
            {
                MonedaId = 2,
                Descripcion = "Ethereum",
                Valor = 1052,
                ImgUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png"
            },
            new Coins()
            {
                MonedaId = 3,
                Descripcion = "DogCoins",
                Valor = 1052,
                ImgUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png"
            }
        );
    }
}