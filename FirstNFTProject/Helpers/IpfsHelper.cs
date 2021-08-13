using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Ipfs.Http;
using Ipfs;


namespace FirstNFTProject.Helpers
{
    public class IpfsHelper
    {

        static readonly Ipfs.IpfsClient ipfs = new Ipfs.IpfsClient(("https://ipfs.infura.io:5001"));

        static readonly Ipfs.Http.IpfsClient ipfs1 = new Ipfs.Http.IpfsClient();
        public static async System.Threading.Tasks.Task<string> UploadtoIPFSAsync()
        {

            try
            {
                
                    //Name of the file to add
                    string fileName = "test.txt";

                    //Wrap our stream in an IpfsStream, so it has a file name.
                    IpfsStream inputStream = new IpfsStream(fileName, File.OpenRead(fileName));

                    Ipfs.MerkleNode node = await ipfs.Add(inputStream);

                //Stream outputStream = await ipfs.Cat(node.Hash.ToString());

                //using (StreamReader sr = new StreamReader(outputStream))
                //{
                //    string contents = sr.ReadToEnd();

                //    Console.WriteLine(contents); //Contents of test.txt are printed here!
                //}

                return node.Hash.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static async System.Threading.Tasks.Task<string> UploadSingleFile(string name)
        {

            try
            {
               
                
                    var fileName = Path.GetFileName(@"D:\BlockChain\FirstNFTProject\FirstNFTProject/uploads/" +name+ "");
                    using (var fileStream = new FileStream(@"D:\BlockChain\FirstNFTProject\FirstNFTProject/uploads/" + name + "", FileMode.Open))
                    {
                        var inputStream = new IpfsStream(fileName, fileStream);

                        var merkleNode = await ipfs.Add(inputStream).ConfigureAwait(false);
                        var multiHash = ipfs.Pin.Add(merkleNode.Hash.ToString());

                        return merkleNode.Hash.ToString();

                    }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static async System.Threading.Tasks.Task<string> GetSingleFile(string name)
        {

            try
            {

                 string path = "Qmf412jQZiuVUtdgnB36FXFX7xg5V6KEbSJ4dpQuhkLyfD";
                

                Stream outputStream = await ipfs.Cat(path);

                using (StreamReader sr = new StreamReader(outputStream))
                {
                    string contents = sr.ReadToEnd();

                    return contents;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}