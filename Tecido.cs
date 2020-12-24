using System;
namespace BDCorte
{
    namespace Entidade
    {
        public enum Textil{Camisaria, Malharia, Brim_Leve, Brim_Pesado, Tecido_Plano}
        public struct Tecido
        {
            public Textil Tipo {get;set;}
            public string Nome{get;set;}
            
            public double LarguraTotal{get;set;}
            public string Fornecedor{get;set;}
            public string Cor{get;set;}
            public double Gramatura{get;set;}
            
            public double Peso_Largura {get {return Gramatura * LarguraTotal;}}
            
            public Tecido(Textil tip, string nome, double larg, string cor, string fornecedor="", double gram = 0)
            {
                Tipo = tip;
                Nome= nome;
                LarguraTotal = larg;
                Cor = cor;
                Fornecedor = fornecedor;
                Gramatura = gram;
            }
            
        }
    }
}