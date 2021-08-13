using Nethereum.Web3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace FirstNFTProject.Helpers
{
    public class InfuraHelper
    {
        public static async System.Threading.Tasks.Task<string> callRPCAsync()
        {

            try
            {

                var web3 = new Web3("https://ropsten.infura.io/v3/80027fdf3ae7419d8ff275e66a6c6b43");
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                | SecurityProtocolType.Tls11
                                                | SecurityProtocolType.Tls12
                                                | SecurityProtocolType.Ssl3;

                #region ABI
                var abi = "[{\"inputs\":[],\"name\":\"checkIfFundingCompleteOrExpired\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"contribute\",\"outputs\":[],\"stateMutability\":\"payable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address payable\",\"name\":\"projectStarter\",\"type\":\"address\"},{\"internalType\":\"string\",\"name\":\"projectTitle\",\"type\":\"string\"},{\"internalType\":\"string\",\"name\":\"projectDesc\",\"type\":\"string\"},{\"internalType\":\"uint256\",\"name\":\"fundRaisingDeadline\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"goalAmount\",\"type\":\"uint256\"}],\"stateMutability\":\"nonpayable\",\"type\":\"constructor\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"address\",\"name\":\"recipient\",\"type\":\"address\"}],\"name\":\"CreatorPaid\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":false,\"internalType\":\"address\",\"name\":\"contributor\",\"type\":\"address\"},{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"amount\",\"type\":\"uint256\"},{\"indexed\":false,\"internalType\":\"uint256\",\"name\":\"currentTotal\",\"type\":\"uint256\"}],\"name\":\"FundingReceived\",\"type\":\"event\"},{\"inputs\":[],\"name\":\"getRefund\",\"outputs\":[{\"internalType\":\"bool\",\"name\":\"\",\"type\":\"bool\"}],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"amountGoal\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"completeAt\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"name\":\"contributions\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"creator\",\"outputs\":[{\"internalType\":\"address payable\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"currentBalance\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"description\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"getDetails\",\"outputs\":[{\"internalType\":\"address payable\",\"name\":\"projectStarter\",\"type\":\"address\"},{\"internalType\":\"string\",\"name\":\"projectTitle\",\"type\":\"string\"},{\"internalType\":\"string\",\"name\":\"projectDesc\",\"type\":\"string\"},{\"internalType\":\"uint256\",\"name\":\"deadline\",\"type\":\"uint256\"},{\"internalType\":\"enum Project.State\",\"name\":\"currentState\",\"type\":\"uint8\"},{\"internalType\":\"uint256\",\"name\":\"currentAmount\",\"type\":\"uint256\"},{\"internalType\":\"uint256\",\"name\":\"goalAmount\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"raiseBy\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"state\",\"outputs\":[{\"internalType\":\"enum Project.State\",\"name\":\"\",\"type\":\"uint8\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"title\",\"outputs\":[{\"internalType\":\"string\",\"name\":\"\",\"type\":\"string\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";

                #endregion

                var contractAddress = "0x6BD789cCD104e4F5b1d97367702aB7eafd503A26";

                var contract = web3.Eth.GetContract(abi, contractAddress);

                var testFunction = contract.GetFunction("creator");

                var balanceFirstAmountSend = await testFunction.CallAsync<string>();


                return balanceFirstAmountSend;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}