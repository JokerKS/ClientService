using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ClientService : IClientService
    {
        public int EditOrUpdate(ClientData clientData)
        {
            try
            { 
                using (var db = new ClientServiceContext())
                {
                    db.Entry(clientData).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return 1;
                }
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public decimal GetClientAccount(int clientId)
        {
            using (var db = new ClientServiceContext())
                return db.Clients.Find(clientId).Amount;
        }

        public ClientData GetClientData(int clientId)
        {
            using (var db = new ClientServiceContext())
                return db.Clients.Find(clientId);
        }

        public bool RemoveClient(int clientId)
        {
            try
            {
                using (var db = new ClientServiceContext())
                {
                    var clientData = db.Clients.Find(clientId);
                    db.Entry(clientData).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
