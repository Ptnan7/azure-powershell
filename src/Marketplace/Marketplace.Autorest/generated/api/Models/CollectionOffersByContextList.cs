// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>
    /// List of objects which describes offers per context. An empty GUID is a public context.
    /// </summary>
    public partial class CollectionOffersByContextList :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContextList,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContextListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContext> Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContextListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of offer list per context results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContext> _value;

        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContext> Value { get => this._value; }

        /// <summary>Creates an new <see cref="CollectionOffersByContextList" /> instance.</summary>
        public CollectionOffersByContextList()
        {

        }
    }
    /// List of objects which describes offers per context. An empty GUID is a public context.
    public partial interface ICollectionOffersByContextList :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of offer list per context results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"URL to get the next set of offer list per context results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContext) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContext> Value { get;  }

    }
    /// List of objects which describes offers per context. An empty GUID is a public context.
    internal partial interface ICollectionOffersByContextListInternal

    {
        /// <summary>URL to get the next set of offer list per context results if there are any.</summary>
        string NextLink { get; set; }

        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionOffersByContext> Value { get; set; }

    }
}