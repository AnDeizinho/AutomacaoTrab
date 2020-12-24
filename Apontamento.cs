using System;

namespace BDCorte
{
    namespace Entidade
    {
        public struct Apontamento
        {
            public int Id_Apontamento{get;set;}
            public int Id_Plano{get;set;}
            public DateTime Conclusao {get;set;}
            public int Qtd_Folhas_Cortadas {get;set;}
            public Grade TamanhosCortados {get;set;}
            public double Apara_Do_Risco{get;set;}

            public Apontamento(int id_plano,DateTime conc, int qtd, double apa, int id_apt = 0)
            {
                Id_Apontamento= id_apt;
                Id_Plano = id_plano;
                TamanhosCortados = new Grade();
                Conclusao = conc;
                Qtd_Folhas_Cortadas = qtd;
                Apara_Do_Risco = apa;
            }
            
        }
    }
}