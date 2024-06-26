// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Extensions;

    /// <summary>The CSPM P1 for AWS offering</summary>
    public partial class DefenderCspmAwsOffering :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOffering,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOffering" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOffering __cloudOffering = new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.CloudOffering();

        /// <summary>Backing field for <see cref="Ciem" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiem _ciem;

        /// <summary>
        /// Defenders CSPM Cloud infrastructure entitlement management (CIEM) offering configurations
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiem Ciem { get => (this._ciem = this._ciem ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingCiem()); set => this._ciem = value; }

        /// <summary>The cloud role ARN in AWS for CIEM discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string CiemDiscoveryCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemDiscoveryCloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemDiscoveryCloudRoleArn = value ?? null; }

        /// <summary>the azure active directory app name used of authenticating against AWS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string CiemOidcAzureActiveDirectoryAppName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemOidcAzureActiveDirectoryAppName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemOidcAzureActiveDirectoryAppName = value ?? null; }

        /// <summary>The cloud role ARN in AWS for CIEM oidc connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string CiemOidcCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemOidcCloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemOidcCloudRoleArn = value ?? null; }

        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string ConfigurationCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).ConfigurationCloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).ConfigurationCloudRoleArn = value ?? null; }

        /// <summary>VM tags that indicates that VM should not be scanned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersConfigurationExclusionTags ConfigurationExclusionTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).ConfigurationExclusionTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).ConfigurationExclusionTag = value ?? null /* model class */; }

        /// <summary>The scanning mode for the VM scan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string ConfigurationScanningMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).ConfigurationScanningMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).ConfigurationScanningMode = value ?? null; }

        /// <summary>Backing field for <see cref="DataSensitivityDiscovery" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscovery _dataSensitivityDiscovery;

        /// <summary>The Microsoft Defender Data Sensitivity discovery configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscovery DataSensitivityDiscovery { get => (this._dataSensitivityDiscovery = this._dataSensitivityDiscovery ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingDataSensitivityDiscovery()); set => this._dataSensitivityDiscovery = value; }

        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string DataSensitivityDiscoveryCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscoveryInternal)DataSensitivityDiscovery).CloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscoveryInternal)DataSensitivityDiscovery).CloudRoleArn = value ?? null; }

        /// <summary>Is Microsoft Defender Data Sensitivity discovery enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public bool? DataSensitivityDiscoveryEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscoveryInternal)DataSensitivityDiscovery).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscoveryInternal)DataSensitivityDiscovery).Enabled = value ?? default(bool); }

        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string DatabaseDspmCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspmInternal)DatabasesDspm).CloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspmInternal)DatabasesDspm).CloudRoleArn = value ?? null; }

        /// <summary>Is databases DSPM protection enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public bool? DatabaseDspmEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspmInternal)DatabasesDspm).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspmInternal)DatabasesDspm).Enabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="DatabasesDspm" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspm _databasesDspm;

        /// <summary>The databases DSPM configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspm DatabasesDspm { get => (this._databasesDspm = this._databasesDspm ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingDatabasesDspm()); set => this._databasesDspm = value; }

        /// <summary>The offering description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inherited)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)__cloudOffering).Description; }

        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string MdcContainerAgentlessDiscoveryK8SCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8SInternal)MdcContainersAgentlessDiscoveryK8S).CloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8SInternal)MdcContainersAgentlessDiscoveryK8S).CloudRoleArn = value ?? null; }

        /// <summary>Is Microsoft Defender container agentless discovery K8s enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public bool? MdcContainerAgentlessDiscoveryK8SEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8SInternal)MdcContainersAgentlessDiscoveryK8S).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8SInternal)MdcContainersAgentlessDiscoveryK8S).Enabled = value ?? default(bool); }

        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public string MdcContainerImageAssessmentCloudRoleArn { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessmentInternal)MdcContainersImageAssessment).CloudRoleArn; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessmentInternal)MdcContainersImageAssessment).CloudRoleArn = value ?? null; }

        /// <summary>Is Microsoft Defender container image assessment enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public bool? MdcContainerImageAssessmentEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessmentInternal)MdcContainersImageAssessment).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessmentInternal)MdcContainersImageAssessment).Enabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="MdcContainersAgentlessDiscoveryK8S" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S _mdcContainersAgentlessDiscoveryK8S;

        /// <summary>The Microsoft Defender container agentless discovery K8s configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S MdcContainersAgentlessDiscoveryK8S { get => (this._mdcContainersAgentlessDiscoveryK8S = this._mdcContainersAgentlessDiscoveryK8S ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S()); set => this._mdcContainersAgentlessDiscoveryK8S = value; }

        /// <summary>Backing field for <see cref="MdcContainersImageAssessment" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessment _mdcContainersImageAssessment;

        /// <summary>The Microsoft Defender container image assessment configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessment MdcContainersImageAssessment { get => (this._mdcContainersImageAssessment = this._mdcContainersImageAssessment ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingMdcContainersImageAssessment()); set => this._mdcContainersImageAssessment = value; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)__cloudOffering).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)__cloudOffering).Description = value; }

        /// <summary>Internal Acessors for Ciem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiem Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.Ciem { get => (this._ciem = this._ciem ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingCiem()); set { {_ciem = value;} } }

        /// <summary>Internal Acessors for CiemDiscovery</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemDiscovery Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.CiemDiscovery { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemDiscovery; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemDiscovery = value; }

        /// <summary>Internal Acessors for CiemOidc</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemOidc Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.CiemOidc { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemOidc; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemInternal)Ciem).CiemOidc = value; }

        /// <summary>Internal Acessors for DataSensitivityDiscovery</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscovery Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.DataSensitivityDiscovery { get => (this._dataSensitivityDiscovery = this._dataSensitivityDiscovery ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingDataSensitivityDiscovery()); set { {_dataSensitivityDiscovery = value;} } }

        /// <summary>Internal Acessors for DatabasesDspm</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspm Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.DatabasesDspm { get => (this._databasesDspm = this._databasesDspm ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingDatabasesDspm()); set { {_databasesDspm = value;} } }

        /// <summary>Internal Acessors for MdcContainersAgentlessDiscoveryK8S</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.MdcContainersAgentlessDiscoveryK8S { get => (this._mdcContainersAgentlessDiscoveryK8S = this._mdcContainersAgentlessDiscoveryK8S ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S()); set { {_mdcContainersAgentlessDiscoveryK8S = value;} } }

        /// <summary>Internal Acessors for MdcContainersImageAssessment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessment Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.MdcContainersImageAssessment { get => (this._mdcContainersImageAssessment = this._mdcContainersImageAssessment ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingMdcContainersImageAssessment()); set { {_mdcContainersImageAssessment = value;} } }

        /// <summary>Internal Acessors for VMScanner</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScanners Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.VMScanner { get => (this._vMScanner = this._vMScanner ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingVMScanners()); set { {_vMScanner = value;} } }

        /// <summary>Internal Acessors for VMScannerConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersConfiguration Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingInternal.VMScannerConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).Configuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).Configuration = value; }

        /// <summary>The type of the security offering.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inherited)]
        public string OfferingType { get => "DefenderCspmAws"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)__cloudOffering).OfferingType = "DefenderCspmAws"; }

        /// <summary>Backing field for <see cref="VMScanner" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScanners _vMScanner;

        /// <summary>The Microsoft Defender for Server VM scanning configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScanners VMScanner { get => (this._vMScanner = this._vMScanner ?? new Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderCspmAwsOfferingVMScanners()); set => this._vMScanner = value; }

        /// <summary>Is Microsoft Defender for Server VM scanning enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Inlined)]
        public bool? VMScannerEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersInternal)VMScanner).Enabled = value ?? default(bool); }

        /// <summary>Creates an new <see cref="DefenderCspmAwsOffering" /> instance.</summary>
        public DefenderCspmAwsOffering()
        {
            this.__cloudOffering.OfferingType = "DefenderCspmAws";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__cloudOffering), __cloudOffering);
            await eventListener.AssertObjectIsValid(nameof(__cloudOffering), __cloudOffering);
        }
    }
    /// The CSPM P1 for AWS offering
    public partial interface IDefenderCspmAwsOffering :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOffering
    {
        /// <summary>The cloud role ARN in AWS for CIEM discovery</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for CIEM discovery",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string CiemDiscoveryCloudRoleArn { get; set; }
        /// <summary>the azure active directory app name used of authenticating against AWS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the azure active directory app name used of authenticating against AWS",
        SerializedName = @"azureActiveDirectoryAppName",
        PossibleTypes = new [] { typeof(string) })]
        string CiemOidcAzureActiveDirectoryAppName { get; set; }
        /// <summary>The cloud role ARN in AWS for CIEM oidc connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for CIEM oidc connection",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string CiemOidcCloudRoleArn { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for this feature",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationCloudRoleArn { get; set; }
        /// <summary>VM tags that indicates that VM should not be scanned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VM tags that indicates that VM should not be scanned",
        SerializedName = @"exclusionTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersConfigurationExclusionTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersConfigurationExclusionTags ConfigurationExclusionTag { get; set; }
        /// <summary>The scanning mode for the VM scan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The scanning mode for the VM scan.",
        SerializedName = @"scanningMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Default")]
        string ConfigurationScanningMode { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for this feature",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string DataSensitivityDiscoveryCloudRoleArn { get; set; }
        /// <summary>Is Microsoft Defender Data Sensitivity discovery enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is Microsoft Defender Data Sensitivity discovery enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DataSensitivityDiscoveryEnabled { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for this feature",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseDspmCloudRoleArn { get; set; }
        /// <summary>Is databases DSPM protection enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is databases DSPM protection enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DatabaseDspmEnabled { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for this feature",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string MdcContainerAgentlessDiscoveryK8SCloudRoleArn { get; set; }
        /// <summary>Is Microsoft Defender container agentless discovery K8s enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is Microsoft Defender container agentless discovery K8s enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MdcContainerAgentlessDiscoveryK8SEnabled { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cloud role ARN in AWS for this feature",
        SerializedName = @"cloudRoleArn",
        PossibleTypes = new [] { typeof(string) })]
        string MdcContainerImageAssessmentCloudRoleArn { get; set; }
        /// <summary>Is Microsoft Defender container image assessment enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is Microsoft Defender container image assessment enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MdcContainerImageAssessmentEnabled { get; set; }
        /// <summary>Is Microsoft Defender for Server VM scanning enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Is Microsoft Defender for Server VM scanning enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? VMScannerEnabled { get; set; }

    }
    /// The CSPM P1 for AWS offering
    internal partial interface IDefenderCspmAwsOfferingInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal
    {
        /// <summary>
        /// Defenders CSPM Cloud infrastructure entitlement management (CIEM) offering configurations
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiem Ciem { get; set; }
        /// <summary>Defender CSPM CIEM discovery configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemDiscovery CiemDiscovery { get; set; }
        /// <summary>The cloud role ARN in AWS for CIEM discovery</summary>
        string CiemDiscoveryCloudRoleArn { get; set; }
        /// <summary>Defender CSPM CIEM AWS OIDC (open id connect) configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingCiemOidc CiemOidc { get; set; }
        /// <summary>the azure active directory app name used of authenticating against AWS</summary>
        string CiemOidcAzureActiveDirectoryAppName { get; set; }
        /// <summary>The cloud role ARN in AWS for CIEM oidc connection</summary>
        string CiemOidcCloudRoleArn { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        string ConfigurationCloudRoleArn { get; set; }
        /// <summary>VM tags that indicates that VM should not be scanned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersConfigurationExclusionTags ConfigurationExclusionTag { get; set; }
        /// <summary>The scanning mode for the VM scan.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Default")]
        string ConfigurationScanningMode { get; set; }
        /// <summary>The Microsoft Defender Data Sensitivity discovery configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDataSensitivityDiscovery DataSensitivityDiscovery { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        string DataSensitivityDiscoveryCloudRoleArn { get; set; }
        /// <summary>Is Microsoft Defender Data Sensitivity discovery enabled</summary>
        bool? DataSensitivityDiscoveryEnabled { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        string DatabaseDspmCloudRoleArn { get; set; }
        /// <summary>Is databases DSPM protection enabled</summary>
        bool? DatabaseDspmEnabled { get; set; }
        /// <summary>The databases DSPM configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingDatabasesDspm DatabasesDspm { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        string MdcContainerAgentlessDiscoveryK8SCloudRoleArn { get; set; }
        /// <summary>Is Microsoft Defender container agentless discovery K8s enabled</summary>
        bool? MdcContainerAgentlessDiscoveryK8SEnabled { get; set; }
        /// <summary>The cloud role ARN in AWS for this feature</summary>
        string MdcContainerImageAssessmentCloudRoleArn { get; set; }
        /// <summary>Is Microsoft Defender container image assessment enabled</summary>
        bool? MdcContainerImageAssessmentEnabled { get; set; }
        /// <summary>The Microsoft Defender container agentless discovery K8s configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersAgentlessDiscoveryK8S MdcContainersAgentlessDiscoveryK8S { get; set; }
        /// <summary>The Microsoft Defender container image assessment configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingMdcContainersImageAssessment MdcContainersImageAssessment { get; set; }
        /// <summary>The Microsoft Defender for Server VM scanning configuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScanners VMScanner { get; set; }
        /// <summary>configuration for Microsoft Defender for Server VM scanning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderCspmAwsOfferingVMScannersConfiguration VMScannerConfiguration { get; set; }
        /// <summary>Is Microsoft Defender for Server VM scanning enabled</summary>
        bool? VMScannerEnabled { get; set; }

    }
}