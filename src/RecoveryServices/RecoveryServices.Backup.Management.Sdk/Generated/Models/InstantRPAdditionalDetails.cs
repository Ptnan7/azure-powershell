// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    public partial class InstantRPAdditionalDetails
    {
        /// <summary>
        /// Initializes a new instance of the InstantRPAdditionalDetails class.
        /// </summary>
        public InstantRPAdditionalDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstantRPAdditionalDetails class.
        /// </summary>

        /// <param name="azureBackupRgNamePrefix">
        /// </param>

        /// <param name="azureBackupRgNameSuffix">
        /// </param>
        public InstantRPAdditionalDetails(string azureBackupRgNamePrefix = default(string), string azureBackupRgNameSuffix = default(string))

        {
            this.AzureBackupRgNamePrefix = azureBackupRgNamePrefix;
            this.AzureBackupRgNameSuffix = azureBackupRgNameSuffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "azureBackupRGNamePrefix")]
        public string AzureBackupRgNamePrefix {get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "azureBackupRGNameSuffix")]
        public string AzureBackupRgNameSuffix {get; set; }
    }
}