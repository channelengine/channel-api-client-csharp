/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.10.0
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
    public interface IReturnApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Return.
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <returns>ApiResponse</returns>
        ApiResponse ReturnDeclareForChannel(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest));

        /// <summary>
        /// Create Return.
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> ReturnDeclareForChannelWithHttpInfo(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest));
        /// <summary>
        /// Get Returns.
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfChannelReturnResponse</returns>
        CollectionOfChannelReturnResponse ReturnGetDeclaredByMerchant(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?));

        /// <summary>
        /// Get Returns.
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelReturnResponse</returns>
        ApiResponse<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantWithHttpInfo(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReturnApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create Return.
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> ReturnDeclareForChannelAsync(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create Return.
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnDeclareForChannelWithHttpInfoAsync(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Returns.
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelReturnResponse</returns>
        System.Threading.Tasks.Task<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantAsync(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Returns.
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelReturnResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfChannelReturnResponse>> ReturnGetDeclaredByMerchantWithHttpInfoAsync(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReturnApi : IReturnApiSync, IReturnApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReturnApi : IReturnApi
    {
        private ChannelEngine.Channel.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReturnApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReturnApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ReturnApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReturnApi(ChannelEngine.Channel.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ReturnApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ReturnApi(ChannelEngine.Channel.ApiClient.Client.ISynchronousClient client, ChannelEngine.Channel.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Channel.ApiClient.Client.IReadableConfiguration configuration)
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
        /// Create Return. Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <returns>ApiResponse</returns>
        public ApiResponse ReturnDeclareForChannel(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<ApiResponse> localVarResponse = ReturnDeclareForChannelWithHttpInfo(channelReturnRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Return. Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ChannelEngine.Channel.ApiClient.Client.ApiResponse<ApiResponse> ReturnDeclareForChannelWithHttpInfo(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest))
        {
            ChannelEngine.Channel.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Channel.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = channelReturnRequest;

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<ApiResponse>("/v2/returns/channel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReturnDeclareForChannel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create Return. Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> ReturnDeclareForChannelAsync(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<ApiResponse> localVarResponse = await ReturnDeclareForChannelWithHttpInfoAsync(channelReturnRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create Return. Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelReturnRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Channel.ApiClient.Client.ApiResponse<ApiResponse>> ReturnDeclareForChannelWithHttpInfoAsync(ChannelReturnRequest channelReturnRequest = default(ChannelReturnRequest), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ChannelEngine.Channel.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Channel.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = channelReturnRequest;

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiResponse>("/v2/returns/channel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReturnDeclareForChannel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Returns. Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfChannelReturnResponse</returns>
        public CollectionOfChannelReturnResponse ReturnGetDeclaredByMerchant(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelReturnResponse> localVarResponse = ReturnGetDeclaredByMerchantWithHttpInfo(statuses, reasons, fromDate, toDate, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Returns. Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelReturnResponse</returns>
        public ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantWithHttpInfo(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?))
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

            if (statuses != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "statuses", statuses));
            }
            if (reasons != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "reasons", reasons));
            }
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionOfChannelReturnResponse>("/v2/returns/channel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReturnGetDeclaredByMerchant", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Returns. Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelReturnResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantAsync(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelReturnResponse> localVarResponse = await ReturnGetDeclaredByMerchantWithHttpInfoAsync(statuses, reasons, fromDate, toDate, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Returns. Get all returns created by the merchant. This call is supposed&lt;br /&gt;to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;&lt;br /&gt;call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="statuses">Return status(es) to filter on. (optional)</param>
        /// <param name="reasons">Return reason(s) to filter on. (optional)</param>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelReturnResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelReturnResponse>> ReturnGetDeclaredByMerchantWithHttpInfoAsync(List<ReturnStatus> statuses = default(List<ReturnStatus>), List<ReturnReason> reasons = default(List<ReturnReason>), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (statuses != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "statuses", statuses));
            }
            if (reasons != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "reasons", reasons));
            }
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfChannelReturnResponse>("/v2/returns/channel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReturnGetDeclaredByMerchant", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
