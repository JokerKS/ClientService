using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IClientService
    {

        [OperationContract]
        ClientData GetClientData(int clientId);
        [OperationContract]
        bool RemoveClient(int clientId);
        [OperationContract]
        int EditOrUpdate(ClientData clientData);
        [OperationContract]
        decimal GetClientAccount(int clientId);
    }


    [DataContract]
    [Table("Clients")]
    public class ClientData
    {
        [Key]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Account { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
        public decimal Amount { get; set; }
        public bool Vip { get; set; }
    }
}
