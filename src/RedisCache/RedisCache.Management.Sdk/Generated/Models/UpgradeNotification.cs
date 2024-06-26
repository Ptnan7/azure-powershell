// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RedisCache.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of upgrade notification.
    /// </summary>
    public partial class UpgradeNotification
    {
        /// <summary>
        /// Initializes a new instance of the UpgradeNotification class.
        /// </summary>
        public UpgradeNotification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpgradeNotification class.
        /// </summary>

        /// <param name="name">Name of upgrade notification.
        /// </param>

        /// <param name="timestamp">Timestamp when upgrade notification occurred.
        /// </param>

        /// <param name="upsellNotification">Details about this upgrade notification
        /// </param>
        public UpgradeNotification(string name = default(string), System.DateTime? timestamp = default(System.DateTime?), System.Collections.Generic.IDictionary<string, string> upsellNotification = default(System.Collections.Generic.IDictionary<string, string>))

        {
            this.Name = name;
            this.Timestamp = timestamp;
            this.UpsellNotification = upsellNotification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets name of upgrade notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets timestamp when upgrade notification occurred.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp {get; private set; }

        /// <summary>
        /// Gets details about this upgrade notification
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "upsellNotification")]
        public System.Collections.Generic.IDictionary<string, string> UpsellNotification {get; private set; }
    }
}