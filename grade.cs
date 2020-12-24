using System;
namespace BDCorte
{
    namespace Entidade
    {
        public class Grade
        {
            public int PP { get; set; }
            public int P{get;set;}
            public int M{get;set;}
            public int G{get;set;}
            public int GG{get;set;}
            public int EXG{get;set;}
            public int EXGG{get;set;}
            public int SM{get;set;}
            public int TotalPecs{get {return soma();}}
            public Grade(int pp = 0, int p = 0, int m = 0, int g = 0, int gg = 0, int exg = 0, int exgg = 0, int sm = 0 )
            {
                PP = pp;
                P=p;
                M=m;
                G=g;
                GG=gg;
                EXG=exg;
                EXGG=exgg;
                SM=sm;
            }
            int soma()
            {
                return PP + P + M + G + GG + EXG + EXGG + SM;
            }
        }
    }
}