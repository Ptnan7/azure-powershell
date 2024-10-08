// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Security Solution setting data
    /// </summary>
    public partial class IoTSecuritySolutionProperties
    {
        /// <summary>
        /// Initializes a new instance of the IoTSecuritySolutionProperties class.
        /// </summary>
        public IoTSecuritySolutionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSecuritySolutionProperties class.
        /// </summary>

        /// <param name="workspace">Workspace resource ID
        /// </param>

        /// <param name="displayName">Resource display name.
        /// </param>

        /// <param name="status">Status of the IoT Security solution.
        /// Possible values include: 'Enabled', 'Disabled'</param>

        /// <param name="export">List of additional options for exporting to workspace data.
        /// </param>

        /// <param name="disabledDataSources">Disabled data sources. Disabling these data sources compromises the system.
        /// </param>

        /// <param name="iotHubs">IoT Hub resource IDs
        /// </param>

        /// <param name="userDefinedResources">Properties of the IoT Security solution&#39;s user defined resources.
        /// </param>

        /// <param name="autoDiscoveredResources">List of resources that were automatically discovered as relevant to the
        /// security solution.
        /// </param>

        /// <param name="recommendationsConfiguration">List of the configuration status for each recommendation type.
        /// </param>

        /// <param name="unmaskedIPLoggingStatus">Unmasked IP address logging status
        /// Possible values include: 'Disabled', 'Enabled'</param>

        /// <param name="additionalWorkspaces">List of additional workspaces
        /// </param>
        public IoTSecuritySolutionProperties(string displayName, System.Collections.Generic.IList<string> iotHubs, string workspace = default(string), string status = default(string), System.Collections.Generic.IList<string> export = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<string> disabledDataSources = default(System.Collections.Generic.IList<string>), UserDefinedResourcesProperties userDefinedResources = default(UserDefinedResourcesProperties), System.Collections.Generic.IList<string> autoDiscoveredResources = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<RecommendationConfigurationProperties> recommendationsConfiguration = default(System.Collections.Generic.IList<RecommendationConfigurationProperties>), string unmaskedIPLoggingStatus = default(string), System.Collections.Generic.IList<AdditionalWorkspacesProperties> additionalWorkspaces = default(System.Collections.Generic.IList<AdditionalWorkspacesProperties>))

        {
            this.Workspace = workspace;
            this.DisplayName = displayName;
            this.Status = status;
            this.Export = export;
            this.DisabledDataSources = disabledDataSources;
            this.IotHubs = iotHubs;
            this.UserDefinedResources = userDefinedResources;
            this.AutoDiscoveredResources = autoDiscoveredResources;
            this.RecommendationsConfiguration = recommendationsConfiguration;
            this.UnmaskedIPLoggingStatus = unmaskedIPLoggingStatus;
            this.AdditionalWorkspaces = additionalWorkspaces;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets workspace resource ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "workspace")]
        public string Workspace {get; set; }

        /// <summary>
        /// Gets or sets resource display name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName {get; set; }

        /// <summary>
        /// Gets or sets status of the IoT Security solution. Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }

        /// <summary>
        /// Gets or sets list of additional options for exporting to workspace data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "export")]
        public System.Collections.Generic.IList<string> Export {get; set; }

        /// <summary>
        /// Gets or sets disabled data sources. Disabling these data sources
        /// compromises the system.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disabledDataSources")]
        public System.Collections.Generic.IList<string> DisabledDataSources {get; set; }

        /// <summary>
        /// Gets or sets ioT Hub resource IDs
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "iotHubs")]
        public System.Collections.Generic.IList<string> IotHubs {get; set; }

        /// <summary>
        /// Gets or sets properties of the IoT Security solution&#39;s user defined
        /// resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userDefinedResources")]
        public UserDefinedResourcesProperties UserDefinedResources {get; set; }

        /// <summary>
        /// Gets list of resources that were automatically discovered as relevant to
        /// the security solution.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoDiscoveredResources")]
        public System.Collections.Generic.IList<string> AutoDiscoveredResources {get; private set; }

        /// <summary>
        /// Gets or sets list of the configuration status for each recommendation type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recommendationsConfiguration")]
        public System.Collections.Generic.IList<RecommendationConfigurationProperties> RecommendationsConfiguration {get; set; }

        /// <summary>
        /// Gets or sets unmasked IP address logging status Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unmaskedIpLoggingStatus")]
        public string UnmaskedIPLoggingStatus {get; set; }

        /// <summary>
        /// Gets or sets list of additional workspaces
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "additionalWorkspaces")]
        public System.Collections.Generic.IList<AdditionalWorkspacesProperties> AdditionalWorkspaces {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.DisplayName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DisplayName");
            }
            if (this.IotHubs == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "IotHubs");
            }






            if (this.UserDefinedResources != null)
            {
                this.UserDefinedResources.Validate();
            }

            if (this.RecommendationsConfiguration != null)
            {
                foreach (var element in this.RecommendationsConfiguration)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }


        }
    }
}