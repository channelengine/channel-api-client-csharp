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
    public interface IReturnApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse ReturnDeclareForChannel (ChannelReturnRequest model);

        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> ReturnDeclareForChannelWithHttpInfo (ChannelReturnRequest model);
        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>CollectionOfChannelReturnResponse</returns>
        CollectionOfChannelReturnResponse ReturnGetDeclaredByMerchant (DateTime? createdSince);

        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>ApiResponse of CollectionOfChannelReturnResponse</returns>
        ApiResponse<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantWithHttpInfo (DateTime? createdSince);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> ReturnDeclareForChannelAsync (ChannelReturnRequest model);

        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnDeclareForChannelAsyncWithHttpInfo (ChannelReturnRequest model);
        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of CollectionOfChannelReturnResponse</returns>
        System.Threading.Tasks.Task<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantAsync (DateTime? createdSince);

        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of ApiResponse (CollectionOfChannelReturnResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfChannelReturnResponse>> ReturnGetDeclaredByMerchantAsyncWithHttpInfo (DateTime? createdSince);
        #endregion Asynchronous Operations
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
        public ReturnApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Channel.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Channel.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReturnApi(ChannelEngine.Channel.ApiClient.Client.Configuration configuration = null)
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
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse ReturnDeclareForChannel (ChannelReturnRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = ReturnDeclareForChannelWithHttpInfo(model);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > ReturnDeclareForChannelWithHttpInfo (ChannelReturnRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ReturnApi->ReturnDeclareForChannel");

            var localVarPath = "/v2/returns/channel";
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
                Exception exception = ExceptionFactory("ReturnDeclareForChannel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> ReturnDeclareForChannelAsync (ChannelReturnRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = await ReturnDeclareForChannelAsyncWithHttpInfo(model);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnDeclareForChannelAsyncWithHttpInfo (ChannelReturnRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ReturnApi->ReturnDeclareForChannel");

            var localVarPath = "/v2/returns/channel";
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
                Exception exception = ExceptionFactory("ReturnDeclareForChannel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Get Returns Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>CollectionOfChannelReturnResponse</returns>
        public CollectionOfChannelReturnResponse ReturnGetDeclaredByMerchant (DateTime? createdSince)
        {
             ApiResponse<CollectionOfChannelReturnResponse> localVarResponse = ReturnGetDeclaredByMerchantWithHttpInfo(createdSince);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Returns Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>ApiResponse of CollectionOfChannelReturnResponse</returns>
        public ApiResponse< CollectionOfChannelReturnResponse > ReturnGetDeclaredByMerchantWithHttpInfo (DateTime? createdSince)
        {
            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling ReturnApi->ReturnGetDeclaredByMerchant");

            var localVarPath = "/v2/returns/channel";
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
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createdSince != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdSince", createdSince)); // query parameter

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
                Exception exception = ExceptionFactory("ReturnGetDeclaredByMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionOfChannelReturnResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CollectionOfChannelReturnResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionOfChannelReturnResponse)));
        }

        /// <summary>
        /// Get Returns Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of CollectionOfChannelReturnResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfChannelReturnResponse> ReturnGetDeclaredByMerchantAsync (DateTime? createdSince)
        {
             ApiResponse<CollectionOfChannelReturnResponse> localVarResponse = await ReturnGetDeclaredByMerchantAsyncWithHttpInfo(createdSince);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Returns Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the &#39;GET /v2/returns/merchant&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Channel.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of ApiResponse (CollectionOfChannelReturnResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CollectionOfChannelReturnResponse>> ReturnGetDeclaredByMerchantAsyncWithHttpInfo (DateTime? createdSince)
        {
            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling ReturnApi->ReturnGetDeclaredByMerchant");

            var localVarPath = "/v2/returns/channel";
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
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createdSince != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdSince", createdSince)); // query parameter

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
                Exception exception = ExceptionFactory("ReturnGetDeclaredByMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionOfChannelReturnResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CollectionOfChannelReturnResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionOfChannelReturnResponse)));
        }

    }
}
