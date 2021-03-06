﻿using com.rightback.ChocAn.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.rightback.ChocAn.DAL
{

    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PoviderID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string StreetAddres { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string Email { get; set; }
        //9 digit provider login code
        [Required]
        public string Code { get; set; }

        [Required]
        public string TerminalCode { get; set; }

        public enum Type
        {
            internist,
            dietitian,
            exercise,
            specialist
        }

        //Navigation 
        public virtual ICollection<Claim> Claims { get; set; }
    }
}
