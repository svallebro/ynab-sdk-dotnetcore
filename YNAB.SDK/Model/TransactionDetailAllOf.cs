/* 
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// TransactionDetailAllOf
    /// </summary>
    [DataContract]
    public partial class TransactionDetailAllOf :  IEquatable<TransactionDetailAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetailAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionDetailAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetailAllOf" /> class.
        /// </summary>
        /// <param name="accountName">accountName (required).</param>
        /// <param name="payeeName">payeeName (required).</param>
        /// <param name="categoryName">categoryName (required).</param>
        /// <param name="subtransactions">If a split transaction, the subtransactions. (required).</param>
        public TransactionDetailAllOf(string accountName = default(string), string payeeName = default(string), string categoryName = default(string), List<SubTransaction> subtransactions = default(List<SubTransaction>))
        {
            // to ensure "accountName" is required (not null)
            if (accountName == null)
            {
                throw new InvalidDataException("accountName is a required property for TransactionDetailAllOf and cannot be null");
            }
            else
            {
                this.AccountName = accountName;
            }

            // to ensure "payeeName" is required (not null)
            if (payeeName == null)
            {
                throw new InvalidDataException("payeeName is a required property for TransactionDetailAllOf and cannot be null");
            }
            else
            {
                this.PayeeName = payeeName;
            }

            // to ensure "categoryName" is required (not null)
            if (categoryName == null)
            {
                throw new InvalidDataException("categoryName is a required property for TransactionDetailAllOf and cannot be null");
            }
            else
            {
                this.CategoryName = categoryName;
            }

            // to ensure "subtransactions" is required (not null)
            if (subtransactions == null)
            {
                throw new InvalidDataException("subtransactions is a required property for TransactionDetailAllOf and cannot be null");
            }
            else
            {
                this.Subtransactions = subtransactions;
            }

        }
        
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="account_name", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets PayeeName
        /// </summary>
        [DataMember(Name="payee_name", EmitDefaultValue=false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="category_name", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// If a split transaction, the subtransactions.
        /// </summary>
        /// <value>If a split transaction, the subtransactions.</value>
        [DataMember(Name="subtransactions", EmitDefaultValue=false)]
        public List<SubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionDetailAllOf {\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionDetailAllOf);
        }

        /// <summary>
        /// Returns true if TransactionDetailAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDetailAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDetailAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    input.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
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