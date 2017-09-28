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
    /// PhoneNumberContact
    /// </summary>
    [DataContract]
    public partial class PhoneNumberContact :  IEquatable<PhoneNumberContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberContact" /> class.
        /// </summary>
        /// <param name="Type">Type of phone number, must be one of: home, business, mobile, fax, pager. Default is home..</param>
        /// <param name="Number">Phone number, as entered. Does not need to be formatted in any particular way. Required..</param>
        /// <param name="Normalized">Phone number in E.164 format. Read-only..</param>
        public PhoneNumberContact(string Type = default(string), string Number = default(string), string Normalized = default(string))
        {
            this.Type = Type;
            this.Number = Number;
            this.Normalized = Normalized;
        }
        
        /// <summary>
        /// Type of phone number, must be one of: home, business, mobile, fax, pager. Default is home.
        /// </summary>
        /// <value>Type of phone number, must be one of: home, business, mobile, fax, pager. Default is home.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Phone number, as entered. Does not need to be formatted in any particular way. Required.
        /// </summary>
        /// <value>Phone number, as entered. Does not need to be formatted in any particular way. Required.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Phone number in E.164 format. Read-only.
        /// </summary>
        /// <value>Phone number in E.164 format. Read-only.</value>
        [DataMember(Name="normalized", EmitDefaultValue=false)]
        public string Normalized { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumberContact {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Normalized: ").Append(Normalized).Append("\n");
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
            return this.Equals(obj as PhoneNumberContact);
        }

        /// <summary>
        /// Returns true if PhoneNumberContact instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneNumberContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberContact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Normalized == other.Normalized ||
                    this.Normalized != null &&
                    this.Normalized.Equals(other.Normalized)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Normalized != null)
                    hash = hash * 59 + this.Normalized.GetHashCode();
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
