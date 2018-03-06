using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace soapenablebilletsystem_cgt
{
    [ServiceContract]
    public interface ITicketService
    {
        [OperationContract]
        Ticket IssueTicket(TicketOrder o);
    }
}
