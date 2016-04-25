using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleToDo_Angular_WebApi.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}