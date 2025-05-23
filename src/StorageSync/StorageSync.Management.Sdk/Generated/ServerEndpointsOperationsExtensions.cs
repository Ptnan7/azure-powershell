// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ServerEndpointsOperations
    /// </summary>
    public static partial class ServerEndpointsOperationsExtensions
    {
        /// <summary>
        /// Create a new ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpoint Create(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointCreateParameters parameters)
        {
                return ((IServerEndpointsOperations)operations).CreateAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpoint> CreateAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointCreateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpoint Update(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointUpdateParameters parameters = default(ServerEndpointUpdateParameters))
        {
                return ((IServerEndpointsOperations)operations).UpdateAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpoint> UpdateAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointUpdateParameters parameters = default(ServerEndpointUpdateParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get a ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpoint Get(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName)
        {
                return ((IServerEndpointsOperations)operations).GetAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpoint> GetAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpointsDeleteHeaders Delete(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName)
        {
                return ((IServerEndpointsOperations)operations).DeleteAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpointsDeleteHeaders> DeleteAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
        /// <summary>
        /// Get a ServerEndpoint list.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        public static System.Collections.Generic.IEnumerable<ServerEndpoint> ListBySyncGroup(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName)
        {
                return ((IServerEndpointsOperations)operations).ListBySyncGroupAsync(resourceGroupName, storageSyncServiceName, syncGroupName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a ServerEndpoint list.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ServerEndpoint>> ListBySyncGroupAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySyncGroupWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Recall a server endpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpointsRecallActionHeaders RecallAction(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, RecallActionParameters parameters)
        {
                return ((IServerEndpointsOperations)operations).RecallActionAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Recall a server endpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpointsRecallActionHeaders> RecallActionAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, RecallActionParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.RecallActionWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
        /// <summary>
        /// Create a new ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpoint BeginCreate(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointCreateParameters parameters)
        {
                return ((IServerEndpointsOperations)operations).BeginCreateAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpoint> BeginCreateAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointCreateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpoint BeginUpdate(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointUpdateParameters parameters = default(ServerEndpointUpdateParameters))
        {
                return ((IServerEndpointsOperations)operations).BeginUpdateAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpoint> BeginUpdateAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointUpdateParameters parameters = default(ServerEndpointUpdateParameters), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpointsDeleteHeaders BeginDelete(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName)
        {
                return ((IServerEndpointsOperations)operations).BeginDeleteAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a given ServerEndpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpointsDeleteHeaders> BeginDeleteAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
        /// <summary>
        /// Recall a server endpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        public static ServerEndpointsRecallActionHeaders BeginRecallAction(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, RecallActionParameters parameters)
        {
                return ((IServerEndpointsOperations)operations).BeginRecallActionAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Recall a server endpoint.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ServerEndpointsRecallActionHeaders> BeginRecallActionAsync(this IServerEndpointsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, RecallActionParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginRecallActionWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, serverEndpointName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Headers;
            }
        }
    }
}
