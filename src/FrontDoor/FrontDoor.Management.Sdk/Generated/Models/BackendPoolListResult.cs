// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// Result of the request to list Backend Pools. It contains a list of Backend
    /// Pools objects and a URL link to get the next set of results.
    /// </summary>
    public partial class BackendPoolListResult
    {
        /// <summary>
        /// Initializes a new instance of the BackendPoolListResult class.
        /// </summary>
        public BackendPoolListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendPoolListResult class.
        /// </summary>

        /// <param name="value">List of Backend Pools within a Front Door.
        /// </param>

        /// <param name="nextLink">URL to get the next set of BackendPool objects if there are any.
        /// </param>
        public BackendPoolListResult(System.Collections.Generic.IList<BackendPool> value = default(System.Collections.Generic.IList<BackendPool>), string nextLink = default(string))

        {
            this.Value = value;
            this.NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets list of Backend Pools within a Front Door.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<BackendPool> Value {get; private set; }

        /// <summary>
        /// Gets or sets uRL to get the next set of BackendPool objects if there are
        /// any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink {get; set; }
    }
}