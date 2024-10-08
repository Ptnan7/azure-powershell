// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>A SynapseSpark compute.</summary>
    [System.ComponentModel.TypeConverter(typeof(SynapseSparkTypeConverter))]
    public partial class SynapseSpark
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSpark"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSpark DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SynapseSpark(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSpark"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSpark DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SynapseSpark(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SynapseSpark" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SynapseSpark" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSpark FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SynapseSpark(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSparkPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType.CreateFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ModifiedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ModifiedOn = (global::System.DateTime?) content.GetValueForProperty("ModifiedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ModifiedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningError = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse[]) content.GetValueForProperty("ProvisioningError",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ErrorResponseTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsAttachedCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).IsAttachedCompute = (bool?) content.GetValueForProperty("IsAttachedCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).IsAttachedCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoScaleProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScaleProperty = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoScaleProperties) content.GetValueForProperty("AutoScaleProperty",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScaleProperty, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoScalePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AutoPauseProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPauseProperty = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoPauseProperties) content.GetValueForProperty("AutoPauseProperty",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPauseProperty, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoPausePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SparkVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SparkVersion = (string) content.GetValueForProperty("SparkVersion",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SparkVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeCount = (int?) content.GetValueForProperty("NodeCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NodeSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSize = (string) content.GetValueForProperty("NodeSize",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSize, global::System.Convert.ToString);
            }
            if (content.Contains("NodeSizeFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSizeFamily = (string) content.GetValueForProperty("NodeSizeFamily",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSizeFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).ResourceGroup = (string) content.GetValueForProperty("ResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).ResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("WorkspaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).WorkspaceName = (string) content.GetValueForProperty("WorkspaceName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).WorkspaceName, global::System.Convert.ToString);
            }
            if (content.Contains("PoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).PoolName = (string) content.GetValueForProperty("PoolName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).PoolName, global::System.Convert.ToString);
            }
            if (content.Contains("AutoScalePropertyMinNodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMinNodeCount = (int?) content.GetValueForProperty("AutoScalePropertyMinNodeCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMinNodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AutoScalePropertyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyEnabled = (bool?) content.GetValueForProperty("AutoScalePropertyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoScalePropertyMaxNodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMaxNodeCount = (int?) content.GetValueForProperty("AutoScalePropertyMaxNodeCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMaxNodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AutoPausePropertyDelayInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyDelayInMinute = (int?) content.GetValueForProperty("AutoPausePropertyDelayInMinute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyDelayInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AutoPausePropertyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyEnabled = (bool?) content.GetValueForProperty("AutoPausePropertyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSpark"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SynapseSpark(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.SynapseSparkPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Type = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Type, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeType.CreateFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).CreatedOn = (global::System.DateTime?) content.GetValueForProperty("CreatedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).CreatedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ModifiedOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ModifiedOn = (global::System.DateTime?) content.GetValueForProperty("ModifiedOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ModifiedOn, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningError = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse[]) content.GetValueForProperty("ProvisioningError",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).ProvisioningError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.IErrorResponse>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api30.ErrorResponseTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsAttachedCompute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).IsAttachedCompute = (bool?) content.GetValueForProperty("IsAttachedCompute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).IsAttachedCompute, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DisableLocalAuth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).DisableLocalAuth = (bool?) content.GetValueForProperty("DisableLocalAuth",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IComputeInternal)this).DisableLocalAuth, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoScaleProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScaleProperty = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoScaleProperties) content.GetValueForProperty("AutoScaleProperty",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScaleProperty, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoScalePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AutoPauseProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPauseProperty = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IAutoPauseProperties) content.GetValueForProperty("AutoPauseProperty",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPauseProperty, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.AutoPausePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SparkVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SparkVersion = (string) content.GetValueForProperty("SparkVersion",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SparkVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeCount = (int?) content.GetValueForProperty("NodeCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NodeSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSize = (string) content.GetValueForProperty("NodeSize",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSize, global::System.Convert.ToString);
            }
            if (content.Contains("NodeSizeFamily"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSizeFamily = (string) content.GetValueForProperty("NodeSizeFamily",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).NodeSizeFamily, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).ResourceGroup = (string) content.GetValueForProperty("ResourceGroup",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).ResourceGroup, global::System.Convert.ToString);
            }
            if (content.Contains("WorkspaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).WorkspaceName = (string) content.GetValueForProperty("WorkspaceName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).WorkspaceName, global::System.Convert.ToString);
            }
            if (content.Contains("PoolName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).PoolName = (string) content.GetValueForProperty("PoolName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).PoolName, global::System.Convert.ToString);
            }
            if (content.Contains("AutoScalePropertyMinNodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMinNodeCount = (int?) content.GetValueForProperty("AutoScalePropertyMinNodeCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMinNodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AutoScalePropertyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyEnabled = (bool?) content.GetValueForProperty("AutoScalePropertyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoScalePropertyMaxNodeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMaxNodeCount = (int?) content.GetValueForProperty("AutoScalePropertyMaxNodeCount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoScalePropertyMaxNodeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AutoPausePropertyDelayInMinute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyDelayInMinute = (int?) content.GetValueForProperty("AutoPausePropertyDelayInMinute",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyDelayInMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AutoPausePropertyEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyEnabled = (bool?) content.GetValueForProperty("AutoPausePropertyEnabled",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ISynapseSparkInternal)this).AutoPausePropertyEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// A SynapseSpark compute.
    [System.ComponentModel.TypeConverter(typeof(SynapseSparkTypeConverter))]
    public partial interface ISynapseSpark

    {

    }
}