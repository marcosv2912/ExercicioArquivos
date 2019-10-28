﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioArquivos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double Total()
        {
            return Preco * Quantidade;
        }
    }
}
