// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SqlPoolOperationResultsOperations
    /// </summary>
    public static partial class SqlPoolOperationResultsOperationsExtensions
    {
        /// <summary>
        /// Get the status of a SQL pool operation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='operationId'>
        /// Operation ID
        /// </param>
        public static SqlPool GetLocationHeaderResult(this ISqlPoolOperationResultsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string operationId)
        {
                return ((ISqlPoolOperationResultsOperations)operations).GetLocationHeaderResultAsync(resourceGroupName, workspaceName, sqlPoolName, operationId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the status of a SQL pool operation
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace.
        /// </param>
        /// <param name='sqlPoolName'>
        /// SQL pool name
        /// </param>
        /// <param name='operationId'>
        /// Operation ID
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<SqlPool> GetLocationHeaderResultAsync(this ISqlPoolOperationResultsOperations operations, string resourceGroupName, string workspaceName, string sqlPoolName, string operationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetLocationHeaderResultWithHttpMessagesAsync(resourceGroupName, workspaceName, sqlPoolName, operationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
