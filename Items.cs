using System;

namespace BackPack
{
    class Items
    {
        public Items(string nombreCompleto, int Peso, string Iniciales){
            this.nombreCompleto = nombreCompleto;
            this.Peso = Peso;
            this.Iniciales = Iniciales;
        }
        public string nombreCompleto(){
            return nombreCompleto;
        }
        public int Peso(){
            return Peso;
        }
        public string Iniciales(){
            return Iniciales;
        }
    }
}