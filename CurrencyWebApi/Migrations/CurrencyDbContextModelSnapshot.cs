﻿// <auto-generated />
using System;
using CurrencyWebApi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurrencyWebApi.Migrations
{
    [DbContext(typeof(CurrencyDbContext))]
    partial class CurrencyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CurrencyWebApi.Repository.Models.CurrencyDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("_base")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("historical")
                        .HasColumnType("bit");

                    b.Property<int?>("ratesId")
                        .HasColumnType("int");

                    b.Property<bool>("success")
                        .HasColumnType("bit");

                    b.Property<int>("timestamp")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ratesId");

                    b.ToTable("CurrencyData");
                });

            modelBuilder.Entity("CurrencyWebApi.Repository.Models.CurrencyDbModel+Rates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AED")
                        .HasColumnType("real");

                    b.Property<float>("AFN")
                        .HasColumnType("real");

                    b.Property<float>("ALL")
                        .HasColumnType("real");

                    b.Property<float>("AMD")
                        .HasColumnType("real");

                    b.Property<float>("ANG")
                        .HasColumnType("real");

                    b.Property<float>("AOA")
                        .HasColumnType("real");

                    b.Property<float>("ARS")
                        .HasColumnType("real");

                    b.Property<float>("AUD")
                        .HasColumnType("real");

                    b.Property<float>("AWG")
                        .HasColumnType("real");

                    b.Property<float>("AZN")
                        .HasColumnType("real");

                    b.Property<float>("BAM")
                        .HasColumnType("real");

                    b.Property<float>("BBD")
                        .HasColumnType("real");

                    b.Property<float>("BDT")
                        .HasColumnType("real");

                    b.Property<float>("BGN")
                        .HasColumnType("real");

                    b.Property<float>("BHD")
                        .HasColumnType("real");

                    b.Property<float>("BIF")
                        .HasColumnType("real");

                    b.Property<float>("BMD")
                        .HasColumnType("real");

                    b.Property<float>("BND")
                        .HasColumnType("real");

                    b.Property<float>("BOB")
                        .HasColumnType("real");

                    b.Property<float>("BRL")
                        .HasColumnType("real");

                    b.Property<float>("BSD")
                        .HasColumnType("real");

                    b.Property<float>("BTC")
                        .HasColumnType("real");

                    b.Property<float>("BTN")
                        .HasColumnType("real");

                    b.Property<float>("BWP")
                        .HasColumnType("real");

                    b.Property<float>("BYN")
                        .HasColumnType("real");

                    b.Property<float>("BYR")
                        .HasColumnType("real");

                    b.Property<float>("BZD")
                        .HasColumnType("real");

                    b.Property<float>("CAD")
                        .HasColumnType("real");

                    b.Property<float>("CDF")
                        .HasColumnType("real");

                    b.Property<float>("CHF")
                        .HasColumnType("real");

                    b.Property<float>("CLF")
                        .HasColumnType("real");

                    b.Property<float>("CLP")
                        .HasColumnType("real");

                    b.Property<float>("CNY")
                        .HasColumnType("real");

                    b.Property<float>("COP")
                        .HasColumnType("real");

                    b.Property<float>("CRC")
                        .HasColumnType("real");

                    b.Property<float>("CUC")
                        .HasColumnType("real");

                    b.Property<float>("CUP")
                        .HasColumnType("real");

                    b.Property<float>("CVE")
                        .HasColumnType("real");

                    b.Property<float>("CZK")
                        .HasColumnType("real");

                    b.Property<float>("DJF")
                        .HasColumnType("real");

                    b.Property<float>("DKK")
                        .HasColumnType("real");

                    b.Property<float>("DOP")
                        .HasColumnType("real");

                    b.Property<float>("DZD")
                        .HasColumnType("real");

                    b.Property<float>("EGP")
                        .HasColumnType("real");

                    b.Property<float>("ERN")
                        .HasColumnType("real");

                    b.Property<float>("ETB")
                        .HasColumnType("real");

                    b.Property<float>("EUR")
                        .HasColumnType("real");

                    b.Property<float>("FJD")
                        .HasColumnType("real");

                    b.Property<float>("FKP")
                        .HasColumnType("real");

                    b.Property<float>("GBP")
                        .HasColumnType("real");

                    b.Property<float>("GEL")
                        .HasColumnType("real");

                    b.Property<float>("GGP")
                        .HasColumnType("real");

                    b.Property<float>("GHS")
                        .HasColumnType("real");

                    b.Property<float>("GIP")
                        .HasColumnType("real");

                    b.Property<float>("GMD")
                        .HasColumnType("real");

                    b.Property<float>("GNF")
                        .HasColumnType("real");

                    b.Property<float>("GTQ")
                        .HasColumnType("real");

                    b.Property<float>("GYD")
                        .HasColumnType("real");

                    b.Property<float>("HKD")
                        .HasColumnType("real");

                    b.Property<float>("HNL")
                        .HasColumnType("real");

                    b.Property<float>("HRK")
                        .HasColumnType("real");

                    b.Property<float>("HTG")
                        .HasColumnType("real");

                    b.Property<float>("HUF")
                        .HasColumnType("real");

                    b.Property<float>("IDR")
                        .HasColumnType("real");

                    b.Property<float>("ILS")
                        .HasColumnType("real");

                    b.Property<float>("IMP")
                        .HasColumnType("real");

                    b.Property<float>("INR")
                        .HasColumnType("real");

                    b.Property<float>("IQD")
                        .HasColumnType("real");

                    b.Property<float>("IRR")
                        .HasColumnType("real");

                    b.Property<float>("ISK")
                        .HasColumnType("real");

                    b.Property<float>("JEP")
                        .HasColumnType("real");

                    b.Property<float>("JMD")
                        .HasColumnType("real");

                    b.Property<float>("JOD")
                        .HasColumnType("real");

                    b.Property<float>("JPY")
                        .HasColumnType("real");

                    b.Property<float>("KES")
                        .HasColumnType("real");

                    b.Property<float>("KGS")
                        .HasColumnType("real");

                    b.Property<float>("KHR")
                        .HasColumnType("real");

                    b.Property<float>("KMF")
                        .HasColumnType("real");

                    b.Property<float>("KPW")
                        .HasColumnType("real");

                    b.Property<float>("KRW")
                        .HasColumnType("real");

                    b.Property<float>("KWD")
                        .HasColumnType("real");

                    b.Property<float>("KYD")
                        .HasColumnType("real");

                    b.Property<float>("KZT")
                        .HasColumnType("real");

                    b.Property<float>("LAK")
                        .HasColumnType("real");

                    b.Property<float>("LBP")
                        .HasColumnType("real");

                    b.Property<float>("LKR")
                        .HasColumnType("real");

                    b.Property<float>("LRD")
                        .HasColumnType("real");

                    b.Property<float>("LSL")
                        .HasColumnType("real");

                    b.Property<float>("LTL")
                        .HasColumnType("real");

                    b.Property<float>("LVL")
                        .HasColumnType("real");

                    b.Property<float>("LYD")
                        .HasColumnType("real");

                    b.Property<float>("MAD")
                        .HasColumnType("real");

                    b.Property<float>("MDL")
                        .HasColumnType("real");

                    b.Property<float>("MGA")
                        .HasColumnType("real");

                    b.Property<float>("MKD")
                        .HasColumnType("real");

                    b.Property<float>("MMK")
                        .HasColumnType("real");

                    b.Property<float>("MNT")
                        .HasColumnType("real");

                    b.Property<float>("MOP")
                        .HasColumnType("real");

                    b.Property<float>("MRO")
                        .HasColumnType("real");

                    b.Property<float>("MUR")
                        .HasColumnType("real");

                    b.Property<float>("MVR")
                        .HasColumnType("real");

                    b.Property<float>("MWK")
                        .HasColumnType("real");

                    b.Property<float>("MXN")
                        .HasColumnType("real");

                    b.Property<float>("MYR")
                        .HasColumnType("real");

                    b.Property<float>("MZN")
                        .HasColumnType("real");

                    b.Property<float>("NAD")
                        .HasColumnType("real");

                    b.Property<float>("NGN")
                        .HasColumnType("real");

                    b.Property<float>("NIO")
                        .HasColumnType("real");

                    b.Property<float>("NOK")
                        .HasColumnType("real");

                    b.Property<float>("NPR")
                        .HasColumnType("real");

                    b.Property<float>("NZD")
                        .HasColumnType("real");

                    b.Property<float>("OMR")
                        .HasColumnType("real");

                    b.Property<float>("PAB")
                        .HasColumnType("real");

                    b.Property<float>("PEN")
                        .HasColumnType("real");

                    b.Property<float>("PGK")
                        .HasColumnType("real");

                    b.Property<float>("PHP")
                        .HasColumnType("real");

                    b.Property<float>("PKR")
                        .HasColumnType("real");

                    b.Property<float>("PLN")
                        .HasColumnType("real");

                    b.Property<float>("PYG")
                        .HasColumnType("real");

                    b.Property<float>("QAR")
                        .HasColumnType("real");

                    b.Property<float>("RON")
                        .HasColumnType("real");

                    b.Property<float>("RSD")
                        .HasColumnType("real");

                    b.Property<float>("RUB")
                        .HasColumnType("real");

                    b.Property<float>("RWF")
                        .HasColumnType("real");

                    b.Property<float>("SAR")
                        .HasColumnType("real");

                    b.Property<float>("SBD")
                        .HasColumnType("real");

                    b.Property<float>("SCR")
                        .HasColumnType("real");

                    b.Property<float>("SDG")
                        .HasColumnType("real");

                    b.Property<float>("SEK")
                        .HasColumnType("real");

                    b.Property<float>("SGD")
                        .HasColumnType("real");

                    b.Property<float>("SHP")
                        .HasColumnType("real");

                    b.Property<float>("SLL")
                        .HasColumnType("real");

                    b.Property<float>("SOS")
                        .HasColumnType("real");

                    b.Property<float>("SRD")
                        .HasColumnType("real");

                    b.Property<float>("STD")
                        .HasColumnType("real");

                    b.Property<float>("SVC")
                        .HasColumnType("real");

                    b.Property<float>("SYP")
                        .HasColumnType("real");

                    b.Property<float>("SZL")
                        .HasColumnType("real");

                    b.Property<float>("THB")
                        .HasColumnType("real");

                    b.Property<float>("TJS")
                        .HasColumnType("real");

                    b.Property<float>("TMT")
                        .HasColumnType("real");

                    b.Property<float>("TND")
                        .HasColumnType("real");

                    b.Property<float>("TOP")
                        .HasColumnType("real");

                    b.Property<float>("TRY")
                        .HasColumnType("real");

                    b.Property<float>("TTD")
                        .HasColumnType("real");

                    b.Property<float>("TWD")
                        .HasColumnType("real");

                    b.Property<float>("TZS")
                        .HasColumnType("real");

                    b.Property<float>("UAH")
                        .HasColumnType("real");

                    b.Property<float>("UGX")
                        .HasColumnType("real");

                    b.Property<float>("USD")
                        .HasColumnType("real");

                    b.Property<float>("UYU")
                        .HasColumnType("real");

                    b.Property<float>("UZS")
                        .HasColumnType("real");

                    b.Property<float>("VEF")
                        .HasColumnType("real");

                    b.Property<float>("VND")
                        .HasColumnType("real");

                    b.Property<float>("VUV")
                        .HasColumnType("real");

                    b.Property<float>("WST")
                        .HasColumnType("real");

                    b.Property<float>("XAF")
                        .HasColumnType("real");

                    b.Property<float>("XAG")
                        .HasColumnType("real");

                    b.Property<float>("XAU")
                        .HasColumnType("real");

                    b.Property<float>("XCD")
                        .HasColumnType("real");

                    b.Property<float>("XDR")
                        .HasColumnType("real");

                    b.Property<float>("XOF")
                        .HasColumnType("real");

                    b.Property<float>("XPF")
                        .HasColumnType("real");

                    b.Property<float>("YER")
                        .HasColumnType("real");

                    b.Property<float>("ZAR")
                        .HasColumnType("real");

                    b.Property<float>("ZMK")
                        .HasColumnType("real");

                    b.Property<float>("ZMW")
                        .HasColumnType("real");

                    b.Property<float>("ZWL")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("CurrencyWebApi.Repository.Models.CurrencyDbModel", b =>
                {
                    b.HasOne("CurrencyWebApi.Repository.Models.CurrencyDbModel+Rates", "rates")
                        .WithMany()
                        .HasForeignKey("ratesId");
                });
#pragma warning restore 612, 618
        }
    }
}