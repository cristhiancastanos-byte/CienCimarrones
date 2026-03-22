using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 

namespace ProyectoFinal.Models 
{
    public class Pregunta
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; } = "";

        public string Respuesta1 { get; set; } = "";
        public int Puntos1 { get; set; }

        public string Respuesta2 { get; set; } = "";
        public int Puntos2 { get; set; }

        public string Respuesta3 { get; set; } = "";
        public int Puntos3 { get; set; }

        public string Respuesta4 { get; set; } = "";
        public int Puntos4 { get; set; }

        public string Respuesta5 { get; set; } = "";
        public int Puntos5 { get; set; }
    }
}