/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * OpenAPI spec version: 2.5.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ChannelEngine.Channel.ApiClient.Client;
using ChannelEngine.Channel.ApiClient.Model;

namespace ChannelEngine.Channel.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrderApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Order
        /// </summary>
        /// <remarks>
        /// Create a new order in ChannelEngine.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse OrderCreate (ChannelOrderRequest model);

        /// <summary>
        /// Create Order
        /// </summary>
        /// <remarks>
        /// Create a new order in ChannelEngine.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> OrderCreateWithHttpInfo (ChannelOrderRequest model);
        /// <summary>
        /// Download Invoice
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine VAT invoice for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream OrderInvoice (string merchantOrderNo, bool? useCustomerCulture = null);

        /// <summary>
        /// Download Invoice
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine VAT invoice for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> OrderInvoiceWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null);
        /// <summary>
        /// Download Packing Slip
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine packing slip for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream OrderPackingSlip (string merchantOrderNo, bool? useCustomerCulture = null);

        /// <summary>
        /// Download Packing Slip
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine packing slip for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> OrderPackingSlipWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Order
        /// </summary>
        /// <remarks>
        /// Create a new order in ChannelEngine.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> OrderCreateAsync (ChannelOrderRequest model);

        /// <summary>
        /// Create Order
        /// </summary>
        /// <remarks>
        /// Create a new order in ChannelEngine.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> OrderCreateAsyncWithHttpInfo (ChannelOrderRequest model);
        /// <summary>
        /// Download Invoice
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine VAT invoice for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> OrderInvoiceAsync (string merchantOrderNo, bool? useCustomerCulture = null);

        /// <summary>
        /// Download Invoice
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine VAT invoice for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> OrderInvoiceAsyncWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null);
        /// <summary>
        /// Download Packing Slip
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine packing slip for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> OrderPackingSlipAsync (string merchantOrderNo, bool? useCustomerCulture = null);

        /// <summary>
        /// Download Packing Slip
        /// </summary>
        /// <remarks>
        /// Generates the ChannelEngine packing slip for this order in PDF
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> OrderPackingSlipAsyncWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrderApi : IOrderApi
    {
        private ChannelEngine.Channel.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrderApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Channel.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Channel.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrderApi(ChannelEngine.Channel.ApiClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ChannelEngine.Channel.ApiClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ChannelEngine.Channel.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ChannelEngine.Channel.ApiClient.Client.Configuration Configuration {get; set;}

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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create Order Create a new order in ChannelEngine.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse OrderCreate (ChannelOrderRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = OrderCreateWithHttpInfo(model);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Order Create a new order in ChannelEngine.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > OrderCreateWithHttpInfo (ChannelOrderRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling OrderApi->OrderCreate");

            var localVarPath = "/v2/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrderCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Create Order Create a new order in ChannelEngine.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> OrderCreateAsync (ChannelOrderRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = await OrderCreateAsyncWithHttpInfo(model);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Order Create a new order in ChannelEngine.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> OrderCreateAsyncWithHttpInfo (ChannelOrderRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling OrderApi->OrderCreate");

            var localVarPath = "/v2/orders";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrderCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Download Invoice Generates the ChannelEngine VAT invoice for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream OrderInvoice (string merchantOrderNo, bool? useCustomerCulture = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = OrderInvoiceWithHttpInfo(merchantOrderNo, useCustomerCulture);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download Invoice Generates the ChannelEngine VAT invoice for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > OrderInvoiceWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null)
        {
            // verify the required parameter 'merchantOrderNo' is set
            if (merchantOrderNo == null)
                throw new ApiException(400, "Missing required parameter 'merchantOrderNo' when calling OrderApi->OrderInvoice");

            var localVarPath = "/v2/orders/{merchantOrderNo}/invoice";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/pdf"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (merchantOrderNo != null) localVarPathParams.Add("merchantOrderNo", this.Configuration.ApiClient.ParameterToString(merchantOrderNo)); // path parameter
            if (useCustomerCulture != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useCustomerCulture", useCustomerCulture)); // query parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrderInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download Invoice Generates the ChannelEngine VAT invoice for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> OrderInvoiceAsync (string merchantOrderNo, bool? useCustomerCulture = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await OrderInvoiceAsyncWithHttpInfo(merchantOrderNo, useCustomerCulture);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download Invoice Generates the ChannelEngine VAT invoice for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> OrderInvoiceAsyncWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null)
        {
            // verify the required parameter 'merchantOrderNo' is set
            if (merchantOrderNo == null)
                throw new ApiException(400, "Missing required parameter 'merchantOrderNo' when calling OrderApi->OrderInvoice");

            var localVarPath = "/v2/orders/{merchantOrderNo}/invoice";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/pdf"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (merchantOrderNo != null) localVarPathParams.Add("merchantOrderNo", this.Configuration.ApiClient.ParameterToString(merchantOrderNo)); // path parameter
            if (useCustomerCulture != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useCustomerCulture", useCustomerCulture)); // query parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrderInvoice", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download Packing Slip Generates the ChannelEngine packing slip for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream OrderPackingSlip (string merchantOrderNo, bool? useCustomerCulture = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = OrderPackingSlipWithHttpInfo(merchantOrderNo, useCustomerCulture);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download Packing Slip Generates the ChannelEngine packing slip for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > OrderPackingSlipWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null)
        {
            // verify the required parameter 'merchantOrderNo' is set
            if (merchantOrderNo == null)
                throw new ApiException(400, "Missing required parameter 'merchantOrderNo' when calling OrderApi->OrderPackingSlip");

            var localVarPath = "/v2/orders/{merchantOrderNo}/packingslip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/pdf"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (merchantOrderNo != null) localVarPathParams.Add("merchantOrderNo", this.Configuration.ApiClient.ParameterToString(merchantOrderNo)); // path parameter
            if (useCustomerCulture != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useCustomerCulture", useCustomerCulture)); // query parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrderPackingSlip", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download Packing Slip Generates the ChannelEngine packing slip for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> OrderPackingSlipAsync (string merchantOrderNo, bool? useCustomerCulture = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await OrderPackingSlipAsyncWithHttpInfo(merchantOrderNo, useCustomerCulture);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download Packing Slip Generates the ChannelEngine packing slip for this order in PDF
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantOrderNo">The unique order reference as used by the merchant</param>
        /// <param name="useCustomerCulture">Generate the invoice in the billing address&#39; country&#39;s language (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> OrderPackingSlipAsyncWithHttpInfo (string merchantOrderNo, bool? useCustomerCulture = null)
        {
            // verify the required parameter 'merchantOrderNo' is set
            if (merchantOrderNo == null)
                throw new ApiException(400, "Missing required parameter 'merchantOrderNo' when calling OrderApi->OrderPackingSlip");

            var localVarPath = "/v2/orders/{merchantOrderNo}/packingslip";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/pdf"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (merchantOrderNo != null) localVarPathParams.Add("merchantOrderNo", this.Configuration.ApiClient.ParameterToString(merchantOrderNo)); // path parameter
            if (useCustomerCulture != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "useCustomerCulture", useCustomerCulture)); // query parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrderPackingSlip", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

    }
}
