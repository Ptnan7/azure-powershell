// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Dedicated Sql Minimal Tls Settings Info
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class DedicatedSQLminimalTlsSettings : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DedicatedSQLminimalTlsSettings class.
        /// </summary>
        public DedicatedSQLminimalTlsSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DedicatedSQLminimalTlsSettings class.
        /// </summary>

        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </param>

        /// <param name="name">The name of the resource
        /// </param>

        /// <param name="type">The type of the resource. E.g. &#34;Microsoft.Compute/virtualMachines&#34; or
        /// &#34;Microsoft.Storage/storageAccounts&#34;
        /// </param>

        /// <param name="location">Resource location.
        /// </param>

        /// <param name="minimalTlsVersion">The minimal tls version of the sql server.
        /// </param>
        public DedicatedSQLminimalTlsSettings(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string minimalTlsVersion = default(string))

        : base(id, name, type)
        {
            this.Location = location;
            this.MinimalTlsVersion = minimalTlsVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets resource location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; private set; }

        /// <summary>
        /// Gets or sets the minimal tls version of the sql server.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.minimalTlsVersion")]
        public string MinimalTlsVersion {get; set; }
    }
}