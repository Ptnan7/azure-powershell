// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Details of the user's elastic deployment associated with the monitor resource.</summary>
    public partial class ElasticCloudDeployment
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject into a new instance of <see cref="ElasticCloudDeployment" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ElasticCloudDeployment(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)_name;}
            {_deploymentId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("deploymentId"), out var __jsonDeploymentId) ? (string)__jsonDeploymentId : (string)_deploymentId;}
            {_azureSubscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("azureSubscriptionId"), out var __jsonAzureSubscriptionId) ? (string)__jsonAzureSubscriptionId : (string)_azureSubscriptionId;}
            {_elasticsearchRegion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("elasticsearchRegion"), out var __jsonElasticsearchRegion) ? (string)__jsonElasticsearchRegion : (string)_elasticsearchRegion;}
            {_elasticsearchServiceUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("elasticsearchServiceUrl"), out var __jsonElasticsearchServiceUrl) ? (string)__jsonElasticsearchServiceUrl : (string)_elasticsearchServiceUrl;}
            {_kibanaServiceUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("kibanaServiceUrl"), out var __jsonKibanaServiceUrl) ? (string)__jsonKibanaServiceUrl : (string)_kibanaServiceUrl;}
            {_kibanaSsoUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString>("kibanaSsoUrl"), out var __jsonKibanaSsoUrl) ? (string)__jsonKibanaSsoUrl : (string)_kibanaSsoUrl;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticCloudDeployment FromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject json ? new ElasticCloudDeployment(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ElasticCloudDeployment" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ElasticCloudDeployment" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._deploymentId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._deploymentId.ToString()) : null, "deploymentId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._azureSubscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._azureSubscriptionId.ToString()) : null, "azureSubscriptionId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._elasticsearchRegion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._elasticsearchRegion.ToString()) : null, "elasticsearchRegion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._elasticsearchServiceUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._elasticsearchServiceUrl.ToString()) : null, "elasticsearchServiceUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._kibanaServiceUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._kibanaServiceUrl.ToString()) : null, "kibanaServiceUrl" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._kibanaSsoUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonString(this._kibanaSsoUrl.ToString()) : null, "kibanaSsoUrl" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}