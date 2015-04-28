using System;
using Nib.Common.Core;

namespace Nib.Sales.Interface.Dtos.Responses
{
    /// <summary>
    /// Details of a person for whom cover is being bought
    /// </summary>
    public class PersonDetailsDto
    {
        // Policy relationship

        /// <summary>
        /// Is this person to be a policy owner?
        /// </summary>
        public bool IsPolicyOwner { get; set; }


        // Personal Details

        /// <summary>
        /// The user's title (Mr, Mrs, ...)
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The user's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The user's surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// The user's Date of Birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The user's email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user's Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The user's gender
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// The user's smoker status
        /// </summary>
        public Smoker Smoker { get; set; }

        /// <summary>
        /// Has the user checked the PrivacyPolicy checkbox or equivalent?
        /// </summary>
        public bool PrivacyPolicyAccepted { get; set; }

        /// <summary>
        /// Has the user checked the EligibilityCriteria checkbox or equivalent?
        /// </summary>
        public bool EligibilityCriteriaAccepted { get; set; }

    }
}
