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
    /// TransactionsImportResponseData
    /// </summary>
    [DataContract(Name = "TransactionsImportResponse_data")]
    public partial class TransactionsImportResponseData : IEquatable<TransactionsImportResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsImportResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionsImportResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsImportResponseData" /> class.
        /// </summary>
        /// <param name="transactionIds">The list of transaction ids that were imported. (required).</param>
        public TransactionsImportResponseData(List<string> transactionIds = default(List<string>))
        {
            // to ensure "transactionIds" is required (not null)
            this.TransactionIds = transactionIds ?? throw new ArgumentNullException("transactionIds is a required property for TransactionsImportResponseData and cannot be null");
        }

        /// <summary>
        /// The list of transaction ids that were imported.
        /// </summary>
        /// <value>The list of transaction ids that were imported.</value>
        [DataMember(Name = "transaction_ids", IsRequired = true, EmitDefaultValue = false)]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsImportResponseData {\n");
            sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
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
            return this.Equals(input as TransactionsImportResponseData);
        }

        /// <summary>
        /// Returns true if TransactionsImportResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsImportResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsImportResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionIds == input.TransactionIds ||
                    this.TransactionIds != null &&
                    input.TransactionIds != null &&
                    this.TransactionIds.SequenceEqual(input.TransactionIds)
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
                if (this.TransactionIds != null)
                    hashCode = hashCode * 59 + this.TransactionIds.GetHashCode();
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