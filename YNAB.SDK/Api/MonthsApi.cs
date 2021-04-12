/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using YNAB.SDK.Client;
using YNAB.SDK.Model;

namespace YNAB.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMonthsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Single budget month
        /// </summary>
        /// <remarks>
        /// Returns a single budget month
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>MonthDetailResponse</returns>
        MonthDetailResponse GetBudgetMonth(string budgetId, DateTime month);

        /// <summary>
        /// Single budget month
        /// </summary>
        /// <remarks>
        /// Returns a single budget month
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>ApiResponse of MonthDetailResponse</returns>
        ApiResponse<MonthDetailResponse> GetBudgetMonthWithHttpInfo(string budgetId, DateTime month);
        /// <summary>
        /// List budget months
        /// </summary>
        /// <remarks>
        /// Returns all budget months
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>MonthSummariesResponse</returns>
        MonthSummariesResponse GetBudgetMonths(string budgetId, long? lastKnowledgeOfServer = default(long?));

        /// <summary>
        /// List budget months
        /// </summary>
        /// <remarks>
        /// Returns all budget months
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>ApiResponse of MonthSummariesResponse</returns>
        ApiResponse<MonthSummariesResponse> GetBudgetMonthsWithHttpInfo(string budgetId, long? lastKnowledgeOfServer = default(long?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMonthsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Single budget month
        /// </summary>
        /// <remarks>
        /// Returns a single budget month
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MonthDetailResponse</returns>
        System.Threading.Tasks.Task<MonthDetailResponse> GetBudgetMonthAsync(string budgetId, DateTime month, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Single budget month
        /// </summary>
        /// <remarks>
        /// Returns a single budget month
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MonthDetailResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MonthDetailResponse>> GetBudgetMonthWithHttpInfoAsync(string budgetId, DateTime month, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List budget months
        /// </summary>
        /// <remarks>
        /// Returns all budget months
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MonthSummariesResponse</returns>
        System.Threading.Tasks.Task<MonthSummariesResponse> GetBudgetMonthsAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List budget months
        /// </summary>
        /// <remarks>
        /// Returns all budget months
        /// </remarks>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MonthSummariesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MonthSummariesResponse>> GetBudgetMonthsWithHttpInfoAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMonthsApi : IMonthsApiSync, IMonthsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MonthsApi : IMonthsApi
    {
        private YNAB.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonthsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MonthsApi(String basePath)
        {
            this.Configuration = YNAB.SDK.Client.Configuration.MergeConfigurations(
                YNAB.SDK.Client.GlobalConfiguration.Instance,
                new YNAB.SDK.Client.Configuration { BasePath = basePath }
            );
            this.Client = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MonthsApi(YNAB.SDK.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = YNAB.SDK.Client.Configuration.MergeConfigurations(
                YNAB.SDK.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new YNAB.SDK.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MonthsApi(YNAB.SDK.Client.ISynchronousClient client, YNAB.SDK.Client.IAsynchronousClient asyncClient, YNAB.SDK.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = YNAB.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public YNAB.SDK.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public YNAB.SDK.Client.ISynchronousClient Client { get; set; }

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
        public YNAB.SDK.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public YNAB.SDK.Client.ExceptionFactory ExceptionFactory
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
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>MonthDetailResponse</returns>
        public MonthDetailResponse GetBudgetMonth(string budgetId, DateTime month)
        {
            YNAB.SDK.Client.ApiResponse<MonthDetailResponse> localVarResponse = GetBudgetMonthWithHttpInfo(budgetId, month);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <returns>ApiResponse of MonthDetailResponse</returns>
        public YNAB.SDK.Client.ApiResponse<MonthDetailResponse> GetBudgetMonthWithHttpInfo(string budgetId, DateTime month)
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling MonthsApi->GetBudgetMonth");

            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            localVarRequestOptions.PathParameters.Add("month", YNAB.SDK.Client.ClientUtils.ParameterToString(month)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MonthDetailResponse>("/budgets/{budget_id}/months/{month}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBudgetMonth", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MonthDetailResponse</returns>
        public async System.Threading.Tasks.Task<MonthDetailResponse> GetBudgetMonthAsync(string budgetId, DateTime month, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            YNAB.SDK.Client.ApiResponse<MonthDetailResponse> localVarResponse = await GetBudgetMonthWithHttpInfoAsync(budgetId, month, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Single budget month Returns a single budget month
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="month">The budget month in ISO format (e.g. 2016-12-01) (\&quot;current\&quot; can also be used to specify the current calendar month (UTC))</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MonthDetailResponse)</returns>
        public async System.Threading.Tasks.Task<YNAB.SDK.Client.ApiResponse<MonthDetailResponse>> GetBudgetMonthWithHttpInfoAsync(string budgetId, DateTime month, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling MonthsApi->GetBudgetMonth");


            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            localVarRequestOptions.PathParameters.Add("month", YNAB.SDK.Client.ClientUtils.ParameterToString(month)); // path parameter

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<MonthDetailResponse>("/budgets/{budget_id}/months/{month}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBudgetMonth", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>MonthSummariesResponse</returns>
        public MonthSummariesResponse GetBudgetMonths(string budgetId, long? lastKnowledgeOfServer = default(long?))
        {
            YNAB.SDK.Client.ApiResponse<MonthSummariesResponse> localVarResponse = GetBudgetMonthsWithHttpInfo(budgetId, lastKnowledgeOfServer);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <returns>ApiResponse of MonthSummariesResponse</returns>
        public YNAB.SDK.Client.ApiResponse<MonthSummariesResponse> GetBudgetMonthsWithHttpInfo(string budgetId, long? lastKnowledgeOfServer = default(long?))
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling MonthsApi->GetBudgetMonths");

            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (lastKnowledgeOfServer != null)
            {
                localVarRequestOptions.QueryParameters.Add(YNAB.SDK.Client.ClientUtils.ParameterToMultiMap("", "last_knowledge_of_server", lastKnowledgeOfServer));
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<MonthSummariesResponse>("/budgets/{budget_id}/months", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBudgetMonths", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of MonthSummariesResponse</returns>
        public async System.Threading.Tasks.Task<MonthSummariesResponse> GetBudgetMonthsAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            YNAB.SDK.Client.ApiResponse<MonthSummariesResponse> localVarResponse = await GetBudgetMonthsWithHttpInfoAsync(budgetId, lastKnowledgeOfServer, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List budget months Returns all budget months
        /// </summary>
        /// <exception cref="YNAB.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="budgetId">The id of the budget. \&quot;last-used\&quot; can be used to specify the last used budget and \&quot;default\&quot; can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).</param>
        /// <param name="lastKnowledgeOfServer">The starting server knowledge.  If provided, only entities that have changed since &#x60;last_knowledge_of_server&#x60; will be included. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (MonthSummariesResponse)</returns>
        public async System.Threading.Tasks.Task<YNAB.SDK.Client.ApiResponse<MonthSummariesResponse>> GetBudgetMonthsWithHttpInfoAsync(string budgetId, long? lastKnowledgeOfServer = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'budgetId' is set
            if (budgetId == null)
                throw new YNAB.SDK.Client.ApiException(400, "Missing required parameter 'budgetId' when calling MonthsApi->GetBudgetMonths");


            YNAB.SDK.Client.RequestOptions localVarRequestOptions = new YNAB.SDK.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = YNAB.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = YNAB.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("budget_id", YNAB.SDK.Client.ClientUtils.ParameterToString(budgetId)); // path parameter
            if (lastKnowledgeOfServer != null)
            {
                localVarRequestOptions.QueryParameters.Add(YNAB.SDK.Client.ClientUtils.ParameterToMultiMap("", "last_knowledge_of_server", lastKnowledgeOfServer));
            }

            // authentication (bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<MonthSummariesResponse>("/budgets/{budget_id}/months", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBudgetMonths", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
