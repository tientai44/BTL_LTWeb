using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using NotUseAuto.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NotUseAuto.Models
{
    
    public class ApplicationUser:IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override string Id { get => base.Id; set => base.Id = value; }
        public string Image { get;set; }
        public string FullName { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }

        
        

    }
}
