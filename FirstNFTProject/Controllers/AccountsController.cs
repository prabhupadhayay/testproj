using FirstNFTProject.Models;
using NFT.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstNFTProject.Controllers
{
    public class AccountsController : Controller
    {
        NFTProjectEntities NFTProjectEntities = new NFTProjectEntities();
        // GET: Accounts
        public ActionResult Register()
        {

            //RegisterModel registerModel = new RegisterModel();

            return View();
        }

        [HttpPost]
        public ActionResult Register(string WalletAddress)
        {
            try
            {
                if (string.IsNullOrEmpty(WalletAddress))
                {
                    return View();
                }

                //Add User with its wallet address 

                //Check if wallet address already present or not 

                int chkWalletAddressPresnt = NFTProjectEntities.Users.Where(a => a.WalletAddress == WalletAddress).Count();

                if (chkWalletAddressPresnt > 0)
                {

                    var UserDetails = NFTProjectEntities.Users.Where(a => a.WalletAddress == WalletAddress).SingleOrDefault();

                    Session["UserSessionStart"] = true;
                    Session["UserId"] = UserDetails.UserId;
                    return RedirectToAction("GetyourUploads", "nft");
                }
                else
                {
                    User user = new User();
                    user.WalletAddress = WalletAddress;
                    NFTProjectEntities.Users.Add(user);
                    NFTProjectEntities.SaveChanges();

                    Session["UserSessionStart"] = true;
                    Session["UserId"] = user.UserId;
                    return RedirectToAction("GetyourUploads", "nft");

                }
            }
           catch(Exception ex)
            {
                throw ex;
            }
        }


        public ActionResult Logout()
        {
            try
            {
              
                if(Session["UserSessionStart"] != null)
                {
                    Session["UserSessionStart"] = false;
                    Session["UserSessionStart"] = null;
                    Session["UserId"] = null;
                    return RedirectToAction("Register", "Accounts");
                }
                return RedirectToAction("Register", "Accounts");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}