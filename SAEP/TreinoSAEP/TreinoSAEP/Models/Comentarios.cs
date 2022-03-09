using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreinoSAEP.Models
{
    public class Comentarios
    {
        [Key]
        public string Id { get; set; }
        public string Comentario { get; set; }

        [ForeignKey("Perfis")]
        public int IdPerfil { get; set; }
        public Perfis Perfis { get; set; }

        [ForeignKey("Equipamentos")]

        public int IdEquipamento { get; set; }
        public Equipamentos Equipamentos { get; set; }

        public DateTime Data { get; set; }



    }
}
