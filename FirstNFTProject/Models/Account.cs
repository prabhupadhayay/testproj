using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstNFTProject.Models
{
    public class Account
    {
    }

    public class RegisterModel
    {

        [Required]
        public string WalletAddress { get; set; }
    }


    
}