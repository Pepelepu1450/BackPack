using System;

namespace BackPack
{
    class BackPack
    {
        public Items[,]  BackMatrix;
        private int ileraX;
        private int ileraY;

        public BackPack (Items[,] BackMatrix, int ileraX, int ileraY){
            this.BackMatrix= BackMatrix;
            this.ileraX = ileraX;
            this.ileraY = ileraY;
        }

        public void PrintBackpack(){
            for(int y = 0 ; y < this.gridSize; y++)
            {

                for(int x = 0; x < this.gridSize; x++){

                    Console.WriteLine(this.grid[y,x]);
                }
                Console.WriteLine();
            }
        }
        //TODO: poner los if de cada ilera vertical para saber si los objetos se estan aplastando

    }
}
