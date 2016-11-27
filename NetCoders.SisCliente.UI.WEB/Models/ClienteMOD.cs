using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NetCoders.SisCliente.UI.WEB.Models
{
    [Table("TB_CLIENTE")]
    public class ClienteMOD
    {
        [Key]
        [Required]
        public int Codigo { get; set; }

        [Required]
        public String TipoMercadoria { get; set; }

        //O Data Anottations Required, Serve pra dizer que a minha propriedade
        //é obrigatória.
        [Required(ErrorMessage = "Este campo é obrogatório")]
        public string NomeMercadoria { get; set; }

        [Required(ErrorMessage = "Este campo é obrogatório")]
        public int QtdMercadoria { get; set; }

        [Required(ErrorMessage = "Este campo é obrogatório")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Este campo é obrogatório")]
        public int TipoNegocio { get; set; }

       
    }
}