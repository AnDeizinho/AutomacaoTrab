using System;
using System.Collections.Generic;
namespace BDCorte
{
    namespace Entidade
    {
        
        public class InfGerais
        {
            public int Id_Gerais { get; set; }
            public DateTime Emissao { get; set; }
            public DateTime Entrega { get; set; }
            public DateTime Conclusao_Corte{get;set;}
            public string Cliente{get;set;}
            public string Modelo{get;set;}
            public string Descricao{get;set;}
            public string CIP{get;set;}
            public Grade GradeTamanhoTotal{get;set;}
            public List<Plano> PlanoDoCorte {get;set;}
            public InfGerais(string cliente, string modelo, string descricao, string cip)
            {
                GradeTamanhoTotal = new Grade();
                PlanoDoCorte = new List<Plano>();
                Cliente = cliente;
                Modelo=modelo;
                Descricao=descricao;
                CIP=cip;
                Emissao = DateTime.Now;
            }


        }
    }
}