using System;

namespace Senai.Projeto.Final.Final.web.Mvc.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public DateTime DataCriacao { get; set; }
        public UsuarioModel Usuario { get; set; }

        public ComentarioModel(int Id, string Comentario, DateTime DataCriacao, UsuarioModel Usuario){
            this.Id = id;
            this.Comentario = comentario;
            this.DataCriacao = dataCriacao;
            this.Usuario = usuario;
        }
    }
}