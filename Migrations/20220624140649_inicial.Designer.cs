// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrytoApi.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220624140649_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Coins", b =>
                {
                    b.Property<int>("MonedaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("MonedaId");

                    b.ToTable("Coins");

                    b.HasData(
                        new
                        {
                            MonedaId = 1,
                            Descripcion = "Bitcoin",
                            ImgUrl = "https://png.monster/wp-content/uploads/2022/02/png.monster-623.png",
                            Valor = 23000.0
                        },
                        new
                        {
                            MonedaId = 2,
                            Descripcion = "Ethereum",
                            ImgUrl = "https://cdn.icon-icons.com/icons2/3369/PNG/512/ethereum_coin_money_cryptocurrency_icon_210995.png",
                            Valor = 1052.0
                        },
                        new
                        {
                            MonedaId = 3,
                            Descripcion = "DogCoins",
                            ImgUrl = "https://cdn.icon-icons.com/icons2/3376/PNG/512/dogecoin_currency_icon_211986.png",
                            Valor = 1052.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
