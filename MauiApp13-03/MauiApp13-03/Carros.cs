using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp13_03
{
    internal class Carros
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }

        public static List<Carros> Lista
        {
            get
            {
                List<Carros> lista = new List<Carros>();
                lista.Add(new Carros() { Nome = "Civic", Preco = 85000, Marca = "Honda", Ano = 2022, Cor = "Branco" });
                lista.Add(new Carros() { Nome = "Corolla", Preco = 90000, Marca = "Toyota", Ano = 2023, Cor = "Prata" });
                lista.Add(new Carros() { Nome = "Golf", Preco = 75000, Marca = "Volkswagen", Ano = 2021, Cor = "Preto" });
                lista.Add(new Carros() { Nome = "Mustang", Preco = 300000, Marca = "Ford", Ano = 2023, Cor = "Vermelho" });
                lista.Add(new Carros() { Nome = "320i", Preco = 250000, Marca = "BMW", Ano = 2022, Cor = "Azul" });
                lista.Add(new Carros() { Nome = "A4", Preco = 280000, Marca = "Audi", Ano = 2023, Cor = "Cinza" });
                lista.Add(new Carros() { Nome = "Cruze", Preco = 65000, Marca = "Chevrolet", Ano = 2021, Cor = "Branco" });
                lista.Add(new Carros() { Nome = "Sandero", Preco = 50000, Marca = "Renault", Ano = 2022, Cor = "Prata" });
                lista.Add(new Carros() { Nome = "Argo", Preco = 55000, Marca = "Fiat", Ano = 2023, Cor = "Vermelho" });
                lista.Add(new Carros() { Nome = "HRV", Preco = 95000, Marca = "Honda", Ano = 2022, Cor = "Preto" });
                lista.Add(new Carros() { Nome = "Compass", Preco = 120000, Marca = "Jeep", Ano = 2023, Cor = "Azul" });
                return lista;
            }
        }

    }
}
