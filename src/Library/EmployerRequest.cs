using System;
using System.Collections;
namespace Library{
    public class EmployerRequest{

        public EmployerRequest(string request){

            this.Request = request;
        }
        public ArrayList AwaitingRequests = new ArrayList();
        
        public ArrayList DeclainedRequests = new ArrayList();

        public string Request { get; set;}

        public void AddRequest(Request){

            this.AwaitingRequests.Add(Request);
        }
        
    }


}