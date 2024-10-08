// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="HciClusterDeploymentSettingResource"/> and their operations.
    /// Each <see cref="HciClusterDeploymentSettingResource"/> in the collection will belong to the same instance of <see cref="HciClusterResource"/>.
    /// To get a <see cref="HciClusterDeploymentSettingCollection"/> instance call the GetHciClusterDeploymentSettings method from an instance of <see cref="HciClusterResource"/>.
    /// </summary>
    public partial class HciClusterDeploymentSettingCollection : ArmCollection, IEnumerable<HciClusterDeploymentSettingResource>, IAsyncEnumerable<HciClusterDeploymentSettingResource>
    {
        private readonly ClientDiagnostics _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics;
        private readonly DeploymentSettingsRestOperations _hciClusterDeploymentSettingDeploymentSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HciClusterDeploymentSettingCollection"/> class for mocking. </summary>
        protected HciClusterDeploymentSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HciClusterDeploymentSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HciClusterDeploymentSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", HciClusterDeploymentSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HciClusterDeploymentSettingResource.ResourceType, out string hciClusterDeploymentSettingDeploymentSettingsApiVersion);
            _hciClusterDeploymentSettingDeploymentSettingsRestClient = new DeploymentSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hciClusterDeploymentSettingDeploymentSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HciClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HciClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DeploymentSetting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HciClusterDeploymentSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string deploymentSettingsName, HciClusterDeploymentSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<HciClusterDeploymentSettingResource>(new HciClusterDeploymentSettingOperationSource(Client), _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics, Pipeline, _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a DeploymentSetting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HciClusterDeploymentSettingResource> CreateOrUpdate(WaitUntil waitUntil, string deploymentSettingsName, HciClusterDeploymentSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, data, cancellationToken);
                var operation = new HciArmOperation<HciClusterDeploymentSettingResource>(new HciClusterDeploymentSettingOperationSource(Client), _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics, Pipeline, _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DeploymentSetting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> is null. </exception>
        public virtual async Task<Response<HciClusterDeploymentSettingResource>> GetAsync(string deploymentSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _hciClusterDeploymentSettingDeploymentSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciClusterDeploymentSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DeploymentSetting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> is null. </exception>
        public virtual Response<HciClusterDeploymentSettingResource> Get(string deploymentSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _hciClusterDeploymentSettingDeploymentSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HciClusterDeploymentSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DeploymentSetting resources by Clusters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_ListByClusters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HciClusterDeploymentSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HciClusterDeploymentSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateListByClustersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateListByClustersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HciClusterDeploymentSettingResource(Client, HciClusterDeploymentSettingData.DeserializeHciClusterDeploymentSettingData(e)), _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics, Pipeline, "HciClusterDeploymentSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DeploymentSetting resources by Clusters
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_ListByClusters</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HciClusterDeploymentSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HciClusterDeploymentSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateListByClustersRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hciClusterDeploymentSettingDeploymentSettingsRestClient.CreateListByClustersNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HciClusterDeploymentSettingResource(Client, HciClusterDeploymentSettingData.DeserializeHciClusterDeploymentSettingData(e)), _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics, Pipeline, "HciClusterDeploymentSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string deploymentSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hciClusterDeploymentSettingDeploymentSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> is null. </exception>
        public virtual Response<bool> Exists(string deploymentSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _hciClusterDeploymentSettingDeploymentSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> is null. </exception>
        public virtual async Task<NullableResponse<HciClusterDeploymentSettingResource>> GetIfExistsAsync(string deploymentSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hciClusterDeploymentSettingDeploymentSettingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HciClusterDeploymentSettingResource>(response.GetRawResponse());
                return Response.FromValue(new HciClusterDeploymentSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/clusters/{clusterName}/deploymentSettings/{deploymentSettingsName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentSettings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HciClusterDeploymentSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentSettingsName"> Name of Deployment Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentSettingsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentSettingsName"/> is null. </exception>
        public virtual NullableResponse<HciClusterDeploymentSettingResource> GetIfExists(string deploymentSettingsName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentSettingsName, nameof(deploymentSettingsName));

            using var scope = _hciClusterDeploymentSettingDeploymentSettingsClientDiagnostics.CreateScope("HciClusterDeploymentSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hciClusterDeploymentSettingDeploymentSettingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, deploymentSettingsName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HciClusterDeploymentSettingResource>(response.GetRawResponse());
                return Response.FromValue(new HciClusterDeploymentSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HciClusterDeploymentSettingResource> IEnumerable<HciClusterDeploymentSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HciClusterDeploymentSettingResource> IAsyncEnumerable<HciClusterDeploymentSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
