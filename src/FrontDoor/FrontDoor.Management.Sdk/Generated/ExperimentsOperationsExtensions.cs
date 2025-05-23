// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.FrontDoor
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ExperimentsOperations
    /// </summary>
    public static partial class ExperimentsOperationsExtensions
    {
        /// <summary>
        /// Gets a list of Experiments
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Experiment> ListByProfile(this IExperimentsOperations operations, string resourceGroupName, string profileName)
        {
                return ((IExperimentsOperations)operations).ListByProfileAsync(resourceGroupName, profileName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of Experiments
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Experiment>> ListByProfileAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByProfileWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Gets an Experiment by ExperimentName
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static Experiment Get(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName)
        {
                return ((IExperimentsOperations)operations).GetAsync(resourceGroupName, profileName, experimentName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets an Experiment by ExperimentName
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Experiment> GetAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Creates or updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static Experiment CreateOrUpdate(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, Experiment parameters)
        {
                return ((IExperimentsOperations)operations).CreateOrUpdateAsync(resourceGroupName, profileName, experimentName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Experiment> CreateOrUpdateAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, Experiment parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static Experiment Update(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, ExperimentUpdateModel parameters)
        {
                return ((IExperimentsOperations)operations).UpdateAsync(resourceGroupName, profileName, experimentName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Experiment> UpdateAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, ExperimentUpdateModel parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static void Delete(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName)
        {
                ((IExperimentsOperations)operations).DeleteAsync(resourceGroupName, profileName, experimentName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Creates or updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static Experiment BeginCreateOrUpdate(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, Experiment parameters)
        {
                return ((IExperimentsOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, profileName, experimentName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Creates or updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Experiment> BeginCreateOrUpdateAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, Experiment parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static Experiment BeginUpdate(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, ExperimentUpdateModel parameters)
        {
                return ((IExperimentsOperations)operations).BeginUpdateAsync(resourceGroupName, profileName, experimentName, parameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Experiment> BeginUpdateAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, ExperimentUpdateModel parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Deletes an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        public static void BeginDelete(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName)
        {
                ((IExperimentsOperations)operations).BeginDeleteAsync(resourceGroupName, profileName, experimentName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes an Experiment
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// The Profile identifier associated with the Tenant and Partner
        /// </param>
        /// <param name='experimentName'>
        /// The Experiment identifier associated with the Experiment
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IExperimentsOperations operations, string resourceGroupName, string profileName, string experimentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, experimentName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Gets a list of Experiments
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Experiment> ListByProfileNext(this IExperimentsOperations operations, string nextPageLink)
        {
                return ((IExperimentsOperations)operations).ListByProfileNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets a list of Experiments
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Experiment>> ListByProfileNextAsync(this IExperimentsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
