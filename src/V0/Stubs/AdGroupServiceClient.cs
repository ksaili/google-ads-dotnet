// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V0.Resources;
using gagvs = Google.Ads.GoogleAds.V0.Services;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using pb = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>
  /// Settings for a <see cref="AdGroupServiceClient"/>.
  /// </summary>
  public sealed partial class AdGroupServiceSettings : gaxgrpc::ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="AdGroupServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="AdGroupServiceSettings"/>.
    /// </returns>
    public static AdGroupServiceSettings GetDefault() => new AdGroupServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="AdGroupServiceSettings"/> object with default settings.
    /// </summary>
    public AdGroupServiceSettings() {
    }

    private AdGroupServiceSettings(AdGroupServiceSettings existing) : base(existing) {
      gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetAdGroupSettings = existing.GetAdGroupSettings;
      MutateAdGroupsSettings = existing.MutateAdGroupsSettings;
      OnCopy(existing);
    }

    partial void OnCopy(AdGroupServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
    /// <list type="bullet">
    /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
    /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
    /// </list>
    /// </remarks>
    public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter {
      get;
    } =
        gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

    /// <summary>
    /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
    /// for "NonIdempotent" <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter {
      get;
    } =
        gaxgrpc::RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="AdGroupServiceClient"/> RPC methods is defined as:
    /// <list type="bullet">
    /// <item><description>Initial delay: 100 milliseconds</description></item>
    /// <item><description>Maximum delay: 60000 milliseconds</description></item>
    /// <item><description>Delay multiplier: 1.3</description></item>
    /// </list>
    /// </remarks>
    public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
        delay: sys::TimeSpan.FromMilliseconds(100),
        maxDelay: sys::TimeSpan.FromMilliseconds(60000),
        delayMultiplier: 1.3
    );

    /// <summary>
    /// "Default" timeout backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="AdGroupServiceClient"/> RPC methods is defined as:
    /// <list type="bullet">
    /// <item><description>Initial timeout: 20000 milliseconds</description></item>
    /// <item><description>Timeout multiplier: 1.0</description></item>
    /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
    /// </list>
    /// </remarks>
    public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
        delay: sys::TimeSpan.FromMilliseconds(20000),
        maxDelay: sys::TimeSpan.FromMilliseconds(20000),
        delayMultiplier: 1.0
    );

    /// <summary>
    /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
    /// <c>AdGroupServiceClient.GetAdGroup</c> and <c>AdGroupServiceClient.GetAdGroupAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>AdGroupServiceClient.GetAdGroup</c> and
    /// <c>AdGroupServiceClient.GetAdGroupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
    /// <list type="bullet">
    /// <item><description>Initial retry delay: 100 milliseconds</description></item>
    /// <item><description>Retry delay multiplier: 1.3</description></item>
    /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
    /// <item><description>Initial timeout: 20000 milliseconds</description></item>
    /// <item><description>Timeout multiplier: 1.0</description></item>
    /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
    /// </list>
    /// Retry will be attempted on the following response status codes:
    /// <list>
    /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
    /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
    /// </list>
    /// Default RPC expiration is 600000 milliseconds.
    /// </remarks>
    public gaxgrpc::CallSettings GetAdGroupSettings {
      get; set;
    } = gaxgrpc::CallSettings.FromCallTiming(
        gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
            retryBackoff: GetDefaultRetryBackoff(),
            timeoutBackoff: GetDefaultTimeoutBackoff(),
            totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
            retryFilter: IdempotentRetryFilter
        )));

    /// <summary>
    /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
    /// <c>AdGroupServiceClient.MutateAdGroups</c> and <c>AdGroupServiceClient.MutateAdGroupsAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>AdGroupServiceClient.MutateAdGroups</c> and
    /// <c>AdGroupServiceClient.MutateAdGroupsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
    /// <list type="bullet">
    /// <item><description>Initial retry delay: 100 milliseconds</description></item>
    /// <item><description>Retry delay multiplier: 1.3</description></item>
    /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
    /// <item><description>Initial timeout: 20000 milliseconds</description></item>
    /// <item><description>Timeout multiplier: 1.0</description></item>
    /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
    /// </list>
    /// Retry will be attempted on the following response status codes:
    /// <list>
    /// <item><description>No status codes</description></item>
    /// </list>
    /// Default RPC expiration is 600000 milliseconds.
    /// </remarks>
    public gaxgrpc::CallSettings MutateAdGroupsSettings {
      get; set;
    } = gaxgrpc::CallSettings.FromCallTiming(
        gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
            retryBackoff: GetDefaultRetryBackoff(),
            timeoutBackoff: GetDefaultTimeoutBackoff(),
            totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
            retryFilter: NonIdempotentRetryFilter
        )));

    /// <summary>
    /// Creates a deep clone of this object, with all the same property values.
    /// </summary>
    /// <returns>A deep clone of this <see cref="AdGroupServiceSettings"/> object.</returns>
    public AdGroupServiceSettings Clone() => new AdGroupServiceSettings(this);
  }

  /// <summary>
  /// AdGroupService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class AdGroupServiceClient {

    /// <summary>
    /// The default endpoint for the AdGroupService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default AdGroupService scopes.
    /// </summary>
    /// <remarks>
    /// The default AdGroupService scopes are:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public static scg::IReadOnlyList<string> DefaultScopes {
      get;
    } = new sco::ReadOnlyCollection<string>(new string[] {
        });

    private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

    /// <summary>
    /// Asynchronously creates a <see cref="AdGroupServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary. See the example for how to use custom credentials.
    /// </summary>
    /// <example>
    /// This sample shows how to create a client using default credentials:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// ...
    /// // When running on Google Cloud Platform this will use the project Compute Credential.
    /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
    /// // credential file to use that credential.
    /// AdGroupServiceClient client = await AdGroupServiceClient.CreateAsync();
    /// </code>
    /// This sample shows how to create a client using credentials loaded from a JSON file:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// using Google.Apis.Auth.OAuth2;
    /// using Grpc.Auth;
    /// using Grpc.Core;
    /// ...
    /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
    /// Channel channel = new Channel(
    ///     AdGroupServiceClient.DefaultEndpoint.Host, AdGroupServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
    /// AdGroupServiceClient client = AdGroupServiceClient.Create(channel);
    /// ...
    /// // Shutdown the channel when it is no longer required.
    /// await channel.ShutdownAsync();
    /// </code>
    /// </example>
    /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="AdGroupServiceClient"/>.</returns>
    public static async stt::Task<AdGroupServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AdGroupServiceSettings settings = null) {
      grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="AdGroupServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary. See the example for how to use custom credentials.
    /// </summary>
    /// <example>
    /// This sample shows how to create a client using default credentials:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// ...
    /// // When running on Google Cloud Platform this will use the project Compute Credential.
    /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
    /// // credential file to use that credential.
    /// AdGroupServiceClient client = AdGroupServiceClient.Create();
    /// </code>
    /// This sample shows how to create a client using credentials loaded from a JSON file:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// using Google.Apis.Auth.OAuth2;
    /// using Grpc.Auth;
    /// using Grpc.Core;
    /// ...
    /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
    /// Channel channel = new Channel(
    ///     AdGroupServiceClient.DefaultEndpoint.Host, AdGroupServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
    /// AdGroupServiceClient client = AdGroupServiceClient.Create(channel);
    /// ...
    /// // Shutdown the channel when it is no longer required.
    /// channel.ShutdownAsync().Wait();
    /// </code>
    /// </example>
    /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
    /// <returns>The created <see cref="AdGroupServiceClient"/>.</returns>
    public static AdGroupServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AdGroupServiceSettings settings = null) {
      grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="AdGroupServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
    /// <returns>The created <see cref="AdGroupServiceClient"/>.</returns>
    public static AdGroupServiceClient Create(grpccore::Channel channel, AdGroupServiceSettings settings = null) {
      gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
      AdGroupService.AdGroupServiceClient grpcClient = new AdGroupService.AdGroupServiceClient(channel);
      return new AdGroupServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AdGroupServiceSettings)"/>
    /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AdGroupServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AdGroupServiceSettings)"/>
    /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AdGroupServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC AdGroupService client.
    /// </summary>
    public virtual AdGroupService.AdGroupServiceClient GrpcClient {
      get {
        throw new sys::NotImplementedException();
      }
    }

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the ad group to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(
        string resourceName,
        gaxgrpc::CallSettings callSettings = null) => GetAdGroupAsync(
            new gagvs::GetAdGroupRequest {
              ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the ad group to fetch.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="st::CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(
        string resourceName,
        st::CancellationToken cancellationToken) => GetAdGroupAsync(
            resourceName,
            gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the ad group to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual gagvr::AdGroup GetAdGroup(
        string resourceName,
        gaxgrpc::CallSettings callSettings = null) => GetAdGroup(
            new gagvs::GetAdGroupRequest {
              ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(
        gagvs::GetAdGroupRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      throw new sys::NotImplementedException();
    }

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="st::CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(
        gagvs::GetAdGroupRequest request,
        st::CancellationToken cancellationToken) => GetAdGroupAsync(
            request,
            gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual gagvr::AdGroup GetAdGroup(
        gagvs::GetAdGroupRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      throw new sys::NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose ad groups are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual ad groups.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvs::MutateAdGroupsResponse> MutateAdGroupsAsync(
        string customerId,
        scg::IEnumerable<gagvs::AdGroupOperation> operations,
        gaxgrpc::CallSettings callSettings = null) => MutateAdGroupsAsync(
            new gagvs::MutateAdGroupsRequest {
              CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose ad groups are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual ad groups.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="st::CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvs::MutateAdGroupsResponse> MutateAdGroupsAsync(
        string customerId,
        scg::IEnumerable<gagvs::AdGroupOperation> operations,
        st::CancellationToken cancellationToken) => MutateAdGroupsAsync(
            customerId,
            operations,
            gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose ad groups are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual ad groups.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual gagvs::MutateAdGroupsResponse MutateAdGroups(
        string customerId,
        scg::IEnumerable<gagvs::AdGroupOperation> operations,
        gaxgrpc::CallSettings callSettings = null) => MutateAdGroups(
            new gagvs::MutateAdGroupsRequest {
              CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvs::MutateAdGroupsResponse> MutateAdGroupsAsync(
        gagvs::MutateAdGroupsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      throw new sys::NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="st::CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual stt::Task<gagvs::MutateAdGroupsResponse> MutateAdGroupsAsync(
        gagvs::MutateAdGroupsRequest request,
        st::CancellationToken cancellationToken) => MutateAdGroupsAsync(
            request,
            gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual gagvs::MutateAdGroupsResponse MutateAdGroups(
        gagvs::MutateAdGroupsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      throw new sys::NotImplementedException();
    }
  }

  /// <summary>
  /// AdGroupService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class AdGroupServiceClientImpl : AdGroupServiceClient {
    private readonly gaxgrpc::ApiCall<gagvs::GetAdGroupRequest, gagvr::AdGroup> _callGetAdGroup;
    private readonly gaxgrpc::ApiCall<gagvs::MutateAdGroupsRequest, gagvs::MutateAdGroupsResponse> _callMutateAdGroups;

    /// <summary>
    /// Constructs a client wrapper for the AdGroupService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="AdGroupServiceSettings"/> used within this client </param>
    public AdGroupServiceClientImpl(AdGroupService.AdGroupServiceClient grpcClient, AdGroupServiceSettings settings) {
      GrpcClient = grpcClient;
      AdGroupServiceSettings effectiveSettings = settings ?? AdGroupServiceSettings.GetDefault();
      gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
      _callGetAdGroup = clientHelper.BuildApiCall<gagvs::GetAdGroupRequest, gagvr::AdGroup>(
          GrpcClient.GetAdGroupAsync, GrpcClient.GetAdGroup, effectiveSettings.GetAdGroupSettings);
      _callMutateAdGroups = clientHelper.BuildApiCall<gagvs::MutateAdGroupsRequest, gagvs::MutateAdGroupsResponse>(
          GrpcClient.MutateAdGroupsAsync, GrpcClient.MutateAdGroups, effectiveSettings.MutateAdGroupsSettings);
      Modify_ApiCall(ref _callGetAdGroup);
      Modify_GetAdGroupApiCall(ref _callGetAdGroup);
      Modify_ApiCall(ref _callMutateAdGroups);
      Modify_MutateAdGroupsApiCall(ref _callMutateAdGroups);
      OnConstruction(grpcClient, effectiveSettings, clientHelper);
    }

    // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

    // Partial methods called for every ApiCall on construction.
    // Allows modification of all the underlying ApiCall objects.
    partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
        where TRequest : class, pb::IMessage<TRequest>
        where TResponse : class, pb::IMessage<TResponse>;

    // Partial methods called for each ApiCall on construction.
    // Allows per-RPC-method modification of the underlying ApiCall object.
    partial void Modify_GetAdGroupApiCall(ref gaxgrpc::ApiCall<gagvs::GetAdGroupRequest, gagvr::AdGroup> call);

    partial void Modify_MutateAdGroupsApiCall(ref gaxgrpc::ApiCall<gagvs::MutateAdGroupsRequest, gagvs::MutateAdGroupsResponse> call);

    partial void OnConstruction(AdGroupService.AdGroupServiceClient grpcClient, AdGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC AdGroupService client.
    /// </summary>
    public override AdGroupService.AdGroupServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetAdGroupRequest(ref gagvs::GetAdGroupRequest request, ref gaxgrpc::CallSettings settings);

    partial void Modify_MutateAdGroupsRequest(ref gagvs::MutateAdGroupsRequest request, ref gaxgrpc::CallSettings settings);

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public override stt::Task<gagvr::AdGroup> GetAdGroupAsync(
        gagvs::GetAdGroupRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      Modify_GetAdGroupRequest(ref request, ref callSettings);
      return _callGetAdGroup.Async(request, callSettings);
    }

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public override gagvr::AdGroup GetAdGroup(
        gagvs::GetAdGroupRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      Modify_GetAdGroupRequest(ref request, ref callSettings);
      return _callGetAdGroup.Sync(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public override stt::Task<gagvs::MutateAdGroupsResponse> MutateAdGroupsAsync(
        gagvs::MutateAdGroupsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      Modify_MutateAdGroupsRequest(ref request, ref callSettings);
      return _callMutateAdGroups.Async(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public override gagvs::MutateAdGroupsResponse MutateAdGroups(
        gagvs::MutateAdGroupsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      Modify_MutateAdGroupsRequest(ref request, ref callSettings);
      return _callMutateAdGroups.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}