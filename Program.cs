using System;

namespace MeuApp
{
    class Tipos
    {
        static void Main(string[] args)
        { 
        
        //Função
        MeuMetodo();
        string nome = RetornaNome("Arthur","Albuquerque");
        Console.WriteLine(nome);
        static void MeuMetodo(){
            Console.WriteLine("C# é legal");
        }
        static string RetornaNome(string nome,string sobrenome){
            return nome +" "+ sobrenome;

        
    }
}}}
