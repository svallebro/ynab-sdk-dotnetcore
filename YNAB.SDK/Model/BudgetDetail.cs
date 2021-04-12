/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// BudgetDetail
    /// </summary>
    [DataContract(Name = "BudgetDetail")]
    public partial class BudgetDetail : IEquatable<BudgetDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDetail" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="lastModifiedOn">The last time any changes were made to the budget from either a web or mobile client.</param>
        /// <param name="firstMonth">The earliest budget month.</param>
        /// <param name="lastMonth">The latest budget month.</param>
        /// <param name="dateFormat">dateFormat.</param>
        /// <param name="currencyFormat">currencyFormat.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="payees">payees.</param>
        /// <param name="payeeLocations">payeeLocations.</param>
        /// <param name="categoryGroups">categoryGroups.</param>
        /// <param name="categories">categories.</param>
        /// <param name="months">months.</param>
        /// <param name="transactions">transactions.</param>
        /// <param name="subtransactions">subtransactions.</param>
        /// <param name="scheduledTransactions">scheduledTransactions.</param>
        /// <param name="scheduledSubtransactions">scheduledSubtransactions.</param>
        public BudgetDetail(Guid id = default(Guid), string name = default(string), DateTime lastModifiedOn = default(DateTime), DateTime firstMonth = default(DateTime), DateTime lastMonth = default(DateTime), DateFormat dateFormat = default(DateFormat), CurrencyFormat currencyFormat = default(CurrencyFormat), List<Account> accounts = default(List<Account>), List<Payee> payees = default(List<Payee>), List<PayeeLocation> payeeLocations = default(List<PayeeLocation>), List<CategoryGroup> categoryGroups = default(List<CategoryGroup>), List<Category> categories = default(List<Category>), List<MonthDetail> months = default(List<MonthDetail>), List<TransactionSummary> transactions = default(List<TransactionSummary>), List<SubTransaction> subtransactions = default(List<SubTransaction>), List<ScheduledTransactionSummary> scheduledTransactions = default(List<ScheduledTransactionSummary>), List<ScheduledSubTransaction> scheduledSubtransactions = default(List<ScheduledSubTransaction>))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for BudgetDetail and cannot be null");
            this.LastModifiedOn = lastModifiedOn;
            this.FirstMonth = firstMonth;
            this.LastMonth = lastMonth;
            this.DateFormat = dateFormat;
            this.CurrencyFormat = currencyFormat;
            this.Accounts = accounts;
            this.Payees = payees;
            this.PayeeLocations = payeeLocations;
            this.CategoryGroups = categoryGroups;
            this.Categories = categories;
            this.Months = months;
            this.Transactions = transactions;
            this.Subtransactions = subtransactions;
            this.ScheduledTransactions = scheduledTransactions;
            this.ScheduledSubtransactions = scheduledSubtransactions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The last time any changes were made to the budget from either a web or mobile client
        /// </summary>
        /// <value>The last time any changes were made to the budget from either a web or mobile client</value>
        [DataMember(Name = "last_modified_on", EmitDefaultValue = false)]
        public DateTime LastModifiedOn { get; set; }

        /// <summary>
        /// The earliest budget month
        /// </summary>
        /// <value>The earliest budget month</value>
        [DataMember(Name = "first_month", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime FirstMonth { get; set; }

        /// <summary>
        /// The latest budget month
        /// </summary>
        /// <value>The latest budget month</value>
        [DataMember(Name = "last_month", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime LastMonth { get; set; }

        /// <summary>
        /// Gets or Sets DateFormat
        /// </summary>
        [DataMember(Name = "date_format", EmitDefaultValue = false)]
        public DateFormat DateFormat { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyFormat
        /// </summary>
        [DataMember(Name = "currency_format", EmitDefaultValue = false)]
        public CurrencyFormat CurrencyFormat { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets Payees
        /// </summary>
        [DataMember(Name = "payees", EmitDefaultValue = false)]
        public List<Payee> Payees { get; set; }

        /// <summary>
        /// Gets or Sets PayeeLocations
        /// </summary>
        [DataMember(Name = "payee_locations", EmitDefaultValue = false)]
        public List<PayeeLocation> PayeeLocations { get; set; }

        /// <summary>
        /// Gets or Sets CategoryGroups
        /// </summary>
        [DataMember(Name = "category_groups", EmitDefaultValue = false)]
        public List<CategoryGroup> CategoryGroups { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Months
        /// </summary>
        [DataMember(Name = "months", EmitDefaultValue = false)]
        public List<MonthDetail> Months { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<TransactionSummary> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Subtransactions
        /// </summary>
        [DataMember(Name = "subtransactions", EmitDefaultValue = false)]
        public List<SubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledTransactions
        /// </summary>
        [DataMember(Name = "scheduled_transactions", EmitDefaultValue = false)]
        public List<ScheduledTransactionSummary> ScheduledTransactions { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledSubtransactions
        /// </summary>
        [DataMember(Name = "scheduled_subtransactions", EmitDefaultValue = false)]
        public List<ScheduledSubTransaction> ScheduledSubtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BudgetDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LastModifiedOn: ").Append(LastModifiedOn).Append("\n");
            sb.Append("  FirstMonth: ").Append(FirstMonth).Append("\n");
            sb.Append("  LastMonth: ").Append(LastMonth).Append("\n");
            sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
            sb.Append("  CurrencyFormat: ").Append(CurrencyFormat).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Payees: ").Append(Payees).Append("\n");
            sb.Append("  PayeeLocations: ").Append(PayeeLocations).Append("\n");
            sb.Append("  CategoryGroups: ").Append(CategoryGroups).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Months: ").Append(Months).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
            sb.Append("  ScheduledTransactions: ").Append(ScheduledTransactions).Append("\n");
            sb.Append("  ScheduledSubtransactions: ").Append(ScheduledSubtransactions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BudgetDetail);
        }

        /// <summary>
        /// Returns true if BudgetDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LastModifiedOn == input.LastModifiedOn ||
                    (this.LastModifiedOn != null &&
                    this.LastModifiedOn.Equals(input.LastModifiedOn))
                ) && 
                (
                    this.FirstMonth == input.FirstMonth ||
                    (this.FirstMonth != null &&
                    this.FirstMonth.Equals(input.FirstMonth))
                ) && 
                (
                    this.LastMonth == input.LastMonth ||
                    (this.LastMonth != null &&
                    this.LastMonth.Equals(input.LastMonth))
                ) && 
                (
                    this.DateFormat == input.DateFormat ||
                    (this.DateFormat != null &&
                    this.DateFormat.Equals(input.DateFormat))
                ) && 
                (
                    this.CurrencyFormat == input.CurrencyFormat ||
                    (this.CurrencyFormat != null &&
                    this.CurrencyFormat.Equals(input.CurrencyFormat))
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Payees == input.Payees ||
                    this.Payees != null &&
                    input.Payees != null &&
                    this.Payees.SequenceEqual(input.Payees)
                ) && 
                (
                    this.PayeeLocations == input.PayeeLocations ||
                    this.PayeeLocations != null &&
                    input.PayeeLocations != null &&
                    this.PayeeLocations.SequenceEqual(input.PayeeLocations)
                ) && 
                (
                    this.CategoryGroups == input.CategoryGroups ||
                    this.CategoryGroups != null &&
                    input.CategoryGroups != null &&
                    this.CategoryGroups.SequenceEqual(input.CategoryGroups)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Months == input.Months ||
                    this.Months != null &&
                    input.Months != null &&
                    this.Months.SequenceEqual(input.Months)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    input.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
                ) && 
                (
                    this.ScheduledTransactions == input.ScheduledTransactions ||
                    this.ScheduledTransactions != null &&
                    input.ScheduledTransactions != null &&
                    this.ScheduledTransactions.SequenceEqual(input.ScheduledTransactions)
                ) && 
                (
                    this.ScheduledSubtransactions == input.ScheduledSubtransactions ||
                    this.ScheduledSubtransactions != null &&
                    input.ScheduledSubtransactions != null &&
                    this.ScheduledSubtransactions.SequenceEqual(input.ScheduledSubtransactions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LastModifiedOn != null)
                    hashCode = hashCode * 59 + this.LastModifiedOn.GetHashCode();
                if (this.FirstMonth != null)
                    hashCode = hashCode * 59 + this.FirstMonth.GetHashCode();
                if (this.LastMonth != null)
                    hashCode = hashCode * 59 + this.LastMonth.GetHashCode();
                if (this.DateFormat != null)
                    hashCode = hashCode * 59 + this.DateFormat.GetHashCode();
                if (this.CurrencyFormat != null)
                    hashCode = hashCode * 59 + this.CurrencyFormat.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.Payees != null)
                    hashCode = hashCode * 59 + this.Payees.GetHashCode();
                if (this.PayeeLocations != null)
                    hashCode = hashCode * 59 + this.PayeeLocations.GetHashCode();
                if (this.CategoryGroups != null)
                    hashCode = hashCode * 59 + this.CategoryGroups.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Months != null)
                    hashCode = hashCode * 59 + this.Months.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
                if (this.ScheduledTransactions != null)
                    hashCode = hashCode * 59 + this.ScheduledTransactions.GetHashCode();
                if (this.ScheduledSubtransactions != null)
                    hashCode = hashCode * 59 + this.ScheduledSubtransactions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
