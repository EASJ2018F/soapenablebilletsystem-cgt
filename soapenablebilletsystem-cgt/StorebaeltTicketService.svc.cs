using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;
using BilletLib.TicketIssuers;

namespace soapenablebilletsystem_cgt
{
    public class StorebaeltTicketService : ITicketService
    {
        private ITicketIssuer _ticketIssuer = new StorebaeltTicketIssuer();

        public Ticket IssueTicket(TicketOrder o)
        {
            return _ticketIssuer.IssueTicket(o);
        }
    }
}
