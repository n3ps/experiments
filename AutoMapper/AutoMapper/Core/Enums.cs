using System.ComponentModel;

namespace Nib.Common.Core
{
    /// <summary>
    /// The source of a request.
    /// </summary>
    public enum Source
    {
        /// <summary>
        /// An unspecified source
        /// </summary>
        Unspecified = 0,
        /// <summary>
        /// Source from the website
        /// </summary>
        Web = 1,
    }

    /// <summary>
    /// A user's gender
    /// </summary>
    public enum Gender
    {
        /// <summary>
        /// Unspecified
        /// </summary>
        Unspecified = 0,
        /// <summary>
        /// Female
        /// </summary>
        Female = 1,
        /// <summary>
        /// Male
        /// </summary>
        Male = 2,
    }

    /// <summary>
    /// The frequency at which a user will be making payments
    /// </summary>
    public enum PaymentFrequency
    {
        /// <summary>
        /// Weekly payments
        /// </summary>
        Weekly = 1,
        /// <summary>
        /// Fortnightly payments
        /// </summary>
        Fortnightly = 2,
        /// <summary>
        /// Monthly payments
        /// </summary>
        Monthly = 3,
        /// <summary>
        /// Quarter yearly payments
        /// </summary>
        Quarterly = 4,

        /// <summary>
        /// Half yearly payments
        /// </summary>
        [Description("Half-Yearly")]
        HalfYearly = 5,

        /// <summary>
        /// Annual payments
        /// </summary>
        Yearly = 6
    }

    /// <summary>
    /// The method by which a user will be making payments
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// An unspecified or unhandled payment method
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Direct debit
        /// </summary>
        [Description("Direct Debit")]
        DirectDebit = 1,

        /// <summary>
        /// Credit card
        /// </summary>
        [Description("Credit Card")]
        CreditCard = 2
    }

    /// <summary>
    /// Smoker status
    /// </summary>
    public enum Smoker
    {
        /// <summary>
        /// It is unknown or unspecified whether the person is a smoker
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// The person is a smoker
        /// </summary>
        [Description("Smoker")]
        IsSmoker = 1,

        /// <summary>
        /// The person is not a smoker
        /// </summary>
        [Description("Non-Smoker")]
        IsNotSmoker = 2
    }

}
