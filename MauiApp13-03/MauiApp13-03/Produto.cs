using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp13_03
{
    internal class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public static List<Produto> Lista 
        { 
            get
            { 
                List<Produto> lista = new List<Produto>();    
               lista.Add(new Produto() {  Nome = "Nome", Preco = 1 , Categoria = "Categoria "});
               lista.Add(new Produto() {  Nome = "leornado", Preco = 10 , Categoria = "pessoa"});
               lista.Add(new Produto() {  Nome = "celular", Preco = 90 , Categoria = "eletronico "});
               lista.Add(new Produto() {  Nome = "jubileu", Preco = 8 , Categoria = "brinquedo"});
               lista.Add(new Produto() {  Nome = "mazda mx3", Preco = 10000 , Categoria = "carro"});
               lista.Add(new Produto() {  Nome = "mamadeira", Preco = 15 , Categoria = "infantil"});
                
                return lista;
            } 
        }

    }
}
