using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace novoprojeto
{
    public class Program
    {
        static void Main(string[] args)
        {

           Contacorrente conta1 = new Contacorrente();


            conta1.agencia = 51;
            conta1.conta = "123456";
            conta1.nome = "Eduardo";
            conta1.saldo = 250.00;

            Console.WriteLine("O saldo anterior é:" + conta1.saldo);
           // conta1.Depositar(500);
           //onta1.Transferir(500);

            /*
            Console.WriteLine("O saldo depois do depósito é:" + conta1.saldo);
            Console.WriteLine("Sua agencia é: " + conta1.agencia);
            Console.WriteLine("Sua conta é: " + conta1.conta);
            Console.WriteLine("Seu nome é: " + conta1.nome);
            Console.WriteLine("Seu saldo é: " + conta1.saldo);
            */


            Contacorrente conta2 = new Contacorrente();

            conta2.agencia = 60;
            conta2.conta = "1010";
            conta2.nome = "dudu";
           // conta2.Depositar(500);
            conta2.saldo = 100;
           



            Console.WriteLine("SALDO ATUAL DA CONTA QUE IRÁ TRANSFERIR:" + conta1.saldo);
            Console.WriteLine("SALDO ATUAL DA CONTA QUE IRÁ RECEBER:" + conta2.saldo);

            if (conta1.Transferir(50, conta2))
            Console.WriteLine("\n");
            Console.WriteLine("VALOR DA TRANSFERENCIA: " + conta1.valorTransferencia);

            Console.WriteLine("SALDO ATUAL APÓS VOCÊ TRANSFERIR:" + conta1.saldo);
            Console.WriteLine("SALDO ATUAL APÓS RECEBER:" + conta2.saldo);
            

         







        }
    }
}
