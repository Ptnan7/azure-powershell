// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Properties of the deleted managed HSM.</summary>
    public partial class DeletedManagedHsmProperties :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmProperties,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DeletionDate" /> property.</summary>
        private global::System.DateTime? _deletionDate;

        /// <summary>The deleted date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public global::System.DateTime? DeletionDate { get => this._deletionDate; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Backing field for <see cref="MhsmId" /> property.</summary>
        private string _mhsmId;

        /// <summary>The resource id of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string MhsmId { get => this._mhsmId; }

        /// <summary>Internal Acessors for DeletionDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal.DeletionDate { get => this._deletionDate; set { {_deletionDate = value;} } }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for MhsmId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal.MhsmId { get => this._mhsmId; set { {_mhsmId = value;} } }

        /// <summary>Internal Acessors for PurgeProtectionEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal.PurgeProtectionEnabled { get => this._purgeProtectionEnabled; set { {_purgeProtectionEnabled = value;} } }

        /// <summary>Internal Acessors for ScheduledPurgeDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal.ScheduledPurgeDate { get => this._scheduledPurgeDate; set { {_scheduledPurgeDate = value;} } }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesTags Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesInternal.Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.DeletedManagedHsmPropertiesTags()); set { {_tag = value;} } }

        /// <summary>Backing field for <see cref="PurgeProtectionEnabled" /> property.</summary>
        private bool? _purgeProtectionEnabled;

        /// <summary>Purge protection status of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public bool? PurgeProtectionEnabled { get => this._purgeProtectionEnabled; }

        /// <summary>Backing field for <see cref="ScheduledPurgeDate" /> property.</summary>
        private global::System.DateTime? _scheduledPurgeDate;

        /// <summary>The scheduled purged date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public global::System.DateTime? ScheduledPurgeDate { get => this._scheduledPurgeDate; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesTags _tag;

        /// <summary>Tags of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.DeletedManagedHsmPropertiesTags()); }

        /// <summary>Creates an new <see cref="DeletedManagedHsmProperties" /> instance.</summary>
        public DeletedManagedHsmProperties()
        {

        }
    }
    /// Properties of the deleted managed HSM.
    public partial interface IDeletedManagedHsmProperties :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>The deleted date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The deleted date.",
        SerializedName = @"deletionDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DeletionDate { get;  }
        /// <summary>The location of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The location of the original managed HSM.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>The resource id of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource id of the original managed HSM.",
        SerializedName = @"mhsmId",
        PossibleTypes = new [] { typeof(string) })]
        string MhsmId { get;  }
        /// <summary>Purge protection status of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Purge protection status of the original managed HSM.",
        SerializedName = @"purgeProtectionEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PurgeProtectionEnabled { get;  }
        /// <summary>The scheduled purged date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The scheduled purged date.",
        SerializedName = @"scheduledPurgeDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ScheduledPurgeDate { get;  }
        /// <summary>Tags of the original managed HSM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Tags of the original managed HSM.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesTags Tag { get;  }

    }
    /// Properties of the deleted managed HSM.
    internal partial interface IDeletedManagedHsmPropertiesInternal

    {
        /// <summary>The deleted date.</summary>
        global::System.DateTime? DeletionDate { get; set; }
        /// <summary>The location of the original managed HSM.</summary>
        string Location { get; set; }
        /// <summary>The resource id of the original managed HSM.</summary>
        string MhsmId { get; set; }
        /// <summary>Purge protection status of the original managed HSM.</summary>
        bool? PurgeProtectionEnabled { get; set; }
        /// <summary>The scheduled purged date.</summary>
        global::System.DateTime? ScheduledPurgeDate { get; set; }
        /// <summary>Tags of the original managed HSM.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDeletedManagedHsmPropertiesTags Tag { get; set; }

    }
}