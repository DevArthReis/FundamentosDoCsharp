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
       //Operadores aritmetricos
        var x = 5;
        var y = 2.3;
        var soma = x + y;
        Console.WriteLine(soma);
        var divisao = x / y;
        Console.WriteLine(divisao);
        var multiplicacao = x * y;
        Console.WriteLine(multiplicacao);
        var subtracao = x - y;
        Console.WriteLine(subtracao);
        var resto = x % y;
        Console.WriteLine(resto);
        //Operadores de comparação
        var xy = 10;
        Console.WriteLine(xy>11);
        Console.WriteLine(xy>=11);
        Console.WriteLine(xy<=11);
        Console.WriteLine(xy<11);
        Console.WriteLine(xy!=11);
        Console.WriteLine(xy==10);
        Console.WriteLine(xy==11);
        //Operadores Logicos
        //not(!) , or(||) , and(&&) são sempre uasdos em condicionais
        int d = 12;
        bool entre = (d>25)&& (d<40);
        bool k = (d>10) && (d<20);
        Console.WriteLine(entre);
        Console.WriteLine(k);
        bool ou = (d>25)|| (d<40);
        Console.WriteLine(ou);
        bool not = !(x<25);
        Console.WriteLine(not);
        //Condicionais
        var a = 10;
        var b =20;
        if(b<a){
            Console.WriteLine("Testetando uma condicional no c#");
        }
        else{
            Console.WriteLine("Opa");
        }
        if(a == b){
            Console.WriteLine("é igual");
        }
        else{
            Console.WriteLine("é Diferente");
            
        }
        if(a != b){
            Console.WriteLine("é Diferente");
        }
        else{
            Console.WriteLine("é igual");
        }
        var correta = 1234; // Senha correta
        Console.WriteLine("Digite sua senha:");
        var input = Console.ReadLine();

        // Verifica se a entrada é um número válido
        if (int.TryParse(input, out int senha))
        {
            if (senha == correta)
            {
                Console.WriteLine("Acesso permitido!");
            }
            else
            {
                Console.WriteLine("Senha incorreta. Tente novamente.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
        }
        //Switch cases
        string valor = "Arthur";
        switch(valor)
        {//case=caso caso algo faça isso 
            case "jOAO":Console.WriteLine("esta errado");break;
            case "Marcelo":Console.WriteLine("esta errado");break;
            case "Marquito":Console.WriteLine("esta errado");break;
            default:Console.WriteLine("Não encontrei");break;
        }
        //laços de repetição
        //For ou para 
        //for (inicialização; condição; incremento)
        for(var i = 0;i <=5;i++){
            Console.WriteLine(i);
        }
        for(var numero= 0;numero != 10;numero++){
            Console.WriteLine(numero);
        }
         for(var i = 5;i >=0;i--){
            Console.WriteLine(i);
        }
        }
    }
}
