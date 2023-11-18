﻿// <auto-generated />
using System;
using BancoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BancoAPI.Migrations
{
    [DbContext(typeof(BancoDbContext))]
    [Migration("20231118001832_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("BancoAPI.Models.Agencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroAgencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Agencia");
                });

            modelBuilder.Entity("BancoAPI.Models.CartaoCredito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Bloqueado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CodigoSeguranca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ContaID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Limite")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroCartao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContaID");

                    b.ToTable("CartaoCredito");
                });

            modelBuilder.Entity("BancoAPI.Models.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("BancoAPI.Models.Conta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AgenciaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteId1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroConta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoConta")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.HasIndex("ClienteId1");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("BancoAPI.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("BancoAPI.Models.Investimento", b =>
                {
                    b.Property<int>("InvestimentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContaID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataInvestimento")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataResgate")
                        .HasColumnType("TEXT");

                    b.Property<float>("RentabilidadeMensal")
                        .HasColumnType("REAL");

                    b.Property<double>("Taxa")
                        .HasColumnType("REAL");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.Property<float>("ValorInicial")
                        .HasColumnType("REAL");

                    b.HasKey("InvestimentoID");

                    b.HasIndex("ContaID");

                    b.ToTable("Investimento");
                });

            modelBuilder.Entity("BancoAPI.Models.Movimentacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataMovimentacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContaId");

                    b.ToTable("Movimentacao");
                });

            modelBuilder.Entity("BancoAPI.Models.Seguro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClienteId1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Premio")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ValorCoberto")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId1");

                    b.ToTable("Seguro");
                });

            modelBuilder.Entity("Proejto_Banco.Models.Emprestimo", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data_soli")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor_soli")
                        .HasColumnType("REAL");

                    b.Property<int?>("n_parcelas")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("valor_pagar")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("Proejto_Banco.Models.Transferencia", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataTransferencia")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("Transferencia");
                });

            modelBuilder.Entity("BancoAPI.Models.Agencia", b =>
                {
                    b.HasOne("BancoAPI.Models.Endereco", "Endereco")
                        .WithOne("Agencia")
                        .HasForeignKey("BancoAPI.Models.Agencia", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("BancoAPI.Models.CartaoCredito", b =>
                {
                    b.HasOne("BancoAPI.Models.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("BancoAPI.Models.Conta", b =>
                {
                    b.HasOne("BancoAPI.Models.Agencia", "Agencia")
                        .WithMany()
                        .HasForeignKey("AgenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BancoAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agencia");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BancoAPI.Models.Investimento", b =>
                {
                    b.HasOne("BancoAPI.Models.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("BancoAPI.Models.Movimentacao", b =>
                {
                    b.HasOne("BancoAPI.Models.Conta", "Conta")
                        .WithMany()
                        .HasForeignKey("ContaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conta");
                });

            modelBuilder.Entity("BancoAPI.Models.Seguro", b =>
                {
                    b.HasOne("BancoAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("BancoAPI.Models.Endereco", b =>
                {
                    b.Navigation("Agencia")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
