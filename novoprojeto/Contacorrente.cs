using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using novoprojeto;


public class Contacorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo;
    public double valorTransferencia;


    public void Depositar(double valor)
    {
        this.saldo += valor;

    }
    public bool Sacar(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo" + "Insuficiente para realizar o saque.");
            return false;
        }


    }
    public bool Transferir(double valor ,Contacorrente contaDestino)
    {
        if (this.saldo >= valor)
        {
            valorTransferencia = valor;
            this.saldo -= valor;
            contaDestino.saldo += valor;
          

            return true;
        }
        else
        {
            Console.WriteLine("Não foi possivel" + "realizar a transferencia.O saldo é" + "Insuficiente");
            return false;
        }




    }
}





