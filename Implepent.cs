using System;
namespace Conversor{
    internal class Conversao
    {
        internal double PesoParaMetros(double Largura, double Gramatura, double Peso)
        {
            Gramatura = Gramatura / 1000;
            
            return Peso / (Largura * Gramatura);
        }
    
         internal double MetrosParaPeso(double Largura,double Gramatura, double Metros)
        {
            Gramatura = Gramatura / 1000;
            return   (Largura * Gramatura) * Metros;

        }
    
        internal double ObterGramatura(double Largura, double Comprimento, double Medida)
        {
            return Medida / (Largura * Comprimento); // peso / (76*2   * comp)
        }
    }
    internal abstract class Peca
    {
        internal double Largura{get;}
        internal double Comprimento{get;}
        internal double DescontoLargura{get;}
        internal double DescontoComprimento{get;}
        internal double LarguraFechada{get {return   descCalcLarg() ;}}
        internal double ComprimentoFechado{get{return Comprimento - DescontoComprimento;}}
        public Peca(double lar, double Comp, double descLar, double DescComp)
        {
            Largura = lar; Comprimento = Comp; DescontoLargura = descLar;
            DescontoComprimento = DescComp;
        }
        public virtual double descCalcLarg()
        {
            return Largura-DescontoLargura;
        }
        public override string ToString()
        {
            return $"Largura Fechada {LarguraFechada}\nComprimento Fechado {ComprimentoFechado}";
        }
        

    }
    internal sealed class Frente : Peca{
        public Frente(double lar, double comp, double desclar, double descomp)
            :base(lar,comp,desclar,descomp)
        {

        }
    }
    internal sealed class Costa : Peca{
        
        public Costa(double lar, double comp, double desclar, double descomp)
            :base(lar,comp,desclar,descomp)
        {

        }
    }
    internal sealed class ToraxSocial
    {
        internal Frente Esquerda{get;}
        internal Frente Direita{get;}
        internal Costa Costa{get;}
        public override string ToString()
        {
            return "" +(Esquerda.LarguraFechada + Direita.LarguraFechada - 3 + Costa.LarguraFechada) /2;
        }
        internal ToraxSocial(Frente esq, Frente dir, Costa cost )
        {
            Esquerda = esq;
            Direita=dir;
            Costa=cost;
        }
    }
    
}