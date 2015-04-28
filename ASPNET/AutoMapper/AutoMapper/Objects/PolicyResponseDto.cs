using System;
using System.Collections.Generic;

namespace Nib.Sales.Interface.Dtos.Responses
{
    /// <summary>
    /// Details of a policy
    /// </summary>
    public class PolicyResponseDto
    {
        /// <summary>
        /// Uniquely identifies a policy
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The policy's line address 1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// The policy's line address 2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The policy's line address 3
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// The policy's line address 4
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The policy's mobile phone on record
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// The policy's work phone on record
        /// </summary>
        public string WorkPhone { get; set; }

        /// <summary>
        /// The policy's home phone on record
        /// </summary>
        public string HomePhone { get; set; }

        /// <summary>
        /// The policy's email address on recrod
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The policy's master group ID
        /// </summary>
        public int? MasterGroupId { get; set; }

        /// <summary>
        /// The policy's group ID
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// The policy's group description
        /// </summary>
        public string GroupDescription { get; set; }

        /// <summary>
        /// The status of the policy
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The policy's join date
        /// </summary>
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// The policy's plan id
        /// </summary>
        public int PlanId { get; set; }

        /// <summary>
        /// The policy description
        /// </summary>
        public string PlanDescription { get; set; }

        /// <summary>
        /// The policy's next pay amount
        /// </summary>
        public decimal NextPayAmount { get; set; }

        /// <summary>
        /// The policy's next pay date
        /// </summary>
        public DateTime NextPayDate { get; set; }

        /// <summary>
        /// The policy may have one or more owners
        /// </summary>
        public PersonDetailsDto Owner { get; set; }

        /// <summary>
        /// The policy's list of insured persons
        /// </summary>
        public List<PersonDetailsDto> Insured { get; set; }
    }
}
