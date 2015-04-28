namespace Nib.ITOps.Db.Universe.Adapter.CommandResults
{
    /// <summary>
    /// Represents a result from a Universe invocation
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        /// Zero indicates success and all other values indicate failure.
        /// </summary>
        int ReturnCode { get; set; }

        /// <summary>
        /// An error message if something failed, or null if there is no error.
        /// </summary>
        string ReturnInfo { get; set; }

        /// <summary>
        /// Utc date handler was executed on server.
        /// </summary>
        string Date { get; set; }

        /// <summary>
        /// Utc time handler was executed on server.
        /// </summary>
        string Time { get; set; }
    }
}
