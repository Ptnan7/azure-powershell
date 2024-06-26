// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The peering service prefix class.</summary>
    public partial class PeeringServicePrefix :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefix,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.Resource();

        /// <summary>The error message for validation state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).ErrorMessage; }

        /// <summary>The list of events for peering service prefix</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixEvent[] Event { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).Event; }

        /// <summary>The ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id; }

        /// <summary>The peering service prefix key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 2)]
        public string Key { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).PeeringServicePrefixKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).PeeringServicePrefixKey = value ?? null; }

        /// <summary>The prefix learned type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 4)]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LearnedType? LearnedType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).LearnedType; }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal.ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).ErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).ErrorMessage = value; }

        /// <summary>Internal Acessors for Event</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixEvent[] Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal.Event { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).Event; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).Event = value; }

        /// <summary>Internal Acessors for LearnedType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LearnedType? Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal.LearnedType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).LearnedType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).LearnedType = value; }

        /// <summary>Internal Acessors for PrefixValidationState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PrefixValidationState? Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal.PrefixValidationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).PrefixValidationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).PrefixValidationState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixProperties Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServicePrefixProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type = value; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Name; }

        /// <summary>The prefix from which your traffic originates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 1)]
        public string Prefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).Prefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).Prefix = value ?? null; }

        /// <summary>The prefix validation state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 3)]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PrefixValidationState? PrefixValidationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).PrefixValidationState; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixProperties _property;

        /// <summary>Gets or sets the peering prefix properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.PeeringServicePrefixProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.FormatTable(Index = 5)]
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PeeringServicePrefix" /> instance.</summary>
        public PeeringServicePrefix()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The peering service prefix class.
    public partial interface IPeeringServicePrefix :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResource
    {
        /// <summary>The error message for validation state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message for validation state",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>The list of events for peering service prefix</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The list of events for peering service prefix",
        SerializedName = @"events",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixEvent) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixEvent[] Event { get;  }
        /// <summary>The peering service prefix key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The peering service prefix key",
        SerializedName = @"peeringServicePrefixKey",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get; set; }
        /// <summary>The prefix learned type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The prefix learned type",
        SerializedName = @"learnedType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LearnedType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LearnedType? LearnedType { get;  }
        /// <summary>The prefix from which your traffic originates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The prefix from which your traffic originates.",
        SerializedName = @"prefix",
        PossibleTypes = new [] { typeof(string) })]
        string Prefix { get; set; }
        /// <summary>The prefix validation state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The prefix validation state",
        SerializedName = @"prefixValidationState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PrefixValidationState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PrefixValidationState? PrefixValidationState { get;  }
        /// <summary>The provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? ProvisioningState { get;  }

    }
    /// The peering service prefix class.
    internal partial interface IPeeringServicePrefixInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceInternal
    {
        /// <summary>The error message for validation state</summary>
        string ErrorMessage { get; set; }
        /// <summary>The list of events for peering service prefix</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixEvent[] Event { get; set; }
        /// <summary>The peering service prefix key</summary>
        string Key { get; set; }
        /// <summary>The prefix learned type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LearnedType? LearnedType { get; set; }
        /// <summary>The prefix from which your traffic originates.</summary>
        string Prefix { get; set; }
        /// <summary>The prefix validation state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.PrefixValidationState? PrefixValidationState { get; set; }
        /// <summary>Gets or sets the peering prefix properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IPeeringServicePrefixProperties Property { get; set; }
        /// <summary>The provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}