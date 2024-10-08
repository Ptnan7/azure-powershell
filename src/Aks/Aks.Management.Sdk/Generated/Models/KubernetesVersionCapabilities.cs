// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Capabilities on this Kubernetes version.
    /// </summary>
    public partial class KubernetesVersionCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the KubernetesVersionCapabilities class.
        /// </summary>
        public KubernetesVersionCapabilities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KubernetesVersionCapabilities class.
        /// </summary>

        /// <param name="supportPlan">
        /// </param>
        public KubernetesVersionCapabilities(System.Collections.Generic.IList<string> supportPlan = default(System.Collections.Generic.IList<string>))

        {
            this.SupportPlan = supportPlan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "supportPlan")]
        public System.Collections.Generic.IList<string> SupportPlan {get; set; }
    }
}