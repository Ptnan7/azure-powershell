// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Extensions;

    /// <summary>The registration definition.</summary>
    public partial class RegistrationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal
    {

        /// <summary>
        /// The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant
        /// will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] Authorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).Authorization; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).Authorization = value ?? null /* arrayOf */; }

        /// <summary>The description of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>
        /// The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals
        /// in the managedBy tenant will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] EligibleAuthorization { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).EligibleAuthorization; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).EligibleAuthorization = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The fully qualified path of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>The identifier of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string ManagedByTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ManagedByTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ManagedByTenantId = value ?? null; }

        /// <summary>The name of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string ManagedByTenantName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ManagedByTenantName; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for ManagedByTenantName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.ManagedByTenantName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ManagedByTenantName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ManagedByTenantName = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlan Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.Plan { get => (this._plan = this._plan ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.Plan()); set { {_plan = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionProperties Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationDefinitionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlan _plan;

        /// <summary>The details for the Managed Services offer’s plan in Azure Marketplace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlan Plan { get => (this._plan = this._plan ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.Plan()); set => this._plan = value; }

        /// <summary>Azure Marketplace plan name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Name = value ?? null; }

        /// <summary>Azure Marketplace product code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string PlanProduct { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Product; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Product = value ?? null; }

        /// <summary>Azure Marketplace publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string PlanPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Publisher = value ?? null; }

        /// <summary>Azure Marketplace plan's version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string PlanVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlanInternal)Plan).Version = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionProperties _property;

        /// <summary>The properties of a registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.RegistrationDefinitionProperties()); set => this._property = value; }

        /// <summary>The current provisioning state of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The name of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Inlined)]
        public string RegistrationDefinitionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).RegistrationDefinitionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionPropertiesInternal)Property).RegistrationDefinitionName = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The type of the Azure resource (Microsoft.ManagedServices/registrationDefinitions).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="RegistrationDefinition" /> instance.</summary>
        public RegistrationDefinition()
        {

        }
    }
    /// The registration definition.
    public partial interface IRegistrationDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant
        /// will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant.",
        SerializedName = @"authorizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] Authorization { get; set; }
        /// <summary>The description of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the registration definition.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals
        /// in the managedBy tenant will receive on the delegated resource in the managed tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals in the managedBy tenant will receive on the delegated resource in the managed tenant.",
        SerializedName = @"eligibleAuthorizations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] EligibleAuthorization { get; set; }
        /// <summary>The fully qualified path of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fully qualified path of the registration definition.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The identifier of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identifier of the managedBy tenant.",
        SerializedName = @"managedByTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedByTenantId { get; set; }
        /// <summary>The name of the managedBy tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the managedBy tenant.",
        SerializedName = @"managedByTenantName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedByTenantName { get;  }
        /// <summary>The name of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the registration definition.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Azure Marketplace plan name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Marketplace plan name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>Azure Marketplace product code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Marketplace product code.",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string PlanProduct { get; set; }
        /// <summary>Azure Marketplace publisher ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Marketplace publisher ID.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string PlanPublisher { get; set; }
        /// <summary>Azure Marketplace plan's version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure Marketplace plan's version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string PlanVersion { get; set; }
        /// <summary>The current provisioning state of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The current provisioning state of the registration definition.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The name of the registration definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the registration definition.",
        SerializedName = @"registrationDefinitionName",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationDefinitionName { get; set; }
        /// <summary>
        /// The type of the Azure resource (Microsoft.ManagedServices/registrationDefinitions).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the Azure resource (Microsoft.ManagedServices/registrationDefinitions).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The registration definition.
    internal partial interface IRegistrationDefinitionInternal

    {
        /// <summary>
        /// The collection of authorization objects describing the access Azure Active Directory principals in the managedBy tenant
        /// will receive on the delegated resource in the managed tenant.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IAuthorization[] Authorization { get; set; }
        /// <summary>The description of the registration definition.</summary>
        string Description { get; set; }
        /// <summary>
        /// The collection of eligible authorization objects describing the just-in-time access Azure Active Directory principals
        /// in the managedBy tenant will receive on the delegated resource in the managed tenant.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IEligibleAuthorization[] EligibleAuthorization { get; set; }
        /// <summary>The fully qualified path of the registration definition.</summary>
        string Id { get; set; }
        /// <summary>The identifier of the managedBy tenant.</summary>
        string ManagedByTenantId { get; set; }
        /// <summary>The name of the managedBy tenant.</summary>
        string ManagedByTenantName { get; set; }
        /// <summary>The name of the registration definition.</summary>
        string Name { get; set; }
        /// <summary>The details for the Managed Services offer’s plan in Azure Marketplace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IPlan Plan { get; set; }
        /// <summary>Azure Marketplace plan name.</summary>
        string PlanName { get; set; }
        /// <summary>Azure Marketplace product code.</summary>
        string PlanProduct { get; set; }
        /// <summary>Azure Marketplace publisher ID.</summary>
        string PlanPublisher { get; set; }
        /// <summary>Azure Marketplace plan's version.</summary>
        string PlanVersion { get; set; }
        /// <summary>The properties of a registration definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinitionProperties Property { get; set; }
        /// <summary>The current provisioning state of the registration definition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the registration definition.</summary>
        string RegistrationDefinitionName { get; set; }
        /// <summary>
        /// The type of the Azure resource (Microsoft.ManagedServices/registrationDefinitions).
        /// </summary>
        string Type { get; set; }

    }
}