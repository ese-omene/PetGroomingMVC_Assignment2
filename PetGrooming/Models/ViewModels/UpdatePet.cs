using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetGrooming.Models.ViewModels
{
    public class UpdatePet
    {
        //what info do we need?
        //list of species and individual pet

       public Pet pet { get; set; }
        
       public ICollection<Species> species { get; set; }

    }
}