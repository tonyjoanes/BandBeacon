using System.Net.Http;

namespace BandBeacon.Core.ApiSupport
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
        // Additional fields like StatusCode, etc.
    }

}
