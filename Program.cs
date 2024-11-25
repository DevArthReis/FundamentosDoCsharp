using System;

namespace MeuApp
{
    class Tipos
    {
        static void Main(string[] args)
        { 
            //Entendendo como funciona os tipos
        const int IDADE_MINIMA = -18;
        Console.WriteLine(IDADE_MINIMA);       
        string nome = "Arthur";
        Console.WriteLine(nome);
        var texto = "testando";
        Console.WriteLine(texto);
        double idades = 2.3;
        Console.WriteLine(idades);
        float idade = 2.3f;
        Console.WriteLine(idade);
        bool usuarioJaCadastrado = false;
        bool pagamentoRecebido = true;
        var usuarioExpirado = false;
        char letra = 'D';
        string nomeclatura ="Arthur";
        //Convertendo Tipos
        int inteiro = 100;
        float real = 25.5f;
        //inteiro = (int)real;
        //Console.WriteLine(inteiro);
       // int valor1 = 100;
       // float valor2 = 25.2f;
        //valor2 = valor1;
        //Console.WriteLine(valor2);//Valor vai ser 100.0f
        //string valorReal = real.ToString();
        //inteiro = int.Parse(valorReal);
        inteiro = Convert.ToInt32(real);
        Console.WriteLine(inteiro); 
       // Console.WriteLine(valorReal); 
        
        }
    }
}
