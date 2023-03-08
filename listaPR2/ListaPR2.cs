using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace listaPR2
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            
            
            
            
            
            //exercício 1
            //int m, cm, mm;

            //Console.WriteLine("digite o número de metros");

            //m= int.Parse(Console.ReadLine());
            //cm = m * 100;
            //mm = m * 1000;

            //Console.WriteLine("a quantidade em cm é: "+cm);
            //Console.WriteLine("a quantidade em mm é: "+mm); 
            //Console.ReadKey();  







            //exercício 2 a)

            //int f1, resInt;

            //Console.WriteLine("insira o valor em Fahrenheit");
            //f1 = int.Parse(Console.ReadLine());
            //resInt = (f1 - 32) * (5 / 9);
            //Console.WriteLine("o valor em Celsius é de: "+resInt);  
            //Console.ReadKey();





            //exercício b)

            //float f1, resFloat;
            //Console.WriteLine("insira o valor em Fahrenheit");
            //f1= float.Parse(Console.ReadLine());
            //resFloat = (float)((f1 - 32.0) * (5.0 / 9.0));
            //Console.WriteLine("o valor em Celcius é de : "+resFloat);
            //Console.ReadKey();  








            //exercicio 3

            //double h, kg, imc;

            //Console.WriteLine("Para calcular seu IMC, basta dividir seu peso pela altura ao quadrado");
            //Console.WriteLine("insira sua altura");

            //h = double.Parse(Console.ReadLine());
            //Console.WriteLine("insira seu peso em kg");

            //kg = float.Parse(Console.ReadLine());

            //imc = kg / (h * h);

            //Console.WriteLine("seu IMC é igual a: " + imc);
            //Console.ReadKey();







            //exercicio 4

            //int num1, num2, num3, peso1, peso2, peso3, media;

            //Console.WriteLine("insira o primeiro numero");
            //num1= int.Parse(Console.ReadLine());
            //Console.WriteLine("insira o segundo número");
            //num2= int.Parse(Console.ReadLine());        
            //Console.WriteLine("insira o terceiro número");
            //num3= int.Parse(Console.ReadLine());       

            //Console.WriteLine("insira o primeiro peso");
            //peso1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("insira o segundo peso");
            //peso2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("insira o terceiro peso");
            //peso3 = int.Parse(Console.ReadLine());

            //media= (num1*peso2+num2*peso2+num3*peso3)/(peso1+peso2+peso3);
            //Console.WriteLine("a média ponderada dos valores é : " + media);
            //Console.ReadKey();







            //exercicio 5

            //int vel, d, t;

            //Console.WriteLine("Para calcular a velocidade, insira o valor da distancia em metros");
            //d = int.Parse(Console.ReadLine());
            //Console.WriteLine("insira o valor do tempo em segundos");
            //t = int.Parse(Console.ReadLine());

            //vel = d / t;
            //Console.WriteLine("O valor da distancia é de: " + vel + "m/s");
            //Console.ReadKey();







            //exercicio 6


            //double salario, aum;

            //Console.WriteLine("insira o valor do salario");


            //salario = double.Parse(Console.ReadLine());
            //aum = salario*1.25;
            //Console.WriteLine("o salario atual é igual a : " + aum);
            //Console.ReadKey();






            //    exercício 7

            //float reais, dolar, atual;

            //Console.WriteLine("insira o valor em reais");
            //reais=float.Parse(Console.ReadLine());

            //Console.WriteLine("insira a cotação em dólar");
            //dolar=float.Parse(Console.ReadLine());  


            //atual = reais * dolar;

            //Console.WriteLine("o valor em dólar é de: "+atual);
            //Console.ReadKey();






            //exercício 8


            //int num, ant, suc, soma;

            //Console.WriteLine("insira o numero");
            //num = int.Parse(Console.ReadLine());

            //ant = (num * 3) + 1;
            //suc = (num * 2) - 1;

            //soma = ant + suc;
            //Console.WriteLine("a soma é igual a: " + soma);
            //Console.ReadKey();





            //exercício 11

            //int quadrado,num,cubo;

            //Console.WriteLine("insira um numero");
            //num = int.Parse(Console.ReadLine());

            //quadrado = num*num;
            //cubo = num*num*num;

            //Console.WriteLine("o numero ao quadrado é igual a: "+quadrado);
            //Console.WriteLine("o numero ao cubo é igual a: "+cubo);

            //Console.ReadKey();





            //exercício 12 a)


            //double h, peso;

            //Console.WriteLine("insira sua altura");
            //h=double.Parse(Console.ReadLine()); 

            //peso= (72.7 * h)-58;

            //Console.WriteLine("seu peso ideal é igual a: "+peso);
            //Console.ReadKey();








            //exercício 12 b)


            //double h, peso;

            //Console.WriteLine("insira sua altura");
            //h = double.Parse(Console.ReadLine());

            //peso = (62.1 * h) - 44.713;

            //Console.WriteLine("seu peso ideal é igual a: " + peso);
            //Console.ReadKey();








            //exercício 13

            //O Git é um projeto de código aberto maduro e com manutenção ativa desenvolvido
            //em 2005 por Linus Torvalds, o famoso criador do kernel do sistema operacional Linux.
            //Um número impressionante de projetos de software depende do Git para controle
            //de versão, incluindo projetos comerciais e de código-fonte aberto.
            //
            //GitHub é uma plataforma para gerenciar seu código e criar um ambiente de
            //colaboração entre devs, utilizando o Git como sistema de controle.

            //exemplos:

            //Git clone
            //Git clone é uma comando para baixar o código - fonte existente de um repositório remoto(como, por exemplo, o Github).
            //git clone<https://link-com-o-nome-do-repositório>

            //git branch
            //Podemos usar o comando git branch para criar, listar e excluir as branches.
            //git branch <nome-da-branch>

            //git checkout
            //Usamos git checkout, na maioria dos casos, para trocar de uma branch para outra.
            //Também podemos usar o comando para fazer o checkout de arquivos e commits.

            //git checkout<nome-da - branch >


            //Git status
            //O comando git status nos dá todas as informações necessárias sobre a branch atual.
            //git status

            //git add
            //Precisamos usar o comando git add para incluir as alterações de um ou
            //vários arquivos em nosso próximo commit.
            //git add <arquivo>


            //git commit
            //Git commit é como definir um ponto de verificação no processo de desenvolvimento. 
            //git commit -m "mensagem do commit"


            //git push
            //Git push faz o upload dos seus commits no repositório remoto.
            //git push<repositório-remoto > < nome - da - branch >



            //Git pull
            //O comando git pull é usado para obter as atualizações de um repositório remoto.
            //Esse comando é uma combinação de git fetch e git merge, o que significa que,
            //quando usamos git pull, ele recebe as atualizações do repositório remoto
            //(git fetch) e aplica imediatamente as alterações mais recentes em seu espaço de trabalho local(git merge).

            //git pull <repositório-remoto>


            

        }
    }
}
