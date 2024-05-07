namespace Mollie.Api.Options {
    public class MollieOptions {
        /// <summary>
        /// Your API-key or OAuth token
        /// </summary>
        public string ApiKey { get; set; }
        
        /// <summary>
        /// (Optional) ClientId used by Connect API
        /// </summary>
        public string ClientId { get; set; }
        
        /// <summary>
        /// (Optional) ClientSecret used by Connect API
        /// </summary>
        /// <returns></returns>
        public string ClientSecret { get; set; }
    }
}
