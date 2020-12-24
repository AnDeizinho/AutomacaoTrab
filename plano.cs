using System;
using System.Collections.Generic;
namespace BDCorte
{
    namespace Entidade
    {
        public class Plano
        {
            // somente leitura
            public int TotalPcs{get{return GradeTamanhos.TotalPecs;}} // numero de peças somadas da grade
            public double TotalComp{get {return Comp_Risco * Folhas;}} // comprimento do risco multiplicado pelo numero de folhas
            public double Gramadura_real{get{return Peso_Folha / AreaQuadradaRisco;}} // gramatura real pelo peso da folhas para caucular apara
            // somente leitura medias de consumo
            public double MediaConsumo_Metros{get{return TotalComp / TotalPcs;}} // numero de peças total / totalcomp
            public double Mediaconsumo_kilo_gram{get{return Total_kilos_pela_Gram / TotalPcs;}}  
            public double Mediaconsumo_kilo_peso_folha{get{return Total_kilos_por_peso_da_folha / TotalPcs;}}
            // somente leitura cauculos pela gramatura sugerida
            public double AreaQuadradaRisco{get {return this.InfoTecido.LarguraTotal * Comp_Risco;}}
            public double Total_kilos_por_peso_da_folha{get{return Peso_Folha * Folhas;}}
            public double Peso_Da_folha_Pela_Gram{get{return (InfoTecido.Peso_Largura) * Comp_Risco;}}
            public double Total_kilos_pela_Gram{get{return Peso_Da_folha_Pela_Gram * Folhas;}}
            

            // adulteraveis
            public int Id_Plano { get; set; }
            public int Id_InfGerais{get;set;}
            public Tecido InfoTecido{get;set;}
            public double Comp_Risco{get;set;}
            
            public int Folhas{get;set;}
            public double Percentual_Apara_Risco_Gram {get{
                return (TotalAparas / Total_kilos_pela_Gram) * 100;
            }}
            public double Percentual_Apara_Risco_Peso_Folha {get{
                return (TotalAparas / Total_kilos_por_peso_da_folha) * 100;
            }}
            public double TotalAparas{get{
                double tt = 0;
                foreach(Apontamento ap in Apontamentos)
                {
                    tt += ap.Apara_Do_Risco;
                }
                return tt;
            }}

            public double Peso_Folha{get;set;}
            public Grade GradeTamanhos{get;set;}
            public List<Apontamento> Apontamentos {get;set;}

            public Plano(int id_inf, Tecido tec, double comp, int folhas, double peso_folha = 0)
            {
                Id_InfGerais = id_inf;
                Comp_Risco = comp;
                Folhas = folhas;
                Peso_Folha = peso_folha;
                InfoTecido = tec;
                this.GradeTamanhos = new Grade();
                Apontamentos = new List<Apontamento>();
            }
           
        }
    }
}