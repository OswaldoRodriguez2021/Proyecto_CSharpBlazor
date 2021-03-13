using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorExpenseTracker.Model
{
    public class Category
    {
        public int Id { get; set; }

        /** Para utilizar el requierd Instalar el paquete 
            System.ComponentModel.Annotations
       
        restricciones adicionales que podemos aplicar 
        [Range(1,18)         Rango de numeros solo permitiria valores entre 1 y 18
        [StringLength(100)]  En este ejemplo solo permitira 100 caracteres  
        [EmailAddress]       Solo permite formatos de correo electronico   
        [MaxLength(10)]
        [MinLength(1940)]

        **/

        [Required(AllowEmptyStrings =false ,ErrorMessage = "Ingrese el nombre de la categoria")]
        
        public string Name { get; set; }
    
    }

}
