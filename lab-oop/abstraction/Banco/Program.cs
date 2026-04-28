using System.ComponentModel.Design.Serialization;
using Banco.Domain;

ContaCorrente conta = new ContaCorrente();
conta.Creditar(10.01);
conta.ExibirSaldo();
conta.SetEncargos(5.00);
conta.Debitar(20.00);