// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// NetworkVirtualAppliancesOperations operations.
    /// </summary>
    public partial interface INetworkVirtualAppliancesOperations
    {
        /// <summary>
        /// Deletes the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Deletes the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<NetworkVirtualAppliancesDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Gets the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='expand'>
        /// Expands referenced resources.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualAppliance>> GetWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, string expand = default(string), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Updates a Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Updates a Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of Network Virtual Appliance.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance being updated.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to Update Network Virtual Appliance Tags.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualAppliance>> UpdateTagsWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, TagsObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Creates or updates the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update Network Virtual Appliance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualAppliance,NetworkVirtualAppliancesCreateOrUpdateHeaders>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Restarts one or more VMs belonging to the specified Network Virtual
        /// Appliance.
        /// </summary>
        /// <remarks>
        /// Restarts one or more VMs belonging to the specified Network Virtual
        /// Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='networkVirtualApplianceInstanceIds'>
        /// Specifies a list of virtual machine instance IDs from the Network Virtual
        /// Appliance VM instances.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualApplianceInstanceIds,NetworkVirtualAppliancesRestartHeaders>> RestartWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualApplianceInstanceIds networkVirtualApplianceInstanceIds = default(NetworkVirtualApplianceInstanceIds), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Reimages one VM belonging to the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Reimages one VM belonging to the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='networkVirtualApplianceInstanceIds'>
        /// Specifies a list of virtual machine instance IDs from the Network Virtual
        /// Appliance VM instances.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualApplianceInstanceIds,NetworkVirtualAppliancesReimageHeaders>> ReimageWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualApplianceInstanceIds networkVirtualApplianceInstanceIds = default(NetworkVirtualApplianceInstanceIds), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the boot diagnostic logs for a VM instance belonging to the
        /// specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Retrieves the boot diagnostic logs for a VM instance belonging to the
        /// specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='request'>
        /// Parameters supplied to retrieve boot diagnostic logs for a NVA VM instance
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualApplianceInstanceId,NetworkVirtualAppliancesGetBootDiagnosticLogsHeaders>> GetBootDiagnosticLogsWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualApplianceBootDiagnosticParameters request, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all Network Virtual Appliances in a resource group.
        /// </summary>
        /// <remarks>
        /// Lists all Network Virtual Appliances in a resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NetworkVirtualAppliance>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all Network Virtual Appliances in a subscription.
        /// </summary>
        /// <remarks>
        /// Gets all Network Virtual Appliances in a subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NetworkVirtualAppliance>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Deletes the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<NetworkVirtualAppliancesDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates or updates the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Creates or updates the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update Network Virtual Appliance.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualAppliance,NetworkVirtualAppliancesCreateOrUpdateHeaders>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Restarts one or more VMs belonging to the specified Network Virtual
        /// Appliance.
        /// </summary>
        /// <remarks>
        /// Restarts one or more VMs belonging to the specified Network Virtual
        /// Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='networkVirtualApplianceInstanceIds'>
        /// Specifies a list of virtual machine instance IDs from the Network Virtual
        /// Appliance VM instances.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualApplianceInstanceIds,NetworkVirtualAppliancesRestartHeaders>> BeginRestartWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualApplianceInstanceIds networkVirtualApplianceInstanceIds = default(NetworkVirtualApplianceInstanceIds), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Reimages one VM belonging to the specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Reimages one VM belonging to the specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='networkVirtualApplianceInstanceIds'>
        /// Specifies a list of virtual machine instance IDs from the Network Virtual
        /// Appliance VM instances.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualApplianceInstanceIds,NetworkVirtualAppliancesReimageHeaders>> BeginReimageWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualApplianceInstanceIds networkVirtualApplianceInstanceIds = default(NetworkVirtualApplianceInstanceIds), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the boot diagnostic logs for a VM instance belonging to the
        /// specified Network Virtual Appliance.
        /// </summary>
        /// <remarks>
        /// Retrieves the boot diagnostic logs for a VM instance belonging to the
        /// specified Network Virtual Appliance.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkVirtualApplianceName'>
        /// The name of Network Virtual Appliance.
        /// </param>
        /// <param name='request'>
        /// Parameters supplied to retrieve boot diagnostic logs for a NVA VM instance
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<NetworkVirtualApplianceInstanceId,NetworkVirtualAppliancesGetBootDiagnosticLogsHeaders>> BeginGetBootDiagnosticLogsWithHttpMessagesAsync(string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualApplianceBootDiagnosticParameters request, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Lists all Network Virtual Appliances in a resource group.
        /// </summary>
        /// <remarks>
        /// Lists all Network Virtual Appliances in a resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NetworkVirtualAppliance>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets all Network Virtual Appliances in a subscription.
        /// </summary>
        /// <remarks>
        /// Gets all Network Virtual Appliances in a subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<NetworkVirtualAppliance>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}