// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.FrontDoor.Common;
using Microsoft.Azure.Commands.FrontDoor.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.FrontDoor.Cmdlets
{
    /// <summary>
    /// Defines the New-AzFrontDoorWafManagedRuleSetExceptionObject cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorWafManagedRuleSetExceptionObject"), OutputType(typeof(PSManagedRuleSetException))]
    public class NewFrontDoorWafManagedRuleSetExceptionObject : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// Match Variable. 
        /// Possible values include: 'RequestUri', 'SocketAddr', 'RequestHeaderNames'
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Match Variable. Possible values include: 'RequestUri', 'SocketAddr', 'RequestHeaderNames'")]
        [PSArgumentCompleter("RequestUri", "SocketAddr", "RequestHeaderNames")]
        public string MatchVariable { get; set; }

        /// <summary>
        /// Describes selector operator to be matched.
        /// Possible values include: 'Equals', 'Contains', 'StartsWith', 'EndsWith', 'EqualsAny'
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Describes selector operator to be matched. Possible values include: 'Equals', 'Contains', 'StartsWith', 'EndsWith', 'EqualsAny'")]
        [PSArgumentCompleter("Equals", "Contains", "StartsWith", "EndsWith", "EqualsAny")]
        public string SelectorMatchOperator { get; set; }

        /// <summary>
        /// Name of selector in RequestHeader or RequestBody to be matched
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Name of selector in RequestHeader or RequestBody to be matched")]
        public string Selector { get; set; }

        /// <summary>
        /// Describes value operator to be matched.
        /// Possible values include: 'Equals', 'Contains', 'StartsWith', 'EndsWith', 'EqualsAny', 'IPMatch'
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Describes value operator to be matched. Possible values include: 'Equals', 'Contains', 'StartsWith', 'EndsWith', 'EqualsAny', 'IPMatch'")]
        [PSArgumentCompleter("Equals", "Contains", "StartsWith", "EndsWith", "EqualsAny", "IPMatch")]
        public string ValueMatchOperator { get; set; }

        /// <summary>
        /// Match values.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Match values.")]
        public string[] MatchValues { get; set; }

        /// <summary>
        /// Managed rule set scopes.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Managed rule set scopes.")]
        public PSManagedRuleSetScope[] RuleSetScopes { get; set; }

        public override void ExecuteCmdlet()
        {
            ValidateArguments();

            var exception = new PSManagedRuleSetException
            {
                MatchVariable = MatchVariable,
                SelectorMatchOperator = SelectorMatchOperator,
                Selector = Selector,
                ValueMatchOperator = ValueMatchOperator,
                MatchValues = MatchValues?.ToList(),
                RuleSetScopes = RuleSetScopes?.ToList()
            };
            WriteObject(exception);
        }

        private void ValidateArguments()
        {
            if (SelectorMatchOperator == PSExceptionSelectorMatchOperator.EqualsAny.ToString() && Selector != null)
            {
                throw new PSArgumentException(nameof(Selector));
            }

            if (SelectorMatchOperator != PSExceptionSelectorMatchOperator.EqualsAny.ToString() && string.IsNullOrEmpty(Selector))
            {
                throw new PSArgumentNullException(nameof(Selector));
            }

            if (ValueMatchOperator != PSExceptionValueMatchOperator.EqualsAny.ToString() && (MatchValues == null || MatchValues.Length == 0) && (RuleSetScopes == null || RuleSetScopes.Length == 0))
            {
                throw new PSArgumentException("Either MatchValues or RuleSetScopes must be provided when ValueMatchOperator is not EqualsAny.");
            }
        }
    }
}