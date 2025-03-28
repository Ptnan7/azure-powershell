// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies the Security profile settings for the virtual machine or virtual
    /// machine scale set.
    /// </summary>
    public partial class SecurityProfile
    {
        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>
        public SecurityProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>

        /// <param name="uefiSettings">Specifies the security settings like secure boot and vTPM used while
        /// creating the virtual machine. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-12-01
        /// </param>

        /// <param name="encryptionAtHost">This property can be used by user in the request to enable or disable the
        /// Host Encryption for the virtual machine or virtual machine scale set. This
        /// will enable the encryption for all the disks including Resource/Temp disk
        /// at host itself. &lt;br&gt;&lt;br&gt; Default: The Encryption at host will be disabled
        /// unless this property is set to true for the resource.
        /// </param>

        /// <param name="securityType">Specifies the SecurityType of the virtual machine. It has to be set to any
        /// specified value to enable UefiSettings. &lt;br&gt;&lt;br&gt; Default: UefiSettings will
        /// not be enabled unless this property is set.
        /// Possible values include: &#39;TrustedLaunch&#39;, &#39;ConfidentialVM&#39;</param>
        public SecurityProfile(UefiSettings uefiSettings = default(UefiSettings), bool? encryptionAtHost = default(bool?), string securityType = default(string))

        {
            this.UefiSettings = uefiSettings;
            this.EncryptionAtHost = encryptionAtHost;
            this.SecurityType = securityType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets specifies the security settings like secure boot and vTPM used
        /// while creating the virtual machine. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-12-01
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uefiSettings")]
        public UefiSettings UefiSettings {get; set; }

        /// <summary>
        /// Gets or sets this property can be used by user in the request to enable or
        /// disable the Host Encryption for the virtual machine or virtual machine
        /// scale set. This will enable the encryption for all the disks including
        /// Resource/Temp disk at host itself. &lt;br&gt;&lt;br&gt; Default: The Encryption at host
        /// will be disabled unless this property is set to true for the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "encryptionAtHost")]
        public bool? EncryptionAtHost {get; set; }

        /// <summary>
        /// Gets or sets specifies the SecurityType of the virtual machine. It has to
        /// be set to any specified value to enable UefiSettings. &lt;br&gt;&lt;br&gt; Default:
        /// UefiSettings will not be enabled unless this property is set. Possible values include: &#39;TrustedLaunch&#39;, &#39;ConfidentialVM&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "securityType")]
        public string SecurityType {get; set; }
    }
}