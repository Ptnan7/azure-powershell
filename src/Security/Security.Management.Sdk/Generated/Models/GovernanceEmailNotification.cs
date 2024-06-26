// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// The governance email weekly notification configuration.
    /// </summary>
    public partial class GovernanceEmailNotification
    {
        /// <summary>
        /// Initializes a new instance of the GovernanceEmailNotification class.
        /// </summary>
        public GovernanceEmailNotification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GovernanceEmailNotification class.
        /// </summary>

        /// <param name="disableManagerEmailNotification">Exclude manager from weekly email notification.
        /// </param>

        /// <param name="disableOwnerEmailNotification">Exclude  owner from weekly email notification.
        /// </param>
        public GovernanceEmailNotification(bool? disableManagerEmailNotification = default(bool?), bool? disableOwnerEmailNotification = default(bool?))

        {
            this.DisableManagerEmailNotification = disableManagerEmailNotification;
            this.DisableOwnerEmailNotification = disableOwnerEmailNotification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets exclude manager from weekly email notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disableManagerEmailNotification")]
        public bool? DisableManagerEmailNotification {get; set; }

        /// <summary>
        /// Gets or sets exclude  owner from weekly email notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disableOwnerEmailNotification")]
        public bool? DisableOwnerEmailNotification {get; set; }
    }
}