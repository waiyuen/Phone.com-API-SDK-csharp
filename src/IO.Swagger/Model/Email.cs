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
    /// Email
    /// </summary>
    [DataContract]
    public partial class Email :  IEquatable<Email>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="Type">Email type, one of: primary or alternate. Default is primary..</param>
        /// <param name="_Email">Email address. Required..</param>
        public Email(string Type = default(string), string _Email = default(string))
        {
            this.Type = Type;
            this._Email = _Email;
        }
        
        /// <summary>
        /// Email type, one of: primary or alternate. Default is primary.
        /// </summary>
        /// <value>Email type, one of: primary or alternate. Default is primary.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Email address. Required.
        /// </summary>
        /// <value>Email address. Required.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string _Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _Email: ").Append(_Email).Append("\n");
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
            return this.Equals(obj as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="other">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email other)
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
                    this._Email == other._Email ||
                    this._Email != null &&
                    this._Email.Equals(other._Email)
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
                if (this._Email != null)
                    hash = hash * 59 + this._Email.GetHashCode();
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
