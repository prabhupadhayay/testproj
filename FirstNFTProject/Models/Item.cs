using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstNFTProject.Models
{
    public class Item
    {
    }

    public class DeployedSmartcontractResponse
    {
        public string ByteCode { get; set; }
        public string ContractAddress { get; set; }
        public string GasPrice { get; set; }
        public string NFTSymbol { get; set; }
        public string NFTName { get; set; }
        public string OwnerOfToken { get; set; }
    }
}