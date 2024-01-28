using System;
using System.Collections.Generic;

namespace UpShift.Models
{
    public class VeiculoLeilao
    {
        // Propriedades do VeiculoLeilao
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public int TipoCombustivel { get; set; }
        public string Cor { get; set; }
        public int Lugares { get; set; }
        public int Quilometragem { get; set; }
        public int Portas { get; set; }
        public int Potencia { get; set; }
        public decimal PrecoInicial { get; set; }
        public decimal LicitacaoMinima { get; set; }
        public DateTime DataFinalLeilao { get; set; }
        public List<string> ImagensAssociadas { get; set; }
        public List<string> VideosAssociados { get; set; }
        public bool LeilaoAcabou { get; set; }

        public VeiculoLeilao(int id, string modelo, string marca, string titulo, int ano, string descricao,
                             int tipoCombustivel, string cor, int lugares, int quilometragem, int portas,
                             int potencia, decimal precoInicial, decimal licitacaoMinima, DateTime dataFinalLeilao,
                             List<string> imagensAssociadas, List<string> videosAssociados, bool leilaoAcabou)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            Titulo = titulo;
            Ano = ano;
            Descricao = descricao;
            TipoCombustivel = tipoCombustivel;
            Cor = cor;
            Lugares = lugares;
            Quilometragem = quilometragem;
            Portas = portas;
            Potencia = potencia;
            PrecoInicial = precoInicial;
            LicitacaoMinima = licitacaoMinima;
            DataFinalLeilao = dataFinalLeilao;
            ImagensAssociadas = imagensAssociadas;
            VideosAssociados = videosAssociados;
            LeilaoAcabou = leilaoAcabou;
        }
    }
}

