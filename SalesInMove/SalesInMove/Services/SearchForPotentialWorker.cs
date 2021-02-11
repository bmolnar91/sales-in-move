using SalesInMove.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesInMove.Services
{
    public class SearchForPotentialWorker : ISearch
    {
        private List<SearchRequest> requestes = new List<SearchRequest>
        {
            new SearchRequest
            {
                Title = "EletKor",
                Status = "mandatory",
                Type = "int",
                Value = "22"
            },
            new SearchRequest
            {
                Title = "Varos",
                Status = "mandatory",
                Type = "string",
                Value = "Budapest"
            },
            new SearchRequest
            {
                Title = "Jogositvany",
                Status = "optional",
                Type = "bool",
                Value = "true"
            }
        };
         

        public void CheckMandatories()
        {
            foreach(var request in requestes)
            {

            }
        }
               
         
        public List<Account> Search(Company company, Dictionary<string, bool> parameters)
        {


            throw new NotImplementedException();
        }

        private Dictionary<string,bool> GetAccountsWhichContainsMandatoryField(Dictionary<string,bool> parameters)
        {
            

            throw new NotImplementedException();
        }


    }
}
