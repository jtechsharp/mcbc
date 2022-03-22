namespace mcbc.Web.Public.Models
{
    /// <summary>
    /// Erro Model
    /// </summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}