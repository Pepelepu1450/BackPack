using System;

namespace BackPack
{
    class Program
    {
        static void Main(string[] args)
        {
            Items Cuerda = new Items ("Cuerda", 1000,"C");
            Items BotellaDeAgua = new Items ("Botella de agua", 1010, "A");
            Items Manzana = new Items ("Manzana", 250, "M");
            Items Pan = new Items ("Pan", 70, "P");
            Items Brujula = new Items ("Brujula", 350, "B");
            Items PapelDeBaño = new Items ("Papel de baño", 320, "PB");
            Items Platano = new Items ("Patano", 80, "PL");
            Items Nada = new Items ("Nada", 0, "X");
        }
        BackPack backpack  = new BackPack(
            new int [3,4]{
                {X, B, PB, X},
                {PL, A, C, P},
                {Pl, A, C, M}
            },
            3,4
        );
        
    }
}        