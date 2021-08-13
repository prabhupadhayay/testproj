using FirstNFTProject.Models;
using Ipfs;
using Nethereum.Web3;
using NFT.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FirstNFTProject.Controllers
{
    public class NftController : Controller
    {

        NFTProjectEntities NFTProjectEntities = new NFTProjectEntities();

        #region Not used test only 
        public async Task<ActionResult> Index()
            {
            try
            {
               
                //await Helpers.SmartContract.Deploy();
                //await Helpers.SmartContract.callRPCAsync();
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ActionResult> CallRPC()
        {
            try
            {
              //  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
              //                                     | SecurityProtocolType.Tls11
              //                                     | SecurityProtocolType.Tls12
              //                                     | SecurityProtocolType.Ssl3;

              ////  var web3 = new Nethereum.Web3.Web3();
              //  var web3 = new Web3("https://ropsten.infura.io/v3/80027fdf3ae7419d8ff275e66a6c6b43");

              //  #region ABI
              //  var abi = "[{\"inputs\":[],\"name\":\"checkIfFundingCompleteOrExpired\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"contribute\",\"outputs\":[],\"stateMutability\":\"payable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address payable\",\"name\":\"projectStarter\",\"type\":\"address\"},{\"internalType\":\"string\",\"name\":\"projectTitle\",\"type\":\"string\"},{\"internalType\":\"string\",\"name\":\"projectDesc\",\"type\":\"string\"},{\"internalType\":\"uint256\",\"name\":\"fundRaisingDeadline\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"goalAmount\",\"type\":\"uint256\"}],\"stateMutability\":\"nonpayable\",\"type\":\"constructor\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"address\",\"name\":\"recipient\",\"type\":\"address\"}],\"name\":\"CreatorPaid\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"address\",\"name\":\"contributor\",\"type\":\"address\"},{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"amount\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"currentTotal\",\"type\":\"uint256\"}],\"name\":\"FundingReceived\",\"type\":\"event\"},{\"inputs\":[],\"name\":\"getRefund\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"amountGoal\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"completeAt\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"name\":\"contributions\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"creator\",\"outputs\":[{\"internalType\":\"address payable\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"currentBalance\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"description\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getDetails\",\"outputs\":[{\"internalType\":\"address payable\",\"name\":\"projectStarter\",\"type\":\"address\"},{\"internalType\":\"string\",\"name\":\"projectTitle\",\"type\":\"string\"},{\"internalType\":\"string\",\"name\":\"projectDesc\",\"type\":\"string\"},{\"internalType\":\"uint256\",\"name\":\"deadline\",\"type\":\"uint256\"},{\"internalType\":\"enum Project.State\",\"name\":\"currentState\",\"type\":\"uint8\"},{\"internalType\":\"uint256\",\"name\":\"currentAmount\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"goalAmount\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"raiseBy\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"state\",\"outputs\":[{\"internalType\":\"enum Project.State\",\"name\":\"\",\"type\":\"uint8\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"title\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";

              //  #endregion

              //  var contractAddress = "0x6BD789cCD104e4F5b1d97367702aB7eafd503A26";
                
              //  var contract = web3.Eth.GetContract(abi, contractAddress);
              
              //  var testFunction = contract.GetFunction("title");
               
              //  var balanceFirstAmountSend = await testFunction.CallAsync<string>();

              //  ViewBag.Message = balanceFirstAmountSend;
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ActionResult> nft()
        {
            try
            {
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                //                                   | SecurityProtocolType.Tls11
                //                                   | SecurityProtocolType.Tls12
                //                                   | SecurityProtocolType.Ssl3;

                ////  var web3 = new Nethereum.Web3.Web3();
                //var web3 = new Web3("https://ropsten.infura.io/v3/80027fdf3ae7419d8ff275e66a6c6b43");

                //#region ABI
                //var abi = "[{\"inputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"constructor\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"internalType\":\"address\",\"name\":\"previousOwner\",\"type\":\"address\"},{\"indexed\":true,\"internalType\":\"address\",\"name\":\"newOwner\",\"type\":\"address\"}],\"name\":\"OwnershipTransferred\",\"type\":\"event\"},{\"inputs\":[],\"name\":\"CANNOT_TRANSFER_TO_ZERO_ADDRESS\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"NOT_CURRENT_OWNER\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"owner\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"_newOwner\",\"type\":\"address\"}],\"name\":\"transferOwnership\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"}]";

                //#endregion

                //var contractAddress = "0x1E2ea36C4808b5eE183E17866844e3De5C2DD730";

                //var contract = web3.Eth.GetContract(abi, contractAddress);

                //var testFunction = contract.GetFunction("owner");

                //var balanceFirstAmountSend = await testFunction.CallAsync<string>();

                //ViewBag.Message = balanceFirstAmountSend;
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> uploadtoIPFS()
        {
            try
            {
                UploadNftParameteres uploadNftParameteres = new UploadNftParameteres();

                return View(uploadNftParameteres);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uploadNftParameteres"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Upload(UploadNftParameteres uploadNftParameteres)
        {
            //check if User Logged in or not 

            if(Session["UserSessionStart"] != null)
            {
                if(Session["UserId"] != null)
                {

                    if(bool.Parse(Session["UserSessionStart"].ToString()) == true)
                    {
                        if (Request.Files.Count > 0)
                        {
                            if (!ModelState.IsValid)
                            {
                                return RedirectToAction("uploadtoIPFS", "nft");
                            }

                            HttpPostedFileBase postedFile = Request.Files["postedFile"];
                            string path = Server.MapPath("~/Uploads/");
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }

                            postedFile.SaveAs(path + Path.GetFileName(postedFile.FileName));
                            //TempData["Message"] = "File uploaded successfully.";
                            //call Helper method to save on IPFS

                            var Hash = await Helpers.IpfsHelper.UploadSingleFile(postedFile.FileName);
                            var userId = Session["UserId"].ToString();
                            int userId2 = int.Parse(userId);
                            NFT.DAL.Item item = new NFT.DAL.Item();
                            item.ItemHash = Hash;
                            item.UserId = userId2;
                            item.ItemName = uploadNftParameteres.NFTName;
                            item.ItemSymbol = uploadNftParameteres.NFTSymbol;
                            NFTProjectEntities.Items.Add(item);
                            NFTProjectEntities.SaveChanges();
                            TempData["Message"] = "Uploaded Successfully.Unique Hash - " + Hash;
                            ViewBag.Message = "Uploaded Successfully";
                            return RedirectToAction("GetyourUploads", "nft");
                        }
                    }
                    return RedirectToAction("Register", "Accounts");
                }
                return RedirectToAction("Register", "Accounts");
            }
            else
            {
                return RedirectToAction("Register", "Accounts");
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> GetyourUploads()
        {
            //check if User Logged in or not 
            try
            {
                if (Session["UserSessionStart"] != null)
                {
                    if (Session["UserId"] != null)
                    {

                        if (bool.Parse(Session["UserSessionStart"].ToString()) == true)
                        {
                            var userId = Session["UserId"].ToString();
                            int cID = int.Parse(userId);
                            var getItems = NFTProjectEntities.Items.Where(a => a.UserId == cID);
                            List<ImageModel> imageModelList = new List<ImageModel>();
                            if (getItems != null)
                            {
                                foreach (var ge in getItems.ToList())
                                {
                                    ImageModel imageModel = new ImageModel();
                                    imageModel.ItemId = ge.ItemId;
                                    string Hash = ge.ItemHash;
                                    //Show Images directly from IPFs
                                    imageModel.ImageUrl = "https://gateway.ipfs.io/ipfs/" + Hash;
                                    imageModel.NFTSymbol = ge.ItemSymbol;
                                    imageModel.NFTName = ge.ItemName;
                                    imageModelList.Add(imageModel);
                                }
                                return View(imageModelList);
                            }

                            return View(imageModelList);
                        }
                        return RedirectToAction("Register", "Accounts");
                    }
                    return RedirectToAction("Register", "Accounts");
                }
                else
                {
                    return RedirectToAction("Register", "Accounts");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #region Sell NFT
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ItemId"></param>
        /// <returns></returns>
        public async Task<ActionResult> SellNFT(int ItemId)
        {
            //check if User Logged in or not 

            if (Session["UserSessionStart"] != null)
            {
                if (Session["UserId"] != null)
                {

                    if (bool.Parse(Session["UserSessionStart"].ToString()) == true)
                    {
                        //get values from database for NFT Smart contract Deployment 

                        var DeploymentValue = NFTProjectEntities.Items.Where(a => a.ItemId == ItemId).SingleOrDefault();

                        //Prepare Parms 
                        string Url = "https://gateway.ipfs.io/ipfs/" + DeploymentValue.ItemHash;


                        //call MEthod to deploy NFT Smart contract 

                        DeployedSmartcontractResponse deployedSmartcontractResponse = await Helpers.SmartContract.callRPCAsync(Url, DeploymentValue.User.WalletAddress, DeploymentValue.ItemName, DeploymentValue.ItemSymbol);


                            var userId = Session["UserId"].ToString();
                            int userId2 = int.Parse(userId);
                            deployednft deployednft = new deployednft();
                            deployednft.ContractAddress = deployedSmartcontractResponse.ContractAddress;
                            deployednft.ABI = deployedSmartcontractResponse.ByteCode;
                            deployednft.ItemId = ItemId;
                            deployednft.OwnerWalletAddress = deployedSmartcontractResponse.OwnerOfToken;
                            
                            deployednft.DeployedDatetime = DateTime.Now;
                            NFTProjectEntities.deployednfts.Add(deployednft);
                            NFTProjectEntities.SaveChanges();
                            //TempData["Message"] = "Uploaded Successfully.Unique Hash - " + Hash;
                            ViewBag.Message = "Created Successfully";
                            return RedirectToAction("MarketPlace", "nft");
                       
                    }
                    return RedirectToAction("Register", "Accounts");
                }
                return RedirectToAction("Register", "Accounts");
            }
            else
            {
                return RedirectToAction("Register", "Accounts");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> MarketPlace()
        {
            //check if User Logged in or not 
            try
            {
                if (Session["UserSessionStart"] != null)
                {
                    if (Session["UserId"] != null)
                    {

                        if (bool.Parse(Session["UserSessionStart"].ToString()) == true)
                        {
                            var userId = Session["UserId"].ToString();
                            int cID = int.Parse(userId);
                            var getItems = NFTProjectEntities.deployednfts;
                            List<DeployedMarketplace> imageModelList = new List<DeployedMarketplace>();
                            if (getItems != null)
                            {
                                foreach (var ge in getItems.ToList())
                                {
                                    DeployedMarketplace imageModel = new DeployedMarketplace();

                                    //string OnwerAddress = await Helpers.SmartContract.Owner(ge.ContractAddress);

                                    //var deployedNFT = NFTProjectEntities.deployednfts.Where(a => a.Id == ge.Id).SingleOrDefault();
                                    //deployedNFT.OwnerWalletAddress = OnwerAddress;
                                    //NFTProjectEntities.Entry(deployedNFT).State = EntityState.Modified;
                                    //NFTProjectEntities.SaveChanges();

                                    string Hash = ge.Item.ItemHash;
                                    //Show Images directly from IPFs
                                    imageModel.ImageUrl = "https://gateway.ipfs.io/ipfs/" + Hash;
                                    imageModel.SmartContractId = ge.Id;
                                    imageModel.ItemId = ge.ItemId;
                                    imageModel.ownerWalletAddress = ge.OwnerWalletAddress;
                                    imageModel.ContractAddress = ge.ContractAddress;
                                    imageModel.NFTSymbol = ge.Item.ItemSymbol;
                                    imageModel.NFTName = ge.Item.ItemSymbol;
                                    if (ge.Item.UserId != cID)
                                    {
                                      
                                        if(ge.IsApproved == true)
                                        {
                                            imageModel.ShowBuyNowButton = true;
                                        }
                                        else
                                        {
                                            imageModel.ShowBuyNowButton = false;
                                        }
                                        
                                    }
                                    else
                                    {
                                        imageModel.ShowBuyNowButton = false;
                                    }
                                    imageModelList.Add(imageModel);
                                }
                                return View(imageModelList);
                            }

                            return View(imageModelList);
                        }
                        return RedirectToAction("Register", "Accounts");
                    }
                    return RedirectToAction("Register", "Accounts");
                }
                else
                {
                    return RedirectToAction("Register", "Accounts");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region Purchase NFT
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult PurchaseRequest(int Id)
        {
            //check if User Logged in or not 
            try
            {
                if (Session["UserSessionStart"] != null)
                {
                    if (Session["UserId"] != null)
                    {

                        if (bool.Parse(Session["UserSessionStart"].ToString()) == true)
                        {
                            var userId = Session["UserId"].ToString();
                            int cID = int.Parse(userId);
                            var getItems = NFTProjectEntities.deployednfts.Where(a => a.Id == Id).SingleOrDefault();
                            List<DeployedMarketplace> imageModelList = new List<DeployedMarketplace>();
                            if (getItems != null)
                            {
                                //Find Wallet Address for current logged in User 
                                var TowalletAddress = NFTProjectEntities.Users.Where(a => a.UserId == cID).SingleOrDefault();

                                Approvenft approvenft = new Approvenft();
                                approvenft.ToCurrentOwnerAddress = getItems.OwnerWalletAddress;
                                approvenft.FromAddress = TowalletAddress.WalletAddress;
                                approvenft.DeployedNFTId = getItems.Id;
                                approvenft.createDateTime = DateTime.Now;
                                NFTProjectEntities.Approvenfts.Add(approvenft);
                                NFTProjectEntities.SaveChanges();
                                return View(imageModelList);
                            }

                            return View(imageModelList);
                        }
                        return RedirectToAction("Register", "Accounts");
                    }
                    return RedirectToAction("Register", "Accounts");
                }
                else
                {
                    return RedirectToAction("Register", "Accounts");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public ActionResult ApprovalList()
        {
            //check if User Logged in or not 
            //check if User Logged in or not 
            try
            {
                if (Session["UserSessionStart"] != null)
                {
                    if (Session["UserId"] != null)
                    {

                        if (bool.Parse(Session["UserSessionStart"].ToString()) == true)
                        {
                            var userId = Session["UserId"].ToString();
                            int cID = int.Parse(userId);
                            var getUserDetails = NFTProjectEntities.Users.Where(a => a.UserId == cID).SingleOrDefault();
                            var getItems = NFTProjectEntities.deployednfts.Where(a=> a.OwnerWalletAddress == getUserDetails.WalletAddress && a.IsApproved == false);
                            List<DeployedMarketplace> imageModelList = new List<DeployedMarketplace>();
                            if (getItems != null)
                            {
                                foreach (var ge in getItems.ToList())
                                {
                                    DeployedMarketplace imageModel = new DeployedMarketplace();

                                    //string OnwerAddress = await Helpers.SmartContract.Owner(ge.ContractAddress);

                                    //var deployedNFT = NFTProjectEntities.deployednfts.Where(a => a.Id == ge.Id).SingleOrDefault();
                                    //deployedNFT.OwnerWalletAddress = OnwerAddress;
                                    //NFTProjectEntities.Entry(deployedNFT).State = EntityState.Modified;
                                    //NFTProjectEntities.SaveChanges();

                                    string Hash = ge.Item.ItemHash;
                                    //Show Images directly from IPFs
                                    imageModel.ImageUrl = "https://gateway.ipfs.io/ipfs/" + Hash;
                                    imageModel.SmartContractId = ge.Id;
                                    imageModel.ItemId = ge.ItemId;
                                    imageModel.ownerWalletAddress = ge.OwnerWalletAddress;
                                    imageModel.ContractAddress = ge.ContractAddress;
                                    imageModel.NFTSymbol = ge.Item.ItemSymbol;
                                    imageModel.NFTName = ge.Item.ItemSymbol;
                                    imageModel.ShowBuyNowButton = true;
                                    //if (ge.Item.UserId != cID)
                                    //{
                                    //    int approvenft = NFTProjectEntities.Approvenfts.Where(a => a.DeployedNFTId == ge.Id && a.IsApproved == true).Count();
                                    //    if (approvenft > 0)
                                    //    {
                                    //        imageModel.ShowBuyNowButton = true;
                                    //    }
                                    //    imageModel.ShowBuyNowButton = false;
                                    //}
                                    //else
                                    //{
                                    //    imageModel.ShowBuyNowButton = false;
                                    //}
                                    imageModelList.Add(imageModel);
                                }
                                return View(imageModelList);
                            }

                            return View(imageModelList);
                        }
                        return RedirectToAction("Register", "Accounts");
                    }
                    return RedirectToAction("Register", "Accounts");
                }
                else
                {
                    return RedirectToAction("Register", "Accounts");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        #endregion

        [HttpPost]
        public JsonResult ApproveNFTtoSale(int NFTDeployId)
        {
            try
            {

                var deployedContract = NFTProjectEntities.deployednfts.Where(a => a.Id == NFTDeployId).SingleOrDefault();
                deployedContract.IsApproved = true;
                NFTProjectEntities.Entry(deployedContract).State = EntityState.Modified;
                NFTProjectEntities.SaveChanges();


                return Json("Success");
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);

            }


        }


        [HttpPost]
        public async Task<JsonResult> Transfer(int NFTDeployId)
        {
            try
            {
                if (Session["UserSessionStart"] != null)
                {
                    if (Session["UserId"] != null)
                    {
                        var userId = Session["UserId"].ToString();
                        int cID = int.Parse(userId);
                        var getUserDetails = NFTProjectEntities.Users.Where(a => a.UserId == cID).SingleOrDefault();

                        var deployedContract = NFTProjectEntities.deployednfts.Where(a => a.Id == NFTDeployId).SingleOrDefault();
                        //call helper method 

                        await Helpers.SmartContract.TransferToken(deployedContract.ContractAddress, getUserDetails.WalletAddress);


                    }
                }

                return Json("Failed");
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);

            }


        }



    }
}