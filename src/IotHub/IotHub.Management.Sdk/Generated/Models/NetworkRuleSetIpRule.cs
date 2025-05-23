// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System.Linq;

    /// <summary>
    /// IP Rule to be applied as part of Network Rule Set
    /// </summary>
    public partial class NetworkRuleSetIpRule
    {
        /// <summary>
        /// Initializes a new instance of the NetworkRuleSetIpRule class.
        /// </summary>
        public NetworkRuleSetIpRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkRuleSetIpRule class.
        /// </summary>

        /// <param name="filterName">Name of the IP filter rule.
        /// </param>

        /// <param name="action">IP Filter Action
        /// Possible values include: &#39;Allow&#39;</param>

        /// <param name="ipMask">A string that contains the IP address range in CIDR notation for the rule.
        /// </param>
        public NetworkRuleSetIpRule(string filterName, string ipMask, string action = default(string))

        {
            this.FilterName = filterName;
            this.Action = action;
            this.IPMask = ipMask;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the IP filter rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "filterName")]
        public string FilterName {get; set; }

        /// <summary>
        /// Gets or sets iP Filter Action Possible values include: &#39;Allow&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "action")]
        public string Action {get; set; }

        /// <summary>
        /// Gets or sets a string that contains the IP address range in CIDR notation
        /// for the rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ipMask")]
        public string IPMask {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.FilterName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "FilterName");
            }
            if (this.IPMask == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "IPMask");
            }



        }
    }
}