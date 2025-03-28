﻿// ----------------------------------------------------------------------------------
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

using AutoMapper;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;
using Microsoft.Azure.Commands.Network.VirtualNetworkGateway;
using System.Collections;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualNetworkGatewayConnection", DefaultParameterSetName = VirtualNetworkGatewayParameterSets.Default, SupportsShouldProcess = true),OutputType(typeof(PSVirtualNetworkGatewayConnection))]
    public class SetAzureVirtualNetworkGatewayConnectionCommand : VirtualNetworkGatewayConnectionBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The VirtualNetworkGatewayConnection")]
        public PSVirtualNetworkGatewayConnection VirtualNetworkGatewayConnection { get; set; }
        
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Whether to use a BGP session over a S2S VPN tunnel")]
        public bool? EnableBgp { get; set; }

        [Parameter(
        Mandatory = false,
        ValueFromPipelineByPropertyName = true,
        HelpMessage = "Dead Peer Detection Timeout of the connection in seconds.")]
        public int? DpdTimeoutInSeconds { get; set; }

        [Parameter(
        Mandatory = false,
        HelpMessage = "Virtual Network Gateway Connection Mode.")]
        [PSArgumentCompleter("Default", "ResponderOnly", "InitiatorOnly")]
        public string ConnectionMode { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Whether to use policy-based traffic selectors for a S2S connection")]
        public bool? UsePolicyBasedTrafficSelectors { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "Whether to use PrivateIP for a S2S connection")]
        public bool? UseLocalAzureIpAddress { get; set; }

        [Parameter(
             Mandatory = false,
             ValueFromPipelineByPropertyName = true,
             HelpMessage = "A list of IPSec policies.")]
        public PSIpsecPolicy[] IpsecPolicies { get; set; }

        [Parameter(
             Mandatory = false,
             ValueFromPipelineByPropertyName = true,
             HelpMessage = "A list of traffic selector policies.")]
        public PSTrafficSelectorPolicy[] TrafficSelectorPolicy { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The list of ingress NAT rules that are associated with this Connection.")]
        public PSResourceId[] IngressNatRule { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The list of egress  NAT rules that are associated with this Connection.")]
        public PSResourceId[] EgressNatRule { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The GatewayCustomBgpIpAddress of Virtual network gateway used in this connection.")]
        [AllowEmptyCollection]
        public PSGatewayCustomBgpIpConfiguration[] GatewayCustomBgpIpAddress { get; set; }

        [Parameter(
            Mandatory = true,
            ParameterSetName = VirtualNetworkGatewayParameterSets.UpdateResourceWithTags,
            HelpMessage = "A hashtable which represents resource tags.")]
        public Hashtable Tag { get; set; }

        [Parameter(
           Mandatory = false,
           HelpMessage = "Do not ask for confirmation if you want to overwrite a resource")]
        public SwitchParameter Force { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            base.Execute();

            ConfirmAction(
                Force.IsPresent,
                string.Format(Properties.Resources.OverwritingResource, VirtualNetworkGatewayConnection.Name),
                Properties.Resources.SettingResourceMessage,
                VirtualNetworkGatewayConnection.Name,
                () =>
                {
                    if (!this.IsVirtualNetworkGatewayConnectionPresent(this.VirtualNetworkGatewayConnection.ResourceGroupName, this.VirtualNetworkGatewayConnection.Name))
                    {
                        throw new ArgumentException(Properties.Resources.ResourceNotFound);
                    }

                    if (this.EnableBgp.HasValue)
                    {
                        this.VirtualNetworkGatewayConnection.EnableBgp = this.EnableBgp.Value;
                    }

                    if (this.DpdTimeoutInSeconds.HasValue)
                    {
                        this.VirtualNetworkGatewayConnection.DpdTimeoutSeconds = this.DpdTimeoutInSeconds.Value;
                    }

                    if (!String.IsNullOrEmpty(this.ConnectionMode))
                    {
                        this.VirtualNetworkGatewayConnection.ConnectionMode = this.ConnectionMode;
                    }

                    if (this.UsePolicyBasedTrafficSelectors.HasValue)
                    {
                        this.VirtualNetworkGatewayConnection.UsePolicyBasedTrafficSelectors = this.UsePolicyBasedTrafficSelectors.Value;
                    }

                    if (this.UseLocalAzureIpAddress.HasValue)
                    {
                        this.VirtualNetworkGatewayConnection.UseLocalAzureIpAddress = this.UseLocalAzureIpAddress.Value;
                    }

                    if (this.IpsecPolicies != null)
                    {
                        this.VirtualNetworkGatewayConnection.IpsecPolicies = this.IpsecPolicies?.ToList();
                    }

                    if (this.TrafficSelectorPolicy != null)
                    {
                        this.VirtualNetworkGatewayConnection.TrafficSelectorPolicies = this.TrafficSelectorPolicy?.ToList();
                    }

                    if (this.IngressNatRule != null)
                    {
                        this.VirtualNetworkGatewayConnection.IngressNatRules = new List<PSResourceId>();
                        foreach (var resource in this.IngressNatRule)
                        {
                            this.VirtualNetworkGatewayConnection.IngressNatRules.Add(
                                new PSResourceId()
                                {
                                    Id = resource.Id
                                });
                        }
                    }

                    if (this.EgressNatRule != null)
                    {
                        this.VirtualNetworkGatewayConnection.EgressNatRules = new List<PSResourceId>();
                        foreach (var resource in this.EgressNatRule)
                        {
                            this.VirtualNetworkGatewayConnection.EgressNatRules.Add(
                                new PSResourceId()
                                {
                                    Id = resource.Id
                                });
                        }
                    }

                    if (this.GatewayCustomBgpIpAddress != null && this.GatewayCustomBgpIpAddress.Length > 0)
                    {
                        if (this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses == null)
                        {
                            this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses = new List<PSGatewayCustomBgpIpConfiguration>();

                            foreach (var reqaddress in this.GatewayCustomBgpIpAddress)
                            {
                                this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses.Add(reqaddress);
                            }
                        }
                        else
                        {
                            foreach (var reqaddress in this.GatewayCustomBgpIpAddress)
                            {
                                bool isGatewayIpConfigurationExists = this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses.Any(
                                bgpaddress => bgpaddress.IpconfigurationId.Equals(reqaddress.IpconfigurationId, StringComparison.OrdinalIgnoreCase));

                                if (isGatewayIpConfigurationExists)
                                {
                                    var bgpPeeringPropertiesInRequest = this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses.FirstOrDefault(
                                        x => x.IpconfigurationId.Equals(reqaddress.IpconfigurationId, StringComparison.OrdinalIgnoreCase));

                                    bgpPeeringPropertiesInRequest.CustomBgpIpAddress = reqaddress.CustomBgpIpAddress;
                                }
                                else
                                {
                                    this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses.Add(reqaddress);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses != null && this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses.Count > 0)
                        {
                            this.VirtualNetworkGatewayConnection.GatewayCustomBgpIpAddresses.Clear();
                        }
                    }

                    Dictionary<string, List<string>> auxAuthHeader = null;
                    List<string> resourceIds = new List<string>();

                    // Get the aux header for the LNG2/VNG2
                    if (this.VirtualNetworkGatewayConnection.VirtualNetworkGateway2 != null)
                    {
                        resourceIds.Add(this.VirtualNetworkGatewayConnection.VirtualNetworkGateway2.Id);
                    }

                    if (this.VirtualNetworkGatewayConnection.LocalNetworkGateway2 != null)
                    {
                        resourceIds.Add(this.VirtualNetworkGatewayConnection.LocalNetworkGateway2.Id);
                    }
                    var auxHeaderDictionary = GetAuxilaryAuthHeaderFromResourceIds(resourceIds);
                    if (auxHeaderDictionary != null && auxHeaderDictionary.Count > 0)
                    {
                        auxAuthHeader = new Dictionary<string, List<string>>(auxHeaderDictionary);
                    }

                    var vnetGatewayConnectionModel = NetworkResourceManagerProfile.Mapper.Map<MNM.VirtualNetworkGatewayConnection>(this.VirtualNetworkGatewayConnection);
                    
                    vnetGatewayConnectionModel.Tags =
                        ParameterSetName.Equals(VirtualNetworkGatewayParameterSets.UpdateResourceWithTags) ?
                        TagsConversionHelper.CreateTagDictionary(this.Tag, validate: true) :
                        TagsConversionHelper.CreateTagDictionary(this.VirtualNetworkGatewayConnection.Tag, validate: true);

                    this.VirtualNetworkGatewayConnectionClient.CreateOrUpdateWithHttpMessagesAsync(this.VirtualNetworkGatewayConnection.ResourceGroupName, this.VirtualNetworkGatewayConnection.Name, vnetGatewayConnectionModel, auxAuthHeader).GetAwaiter().GetResult();

                    var getvnetGatewayConnection = this.GetVirtualNetworkGatewayConnection(this.VirtualNetworkGatewayConnection.ResourceGroupName, this.VirtualNetworkGatewayConnection.Name);
                    WriteObject(getvnetGatewayConnection);
                });

        }
    }
}
