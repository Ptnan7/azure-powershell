// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.PowerShell;

    /// <summary>Cluster Identity details.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterIdentityResponseTypeConverter))]
    public partial class ClusterIdentityResponse
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ClusterIdentityResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClusterIdentityResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ClusterIdentityResponsePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AadClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadClientId = (string) content.GetValueForProperty("AadClientId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadClientId, global::System.Convert.ToString);
            }
            if (content.Contains("AadTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadTenantId = (string) content.GetValueForProperty("AadTenantId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AadServicePrincipalObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadServicePrincipalObjectId = (string) content.GetValueForProperty("AadServicePrincipalObjectId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadServicePrincipalObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("AadApplicationObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadApplicationObjectId = (string) content.GetValueForProperty("AadApplicationObjectId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadApplicationObjectId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ClusterIdentityResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClusterIdentityResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ClusterIdentityResponsePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AadClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadClientId = (string) content.GetValueForProperty("AadClientId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadClientId, global::System.Convert.ToString);
            }
            if (content.Contains("AadTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadTenantId = (string) content.GetValueForProperty("AadTenantId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AadServicePrincipalObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadServicePrincipalObjectId = (string) content.GetValueForProperty("AadServicePrincipalObjectId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadServicePrincipalObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("AadApplicationObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadApplicationObjectId = (string) content.GetValueForProperty("AadApplicationObjectId",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponseInternal)this).AadApplicationObjectId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ClusterIdentityResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClusterIdentityResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.ClusterIdentityResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClusterIdentityResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClusterIdentityResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ClusterIdentityResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IClusterIdentityResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Cluster Identity details.
    [System.ComponentModel.TypeConverter(typeof(ClusterIdentityResponseTypeConverter))]
    public partial interface IClusterIdentityResponse

    {

    }
}