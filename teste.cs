using System;
namespace Conversor
{
    class programa
    {
        public static void Main()
        {
            var con1 = new Conversao();
            var con2 = new Conversao();
            var con3 = new Conversao();
            Console.WriteLine(con1.PesoParaMetros(1.40,160,5));
            Console.WriteLine(con2.MetrosParaPeso(1.52,1037,3.68));
            Console.WriteLine(con3.ObterGramatura(0.76 * 2, 3.68, 0.580));
            
            ToraxSocial Tor = new ToraxSocial(new Frente(37,64,8,4), new Frente(32,64,3,4),new Costa(62,64,4,4));
            Console.WriteLine("direite {0}\nEsquerda {1}\nCosta {2}",Tor.Direita, Tor.Esquerda, Tor.Costa);
            Console.WriteLine("largura do torax " + Tor );
            Console.ReadKey();
        }
    }
}