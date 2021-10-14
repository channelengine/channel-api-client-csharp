/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.9
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ChannelEngine.Channel.ApiClient.Client;
using ChannelEngine.Channel.ApiClient.Model;

namespace ChannelEngine.Channel.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICancellationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Cancellations.
        /// </summary>
        /// <remarks>
        /// Gets all cancellations created since the supplied date.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <returns>CollectionOfChannelCancellationResponse</returns>
        CollectionOfChannelCancellationResponse CancellationIndex(DateTime? createdSince = default(DateTime?));

        /// <summary>
        /// Get Cancellations.
        /// </summary>
        /// <remarks>
        /// Gets all cancellations created since the supplied date.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelCancellationResponse</returns>
        ApiResponse<CollectionOfChannelCancellationResponse> CancellationIndexWithHttpInfo(DateTime? createdSince = default(DateTime?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICancellationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Cancellations.
        /// </summary>
        /// <remarks>
        /// Gets all cancellations created since the supplied date.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelCancellationResponse</returns>
        System.Threading.Tasks.Task<CollectionOfChannelCancellationResponse> CancellationIndexAsync(DateTime? createdSince = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Cancellations.
        /// </summary>
        /// <remarks>
        /// Gets all cancellations created since the supplied date.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelCancellationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfChannelCancellationResponse>> CancellationIndexWithHttpInfoAsync(DateTime? createdSince = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICancellationApi : ICancellationApiSync, ICancellationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CancellationApi : ICancellationApi
    {
        private ChannelEngine.Channel.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CancellationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CancellationApi(String basePath)
        {
            this.Configuration = ChannelEngine.Channel.ApiClient.Client.Configuration.MergeConfigurations(
                ChannelEngine.Channel.ApiClient.Client.GlobalConfiguration.Instance,
                new ChannelEngine.Channel.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ChannelEngine.Channel.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChannelEngine.Channel.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ChannelEngine.Channel.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CancellationApi(ChannelEngine.Channel.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ChannelEngine.Channel.ApiClient.Client.Configuration.MergeConfigurations(
                ChannelEngine.Channel.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ChannelEngine.Channel.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChannelEngine.Channel.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ChannelEngine.Channel.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CancellationApi(ChannelEngine.Channel.ApiClient.Client.ISynchronousClient client, ChannelEngine.Channel.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Channel.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ChannelEngine.Channel.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ChannelEngine.Channel.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ChannelEngine.Channel.ApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ChannelEngine.Channel.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ChannelEngine.Channel.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Cancellations. Gets all cancellations created since the supplied date.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <returns>CollectionOfChannelCancellationResponse</returns>
        public CollectionOfChannelCancellationResponse CancellationIndex(DateTime? createdSince = default(DateTime?))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelCancellationResponse> localVarResponse = CancellationIndexWithHttpInfo(createdSince);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Cancellations. Gets all cancellations created since the supplied date.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelCancellationResponse</returns>
        public ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelCancellationResponse> CancellationIndexWithHttpInfo(DateTime? createdSince = default(DateTime?))
        {
            ChannelEngine.Channel.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Channel.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createdSince != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "createdSince", createdSince));
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionOfChannelCancellationResponse>("/v2/cancellations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancellationIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Cancellations. Gets all cancellations created since the supplied date.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelCancellationResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfChannelCancellationResponse> CancellationIndexAsync(DateTime? createdSince = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelCancellationResponse> localVarResponse = await CancellationIndexWithHttpInfoAsync(createdSince, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Cancellations. Gets all cancellations created since the supplied date.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince">The date from which you will get all created cancellations (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelCancellationResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelCancellationResponse>> CancellationIndexWithHttpInfoAsync(DateTime? createdSince = default(DateTime?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ChannelEngine.Channel.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Channel.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createdSince != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "createdSince", createdSince));
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfChannelCancellationResponse>("/v2/cancellations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CancellationIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
