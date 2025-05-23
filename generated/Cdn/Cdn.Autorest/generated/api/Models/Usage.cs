// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Describes resource usage.</summary>
    public partial class Usage :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsage,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageInternal
    {

        /// <summary>Backing field for <see cref="CurrentValue" /> property.</summary>
        private long _currentValue;

        /// <summary>The current value of the usage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public long CurrentValue { get => this._currentValue; set => this._currentValue = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private long _limit;

        /// <summary>The limit of usage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public long Limit { get => this._limit; set => this._limit = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageName Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageInternal.Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UsageName()); set { {_name = value;} } }

        /// <summary>Internal Acessors for Unit</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageInternal.Unit { get => this._unit; set { {_unit = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageName _name;

        /// <summary>The name of the type of usage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageName Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.UsageName()); set => this._name = value; }

        /// <summary>A localized string describing the resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string NameLocalizedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageNameInternal)Name).LocalizedValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageNameInternal)Name).LocalizedValue = value ?? null; }

        /// <summary>A string describing the resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string NameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageNameInternal)Name).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageNameInternal)Name).Value = value ?? null; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit= @"Count";

        /// <summary>An enum describing the unit of measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; }

        /// <summary>Creates an new <see cref="Usage" /> instance.</summary>
        public Usage()
        {

        }
    }
    /// Describes resource usage.
    public partial interface IUsage :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>The current value of the usage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The current value of the usage.",
        SerializedName = @"currentValue",
        PossibleTypes = new [] { typeof(long) })]
        long CurrentValue { get; set; }
        /// <summary>Resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The limit of usage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The limit of usage.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(long) })]
        long Limit { get; set; }
        /// <summary>A localized string describing the resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A localized string describing the resource name.",
        SerializedName = @"localizedValue",
        PossibleTypes = new [] { typeof(string) })]
        string NameLocalizedValue { get; set; }
        /// <summary>A string describing the resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A string describing the resource name.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string NameValue { get; set; }
        /// <summary>An enum describing the unit of measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"An enum describing the unit of measurement.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get;  }

    }
    /// Describes resource usage.
    internal partial interface IUsageInternal

    {
        /// <summary>The current value of the usage.</summary>
        long CurrentValue { get; set; }
        /// <summary>Resource identifier.</summary>
        string Id { get; set; }
        /// <summary>The limit of usage.</summary>
        long Limit { get; set; }
        /// <summary>The name of the type of usage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IUsageName Name { get; set; }
        /// <summary>A localized string describing the resource name.</summary>
        string NameLocalizedValue { get; set; }
        /// <summary>A string describing the resource name.</summary>
        string NameValue { get; set; }
        /// <summary>An enum describing the unit of measurement.</summary>
        string Unit { get; set; }

    }
}