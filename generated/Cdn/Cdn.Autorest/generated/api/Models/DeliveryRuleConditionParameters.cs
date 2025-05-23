// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Defines the parameters for delivery rule match conditions</summary>
    public partial class DeliveryRuleConditionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleConditionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IDeliveryRuleConditionParametersInternal
    {

        /// <summary>Backing field for <see cref="TypeName" /> property.</summary>
        private string _typeName;

        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string TypeName { get => this._typeName; set => this._typeName = value; }

        /// <summary>Creates an new <see cref="DeliveryRuleConditionParameters" /> instance.</summary>
        public DeliveryRuleConditionParameters()
        {

        }
    }
    /// Defines the parameters for delivery rule match conditions
    public partial interface IDeliveryRuleConditionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"typeName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("DeliveryRuleRemoteAddressConditionParameters", "DeliveryRuleRequestMethodConditionParameters", "DeliveryRuleQueryStringConditionParameters", "DeliveryRulePostArgsConditionParameters", "DeliveryRuleRequestUriConditionParameters", "DeliveryRuleRequestHeaderConditionParameters", "DeliveryRuleRequestBodyConditionParameters", "DeliveryRuleRequestSchemeConditionParameters", "DeliveryRuleUrlPathMatchConditionParameters", "DeliveryRuleUrlFileExtensionMatchConditionParameters", "DeliveryRuleUrlFilenameConditionParameters", "DeliveryRuleHttpVersionConditionParameters", "DeliveryRuleCookiesConditionParameters", "DeliveryRuleIsDeviceConditionParameters", "DeliveryRuleSocketAddrConditionParameters", "DeliveryRuleClientPortConditionParameters", "DeliveryRuleServerPortConditionParameters", "DeliveryRuleHostNameConditionParameters", "DeliveryRuleSslProtocolConditionParameters")]
        string TypeName { get; set; }

    }
    /// Defines the parameters for delivery rule match conditions
    internal partial interface IDeliveryRuleConditionParametersInternal

    {
        [global::Microsoft.Azure.PowerShell.Cmdlets.Cdn.PSArgumentCompleterAttribute("DeliveryRuleRemoteAddressConditionParameters", "DeliveryRuleRequestMethodConditionParameters", "DeliveryRuleQueryStringConditionParameters", "DeliveryRulePostArgsConditionParameters", "DeliveryRuleRequestUriConditionParameters", "DeliveryRuleRequestHeaderConditionParameters", "DeliveryRuleRequestBodyConditionParameters", "DeliveryRuleRequestSchemeConditionParameters", "DeliveryRuleUrlPathMatchConditionParameters", "DeliveryRuleUrlFileExtensionMatchConditionParameters", "DeliveryRuleUrlFilenameConditionParameters", "DeliveryRuleHttpVersionConditionParameters", "DeliveryRuleCookiesConditionParameters", "DeliveryRuleIsDeviceConditionParameters", "DeliveryRuleSocketAddrConditionParameters", "DeliveryRuleClientPortConditionParameters", "DeliveryRuleServerPortConditionParameters", "DeliveryRuleHostNameConditionParameters", "DeliveryRuleSslProtocolConditionParameters")]
        string TypeName { get; set; }

    }
}