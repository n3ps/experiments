using System;
using Nib.ITOps.Db.Universe.Adapter.CommandResults;

namespace Nib.Sales.HttpServer.Dtos
{
    public class GetDetailsResponse : ICommandResult
    {
        public string OwnerTitle { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerMiddleName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerBirthDate { get; set; }
        public string PolicyAddress1 { get; set; }
        public string PolicyAddress2 { get; set; }
        public string PolicyAddress3 { get; set; }
        public string PolicyPostCode { get; set; }
        public string PolicyMobilePhone { get; set; }
        public string PolicyWorkPhone { get; set; }
        public string PolicyHomePhone { get; set; }
        public string PolicyEmail { get; set; }
        public string PolicyMasterGroupId { get; set; }
        public string PolicyGroupId { get; set; }
        public string PolicyGroupDescription { get; set; }
        public string PolicyStatus { get; set; }
        public string PolicyJoinDate { get; set; }
        public string PolicyPlanId { get; set; }
        public string PolicyPlanDescription { get; set; }
        public string PolicyNextPayAmt { get; set; }
        public string PolicyNextPayDate { get; set; }

        public int ReturnCode
        {
            get;
            set;
        }

        public string ReturnInfo
        {
            get;
            set;
        }

        public string Date
        {
            get;
            set;
        }

        public string Time
        {
            get;
            set;
        }
    }
}