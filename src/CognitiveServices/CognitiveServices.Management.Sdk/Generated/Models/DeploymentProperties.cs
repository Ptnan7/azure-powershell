// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of Cognitive Services account deployment.
    /// </summary>
    public partial class DeploymentProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        public DeploymentProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>

        /// <param name="provisioningState">Gets the status of the resource at the time the operation was called.
        /// Possible values include: &#39;Accepted&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;,
        /// &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Disabled&#39;, &#39;Canceled&#39;</param>

        /// <param name="model">Properties of Cognitive Services account deployment model.
        /// </param>

        /// <param name="scaleSettings">Properties of Cognitive Services account deployment model. (Deprecated,
        /// please use Deployment.sku instead.)
        /// </param>

        /// <param name="capabilities">The capabilities.
        /// </param>

        /// <param name="raiPolicyName">The name of RAI policy.
        /// </param>

        /// <param name="callRateLimit">The call rate limit Cognitive Services account.
        /// </param>

        /// <param name="rateLimits">
        /// </param>

        /// <param name="versionUpgradeOption">Deployment model version upgrade option.
        /// Possible values include: &#39;OnceNewDefaultVersionAvailable&#39;,
        /// &#39;OnceCurrentVersionExpired&#39;, &#39;NoAutoUpgrade&#39;</param>

        /// <param name="dynamicThrottlingEnabled">If the dynamic throttling is enabled.
        /// </param>

        /// <param name="currentCapacity">The current capacity.
        /// </param>

        /// <param name="capacitySettings">Internal use only.
        /// </param>

        /// <param name="parentDeploymentName">The name of parent deployment.
        /// </param>
        public DeploymentProperties(string provisioningState = default(string), DeploymentModel model = default(DeploymentModel), DeploymentScaleSettings scaleSettings = default(DeploymentScaleSettings), System.Collections.Generic.IDictionary<string, string> capabilities = default(System.Collections.Generic.IDictionary<string, string>), string raiPolicyName = default(string), CallRateLimit callRateLimit = default(CallRateLimit), System.Collections.Generic.IList<ThrottlingRule> rateLimits = default(System.Collections.Generic.IList<ThrottlingRule>), string versionUpgradeOption = default(string), bool? dynamicThrottlingEnabled = default(bool?), int? currentCapacity = default(int?), DeploymentCapacitySettings capacitySettings = default(DeploymentCapacitySettings), string parentDeploymentName = default(string))

        {
            this.ProvisioningState = provisioningState;
            this.Model = model;
            this.ScaleSettings = scaleSettings;
            this.Capabilities = capabilities;
            this.RaiPolicyName = raiPolicyName;
            this.CallRateLimit = callRateLimit;
            this.RateLimits = rateLimits;
            this.VersionUpgradeOption = versionUpgradeOption;
            this.DynamicThrottlingEnabled = dynamicThrottlingEnabled;
            this.CurrentCapacity = currentCapacity;
            this.CapacitySettings = capacitySettings;
            this.ParentDeploymentName = parentDeploymentName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets gets the status of the resource at the time the operation was called. Possible values include: &#39;Accepted&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;, &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Disabled&#39;, &#39;Canceled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets properties of Cognitive Services account deployment model.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "model")]
        public DeploymentModel Model {get; set; }

        /// <summary>
        /// Gets or sets properties of Cognitive Services account deployment model.
        /// (Deprecated, please use Deployment.sku instead.)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scaleSettings")]
        public DeploymentScaleSettings ScaleSettings {get; set; }

        /// <summary>
        /// Gets the capabilities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capabilities")]
        public System.Collections.Generic.IDictionary<string, string> Capabilities {get; private set; }

        /// <summary>
        /// Gets or sets the name of RAI policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "raiPolicyName")]
        public string RaiPolicyName {get; set; }

        /// <summary>
        /// Gets the call rate limit Cognitive Services account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "callRateLimit")]
        public CallRateLimit CallRateLimit {get; private set; }

        /// <summary>
        /// Gets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rateLimits")]
        public System.Collections.Generic.IList<ThrottlingRule> RateLimits {get; private set; }

        /// <summary>
        /// Gets or sets deployment model version upgrade option. Possible values include: &#39;OnceNewDefaultVersionAvailable&#39;, &#39;OnceCurrentVersionExpired&#39;, &#39;NoAutoUpgrade&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "versionUpgradeOption")]
        public string VersionUpgradeOption {get; set; }

        /// <summary>
        /// Gets if the dynamic throttling is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dynamicThrottlingEnabled")]
        public bool? DynamicThrottlingEnabled {get; private set; }

        /// <summary>
        /// Gets or sets the current capacity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "currentCapacity")]
        public int? CurrentCapacity {get; set; }

        /// <summary>
        /// Gets or sets internal use only.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacitySettings")]
        public DeploymentCapacitySettings CapacitySettings {get; set; }

        /// <summary>
        /// Gets or sets the name of parent deployment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parentDeploymentName")]
        public string ParentDeploymentName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {








            if (this.CapacitySettings != null)
            {
                this.CapacitySettings.Validate();
            }

        }
    }
}