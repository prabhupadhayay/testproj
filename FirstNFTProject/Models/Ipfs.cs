using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstNFTProject.Models
{
    public class Ipfs
    {
    }

    public class ImageModel
    {
        public string ImageUrl { get; set; }
        public int ItemId { get; set; }
        public string WalletAddress { get; set; }
        public string NFTName { get; set; }
        public string NFTSymbol { get; set; }
    }


    public class DeployedMarketplace
    {
        public string ImageUrl { get; set; }

        public string  ownerWalletAddress { get; set; }

        public int ItemId { get; set; }
        public int SmartContractId { get; set; }
        public string ContractAddress { get; set; }
        public string NFTName { get; set; }
        public string NFTSymbol { get; set; }
        public bool ShowBuyNowButton { get; set; }
    }

    public class UploadNftParameteres
    {
        [Required]
        public string NFTName { get; set; }
        [Required]
        public string NFTSymbol { get; set; }
    }
}