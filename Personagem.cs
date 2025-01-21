using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auladepoo
{
    public class Personagem 
    {
        private string nome;
        private Inventario inventario;
        private SistemaCombate combate;
        
        public Personagem(string nome){
            this.nome = nome;
            this.inventario = new Inventario();
            this.combate = new SistemaCombate();
        }   
        public void PegarItem(string item){
            inventario.AdicionarItem(item);
        }
        public void LargarItem(string item){
            inventario.RemoverItem(item);
        }
        public void Atacar(string alvo){
            combate.Atacar(alvo);
        }
        public void MostrarInventario(){
            Console.WriteLine($"Inventário de {nome}: ");
            inventario.ExibirItens();
        }
     }
}