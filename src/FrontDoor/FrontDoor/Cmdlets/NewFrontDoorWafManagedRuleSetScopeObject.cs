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
    /// Defines the New-AzFrontDoorWafManagedRuleSetScopeObject cmdlet.
    /// </summary>
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "FrontDoorWafManagedRuleSetScopeObject"), OutputType(typeof(PSManagedRuleSetScope))]
    public class NewFrontDoorWafManagedRuleSetScopeObject : AzureFrontDoorCmdletBase
    {
        /// <summary>
        /// Rule set type.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Rule set type.")]
        public string RuleSetType { get; set; }

        /// <summary>
        /// Rule set version.
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "Rule set version.")]
        public string RuleSetVersion { get; set; }

        /// <summary>
        /// Rule group scopes.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "Rule group scopes.")]
        public PSRuleGroupScope[] RuleGroupScopes { get; set; }

        public override void ExecuteCmdlet()
        {
            var scope = new PSManagedRuleSetScope
            {
                RuleSetType = RuleSetType,
                RuleSetVersion = RuleSetVersion,
                RuleGroupScopes = RuleGroupScopes?.ToList()
            };
            WriteObject(scope);
        }
    }
}