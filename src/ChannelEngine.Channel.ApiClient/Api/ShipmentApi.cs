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
    public interface IShipmentApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Shipments.
        /// </summary>
        /// <remarks>
        /// Gets all shipments created since the supplied date with status CLOSED.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfChannelShipmentResponse</returns>
        CollectionOfChannelShipmentResponse ShipmentIndex(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?));

        /// <summary>
        /// Get Shipments.
        /// </summary>
        /// <remarks>
        /// Gets all shipments created since the supplied date with status CLOSED.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelShipmentResponse</returns>
        ApiResponse<CollectionOfChannelShipmentResponse> ShipmentIndexWithHttpInfo(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?));
        /// <summary>
        /// Download shipping label.
        /// </summary>
        /// <remarks>
        /// Downloads the shipping label for the shipment
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ShipmentShippingLabel(string merchantShipmentNo);

        /// <summary>
        /// Download shipping label.
        /// </summary>
        /// <remarks>
        /// Downloads the shipping label for the shipment
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ShipmentShippingLabelWithHttpInfo(string merchantShipmentNo);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Shipments.
        /// </summary>
        /// <remarks>
        /// Gets all shipments created since the supplied date with status CLOSED.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelShipmentResponse</returns>
        System.Threading.Tasks.Task<CollectionOfChannelShipmentResponse> ShipmentIndexAsync(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Shipments.
        /// </summary>
        /// <remarks>
        /// Gets all shipments created since the supplied date with status CLOSED.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelShipmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfChannelShipmentResponse>> ShipmentIndexWithHttpInfoAsync(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Download shipping label.
        /// </summary>
        /// <remarks>
        /// Downloads the shipping label for the shipment
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ShipmentShippingLabelAsync(string merchantShipmentNo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Download shipping label.
        /// </summary>
        /// <remarks>
        /// Downloads the shipping label for the shipment
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ShipmentShippingLabelWithHttpInfoAsync(string merchantShipmentNo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentApi : IShipmentApiSync, IShipmentApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShipmentApi : IShipmentApi
    {
        private ChannelEngine.Channel.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShipmentApi(ChannelEngine.Channel.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ShipmentApi(ChannelEngine.Channel.ApiClient.Client.ISynchronousClient client, ChannelEngine.Channel.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Channel.ApiClient.Client.IReadableConfiguration configuration)
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
        /// Get Shipments. Gets all shipments created since the supplied date with status CLOSED.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfChannelShipmentResponse</returns>
        public CollectionOfChannelShipmentResponse ShipmentIndex(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelShipmentResponse> localVarResponse = ShipmentIndexWithHttpInfo(fromDate, toDate, channelOrderNos, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Shipments. Gets all shipments created since the supplied date with status CLOSED.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelShipmentResponse</returns>
        public ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelShipmentResponse> ShipmentIndexWithHttpInfo(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?))
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

            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (channelOrderNos != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "channelOrderNos", channelOrderNos));
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
            var localVarResponse = this.Client.Get<CollectionOfChannelShipmentResponse>("/v2/shipments", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Shipments. Gets all shipments created since the supplied date with status CLOSED.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelShipmentResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfChannelShipmentResponse> ShipmentIndexAsync(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelShipmentResponse> localVarResponse = await ShipmentIndexWithHttpInfoAsync(fromDate, toDate, channelOrderNos, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Shipments. Gets all shipments created since the supplied date with status CLOSED.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the creation date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the creation date, until this date. This date is exclusive. (optional)</param>
        /// <param name="channelOrderNos">Filter on the unique references (ids) as used by the channel. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelShipmentResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Channel.ApiClient.Client.ApiResponse<CollectionOfChannelShipmentResponse>> ShipmentIndexWithHttpInfoAsync(DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), List<string> channelOrderNos = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (channelOrderNos != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "channelOrderNos", channelOrderNos));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfChannelShipmentResponse>("/v2/shipments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Download shipping label. Downloads the shipping label for the shipment
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ShipmentShippingLabel(string merchantShipmentNo)
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<System.IO.Stream> localVarResponse = ShipmentShippingLabelWithHttpInfo(merchantShipmentNo);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Download shipping label. Downloads the shipping label for the shipment
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ChannelEngine.Channel.ApiClient.Client.ApiResponse<System.IO.Stream> ShipmentShippingLabelWithHttpInfo(string merchantShipmentNo)
        {
            // verify the required parameter 'merchantShipmentNo' is set
            if (merchantShipmentNo == null)
                throw new ChannelEngine.Channel.ApiClient.Client.ApiException(400, "Missing required parameter 'merchantShipmentNo' when calling ShipmentApi->ShipmentShippingLabel");

            ChannelEngine.Channel.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Channel.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.shippingLabel",
                "application/json"
            };

            var localVarContentType = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("merchantShipmentNo", ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToString(merchantShipmentNo)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<System.IO.Stream>("/v2/orders/{merchantShipmentNo}/shippinglabel", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentShippingLabel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Download shipping label. Downloads the shipping label for the shipment
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ShipmentShippingLabelAsync(string merchantShipmentNo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Channel.ApiClient.Client.ApiResponse<System.IO.Stream> localVarResponse = await ShipmentShippingLabelWithHttpInfoAsync(merchantShipmentNo, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Download shipping label. Downloads the shipping label for the shipment
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The unique shipment reference as used by the merchant.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Channel.ApiClient.Client.ApiResponse<System.IO.Stream>> ShipmentShippingLabelWithHttpInfoAsync(string merchantShipmentNo, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'merchantShipmentNo' is set
            if (merchantShipmentNo == null)
                throw new ChannelEngine.Channel.ApiClient.Client.ApiException(400, "Missing required parameter 'merchantShipmentNo' when calling ShipmentApi->ShipmentShippingLabel");


            ChannelEngine.Channel.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Channel.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/vnd.shippingLabel",
                "application/json"
            };


            var localVarContentType = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Channel.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("merchantShipmentNo", ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToString(merchantShipmentNo)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Channel.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<System.IO.Stream>("/v2/orders/{merchantShipmentNo}/shippinglabel", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ShipmentShippingLabel", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
