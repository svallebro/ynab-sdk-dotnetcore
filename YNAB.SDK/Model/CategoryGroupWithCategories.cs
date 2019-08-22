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
    /// CategoryGroupWithCategories
    /// </summary>
    [DataContract]
    public partial class CategoryGroupWithCategories :  IEquatable<CategoryGroupWithCategories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryGroupWithCategories" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoryGroupWithCategories() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryGroupWithCategories" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="hidden">Whether or not the category group is hidden (required).</param>
        /// <param name="deleted">Whether or not the category group has been deleted.  Deleted category groups will only be included in delta requests. (required).</param>
        /// <param name="categories">Category group categories.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC). (required).</param>
        public CategoryGroupWithCategories(Guid id = default(Guid), string name = default(string), bool hidden = default(bool), bool deleted = default(bool), List<Category> categories = default(List<Category>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CategoryGroupWithCategories and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CategoryGroupWithCategories and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "hidden" is required (not null)
            if (hidden == null)
            {
                throw new InvalidDataException("hidden is a required property for CategoryGroupWithCategories and cannot be null");
            }
            else
            {
                this.Hidden = hidden;
            }

            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new InvalidDataException("deleted is a required property for CategoryGroupWithCategories and cannot be null");
            }
            else
            {
                this.Deleted = deleted;
            }

            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new InvalidDataException("categories is a required property for CategoryGroupWithCategories and cannot be null");
            }
            else
            {
                this.Categories = categories;
            }

        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Whether or not the category group is hidden
        /// </summary>
        /// <value>Whether or not the category group is hidden</value>
        [DataMember(Name="hidden", EmitDefaultValue=false)]
        public bool Hidden { get; set; }

        /// <summary>
        /// Whether or not the category group has been deleted.  Deleted category groups will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the category group has been deleted.  Deleted category groups will only be included in delta requests.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Category group categories.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        /// <value>Category group categories.  Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).</value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryGroupWithCategories {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
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
            return this.Equals(input as CategoryGroupWithCategories);
        }

        /// <summary>
        /// Returns true if CategoryGroupWithCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryGroupWithCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryGroupWithCategories input)
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
                    this.Hidden == input.Hidden ||
                    this.Hidden.Equals(input.Hidden)
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
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
                hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
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