
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------
[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute('PSUseSingularNouns', '',
    Justification = 'Kubernetes is a recognised term', Scope = 'Function', Target = 'Update-AzConnectedKubernetes')]
param()

<#
.Synopsis
API to update certain properties of the connected cluster resource
.Description
API to update certain properties of the connected cluster resource
.Example
Update-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Tag @{'key'='1'}
.Example
Get-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group | Update-AzConnectedKubernetes -Tag @{'key'='2'}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IConnectedKubernetesIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IConnectedCluster
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IConnectedKubernetesIdentity>: Identity Parameter
  [ClusterName <String>]: The name of the Kubernetes cluster on which get is called.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://learn.microsoft.com/powershell/module/az.connectedkubernetes/update-azconnectedkubernetes
#>
function Update-AzConnectedKubernetes {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IConnectedCluster])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
        [Alias('Name')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
        [System.String]
        # The name of the Kubernetes cluster on which get is called.
        ${ClusterName},

        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaJsonFilePath')]
        [Parameter(ParameterSetName='UpdateViaJsonString')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IConnectedKubernetesIdentity]
        # Identity Parameter
        ${InputObject},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.PSArgumentCompleterAttribute("True", "False", "NotApplicable")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
        [System.String]
        # Indicates whether Azure Hybrid Benefit is opted in
        ${AzureHybridBenefit},

        [Parameter()]
        [System.Management.Automation.SwitchParameter]
        # Accept EULA of ConnectedKubernetes, legal term will pop up without this parameter provided
        ${AcceptEULA},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
        [System.String]
        # Represents the distribution of the connected cluster
        ${Distribution},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
        [System.String]
        # Represents the Kubernetes distribution version on this connected cluster.
        ${DistributionVersion},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.IConnectedClusterPatchTags]))]
        [System.Collections.Hashtable]
        # Resource tags.
        ${Tag},

        [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
        [System.String]
        # Path of Json file supplied to the Update operation
        ${JsonFilePath},
    
        [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
        [System.String]
        # Json string supplied to the Update operation
        ${JsonString},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        if ($AzureHybridBenefit) {
            if (!$AcceptEULA) {
                $legalTermPath = Join-Path $PSScriptRoot -ChildPath "LegalTerm.txt"
                try {
                    $legalTerm = (Get-Content -Path $legalTermPath) -join "`r`n"
                }
                catch {
                    Write-Error "Get legal term failed."
                    throw
                }
                $confirmation = Read-Host $legalTerm"`n[Y] Yes  [N] No  (default is `"N`")"
                if ($confirmation -ine "Y") {
                    Return
                }
            }
        }
        $null = $PSBoundParameters.Remove('AcceptEULA')

        if ($PSCmdlet.ShouldProcess($PSBoundParameters)) {
            Az.ConnectedKubernetes.internal\Update-AzConnectedKubernetes @PSBoundParameters
        }
    }
}