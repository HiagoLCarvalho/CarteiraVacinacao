using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace carteiravacina.Models
{
    
    public class Animal
    {
        public Animal(int id, string nome, int idEspecie, int idRaca, int idSexo, DateTime dtNascimento, string pelagem, int idSituacao, float peso)
        {
            this.Id = id;
            this.Nome = nome;
            this.IdEspecie = idEspecie;
            this.IdRaca = idRaca;
            this.IdSexo = idSexo;
            this.DtNascimento = dtNascimento;
            this.Pelagem = pelagem;
            this.IdSituacao = idSituacao;
            this.Peso = peso;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdEspecie { get; set;}
        public int IdRaca { get; set; }
        public int IdSexo { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Pelagem { get; set; }
        public int IdSituacao { get; set; }
        public float Peso { get; set; }

        
    }
}