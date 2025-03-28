// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>Describes the properties of a hybrid machine.</summary>
    public partial class MachineProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json ? new MachineProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject into a new instance of <see cref="MachineProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MachineProperties(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_locationData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("locationData"), out var __jsonLocationData) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.LocationData.FromJson(__jsonLocationData) : _locationData;}
            {_agentConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("agentConfiguration"), out var __jsonAgentConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentConfiguration.FromJson(__jsonAgentConfiguration) : _agentConfiguration;}
            {_serviceStatuses = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("serviceStatuses"), out var __jsonServiceStatuses) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ServiceStatuses.FromJson(__jsonServiceStatuses) : _serviceStatuses;}
            {_cloudMetadata = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("cloudMetadata"), out var __jsonCloudMetadata) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.CloudMetadata.FromJson(__jsonCloudMetadata) : _cloudMetadata;}
            {_agentUpgrade = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("agentUpgrade"), out var __jsonAgentUpgrade) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AgentUpgrade.FromJson(__jsonAgentUpgrade) : _agentUpgrade;}
            {_networkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("networkProfile"), out var __jsonNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.NetworkProfileAutoGenerated.FromJson(__jsonNetworkProfile) : _networkProfile;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_lastStatusChange = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("lastStatusChange"), out var __jsonLastStatusChange) ? global::System.DateTime.TryParse((string)__jsonLastStatusChange, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastStatusChangeValue) ? __jsonLastStatusChangeValue : _lastStatusChange : _lastStatusChange;}
            {_errorDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonArray>("errorDetails"), out var __jsonErrorDetails) ? If( __jsonErrorDetails as Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IErrorDetailAutoGenerated) (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ErrorDetailAutoGenerated.FromJson(__u) )) ))() : null : _errorDetail;}
            {_agentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("agentVersion"), out var __jsonAgentVersion) ? (string)__jsonAgentVersion : (string)_agentVersion;}
            {_vMId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("vmId"), out var __jsonVMId) ? (string)__jsonVMId : (string)_vMId;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)_displayName;}
            {_machineFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("machineFqdn"), out var __jsonMachineFqdn) ? (string)__jsonMachineFqdn : (string)_machineFqdn;}
            {_clientPublicKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("clientPublicKey"), out var __jsonClientPublicKey) ? (string)__jsonClientPublicKey : (string)_clientPublicKey;}
            {_oSName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osName"), out var __jsonOSName) ? (string)__jsonOSName : (string)_oSName;}
            {_oSVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osVersion"), out var __jsonOSVersion) ? (string)__jsonOSVersion : (string)_oSVersion;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)_oSType;}
            {_vMUuid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("vmUuid"), out var __jsonVMUuid) ? (string)__jsonVMUuid : (string)_vMUuid;}
            {_extension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonArray>("extensions"), out var __jsonExtensions) ? If( __jsonExtensions as Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionInstanceView>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IMachineExtensionInstanceView) (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.MachineExtensionInstanceView.FromJson(__p) )) ))() : null : _extension;}
            {_oSSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osSku"), out var __jsonOSSku) ? (string)__jsonOSSku : (string)_oSSku;}
            {_oSEdition = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("osEdition"), out var __jsonOSEdition) ? (string)__jsonOSEdition : (string)_oSEdition;}
            {_domainName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("domainName"), out var __jsonDomainName) ? (string)__jsonDomainName : (string)_domainName;}
            {_adFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("adFqdn"), out var __jsonAdFqdn) ? (string)__jsonAdFqdn : (string)_adFqdn;}
            {_dnsFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("dnsFqdn"), out var __jsonDnsFqdn) ? (string)__jsonDnsFqdn : (string)_dnsFqdn;}
            {_privateLinkScopeResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("privateLinkScopeResourceId"), out var __jsonPrivateLinkScopeResourceId) ? (string)__jsonPrivateLinkScopeResourceId : (string)_privateLinkScopeResourceId;}
            {_parentClusterResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("parentClusterResourceId"), out var __jsonParentClusterResourceId) ? (string)__jsonParentClusterResourceId : (string)_parentClusterResourceId;}
            {_mssqlDiscovered = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("mssqlDiscovered"), out var __jsonMssqlDiscovered) ? (string)__jsonMssqlDiscovered : (string)_mssqlDiscovered;}
            {_detectedProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("detectedProperties"), out var __jsonDetectedProperties) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.DetectedProperties.FromJson(__jsonDetectedProperties) : _detectedProperty;}
            {_oSProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("osProfile"), out var __jsonOSProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.OSProfile.FromJson(__jsonOSProfile) : _oSProfile;}
            {_licenseProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject>("licenseProfile"), out var __jsonLicenseProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.LicenseProfileMachineInstanceView.FromJson(__jsonLicenseProfile) : _licenseProfile;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MachineProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MachineProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._locationData ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._locationData.ToJson(null,serializationMode) : null, "locationData" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._agentConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._agentConfiguration.ToJson(null,serializationMode) : null, "agentConfiguration" ,container.Add );
            }
            AddIf( null != this._serviceStatuses ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._serviceStatuses.ToJson(null,serializationMode) : null, "serviceStatuses" ,container.Add );
            AddIf( null != this._cloudMetadata ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._cloudMetadata.ToJson(null,serializationMode) : null, "cloudMetadata" ,container.Add );
            AddIf( null != this._agentUpgrade ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._agentUpgrade.ToJson(null,serializationMode) : null, "agentUpgrade" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._networkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._networkProfile.ToJson(null,serializationMode) : null, "networkProfile" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastStatusChange ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._lastStatusChange?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastStatusChange" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._errorDetail)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.XNodeArray();
                    foreach( var __x in this._errorDetail )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("errorDetails",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._agentVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._agentVersion.ToString()) : null, "agentVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._vMId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._vMId.ToString()) : null, "vmId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._machineFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._machineFqdn.ToString()) : null, "machineFqdn" ,container.Add );
            }
            AddIf( null != (((object)this._clientPublicKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._clientPublicKey.ToString()) : null, "clientPublicKey" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSName.ToString()) : null, "osName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSVersion.ToString()) : null, "osVersion" ,container.Add );
            }
            AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._vMUuid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._vMUuid.ToString()) : null, "vmUuid" ,container.Add );
            }
            if (null != this._extension)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.XNodeArray();
                foreach( var __s in this._extension )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("extensions",__r);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSSku.ToString()) : null, "osSku" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSEdition)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._oSEdition.ToString()) : null, "osEdition" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._domainName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._domainName.ToString()) : null, "domainName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._adFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._adFqdn.ToString()) : null, "adFqdn" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._dnsFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._dnsFqdn.ToString()) : null, "dnsFqdn" ,container.Add );
            }
            AddIf( null != (((object)this._privateLinkScopeResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._privateLinkScopeResourceId.ToString()) : null, "privateLinkScopeResourceId" ,container.Add );
            AddIf( null != (((object)this._parentClusterResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._parentClusterResourceId.ToString()) : null, "parentClusterResourceId" ,container.Add );
            AddIf( null != (((object)this._mssqlDiscovered)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._mssqlDiscovered.ToString()) : null, "mssqlDiscovered" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._detectedProperty ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._detectedProperty.ToJson(null,serializationMode) : null, "detectedProperties" ,container.Add );
            }
            AddIf( null != this._oSProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._oSProfile.ToJson(null,serializationMode) : null, "osProfile" ,container.Add );
            AddIf( null != this._licenseProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) this._licenseProfile.ToJson(null,serializationMode) : null, "licenseProfile" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}