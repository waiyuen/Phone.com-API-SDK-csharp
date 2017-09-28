/* 
 * Phone.com API
 *
 * This is a Phone.com api Swagger definition
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apisupport@phone.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ListExtensions
    /// </summary>
    [DataContract]
    public partial class ListExtensions :  IEquatable<ListExtensions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListExtensions" /> class.
        /// </summary>
        /// <param name="Filters">Filters.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="Total">Total.</param>
        /// <param name="Offset">Offset.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Items">Items.</param>
        public ListExtensions(FilterIdExtensionNameArray Filters = default(FilterIdExtensionNameArray), SortIdExtensionName Sort = default(SortIdExtensionName), int? Total = default(int?), int? Offset = default(int?), int? Limit = default(int?), List<ExtensionFull> Items = default(List<ExtensionFull>))
        {
            this.Filters = Filters;
            this.Sort = Sort;
            this.Total = Total;
            this.Offset = Offset;
            this.Limit = Limit;
            this.Items = Items;
        }
        
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public FilterIdExtensionNameArray Filters { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public SortIdExtensionName Sort { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ExtensionFull> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExtensions {\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ListExtensions);
        }

        /// <summary>
        /// Returns true if ListExtensions instances are equal
        /// </summary>
        /// <param name="other">Instance of ListExtensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListExtensions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.Equals(other.Filters)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.Sort != null)
                    hash = hash * 59 + this.Sort.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                return hash;
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
