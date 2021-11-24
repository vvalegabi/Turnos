using System.ComponentModel.DataAnnotations;


namespace Turnos.Models
{
    //Los campos de nuestra tabla especialidad en sql server 
    public  class Especialidad 
    {
       [key]
       public int IdEspecialidad{get; set; }
       public string Descripcion{get; set; }
    }
}