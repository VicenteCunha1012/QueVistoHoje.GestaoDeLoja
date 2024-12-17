// Encomenda.cs
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueVistoHoje.GestaoDeLoja.Data.Entities
{
    public class Encomenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Estado { get; set; }
        public string EnderecoEntrega { get; set; }
        public ApplicationUser Cliente { get; set; }

        public List<EncomendaProduto> EncomendaProdutos { get; set; } = new(); // New list to handle the relationship


        public Encomenda()
        {
            EncomendaProdutos = new List<EncomendaProduto>(); // Initialize the list
        }
    }
}