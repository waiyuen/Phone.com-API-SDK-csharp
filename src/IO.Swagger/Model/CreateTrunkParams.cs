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
    /// CreateTrunkParams
    /// </summary>
    [DataContract]
    public partial class CreateTrunkParams :  IEquatable<CreateTrunkParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrunkParams" /> class.
        /// </summary>
        /// <param name="Name">Name of Trunk.</param>
        /// <param name="Uri">URI of Trunk (in the form of SIP/user@host.com:port).</param>
        /// <param name="MaxConcurrentCalls">Max concurrent calls.</param>
        /// <param name="MaxMinutesPerMonth">Max minutes per month.</param>
        /// <param name="Greeting">Recording lookup object.</param>
        /// <param name="ErrorMessage">Recording lookup object.</param>
        /// <param name="Codecs">Custom audio codec configuration.</param>
        public CreateTrunkParams(string Name = default(string), string Uri = default(string), int? MaxConcurrentCalls = default(int?), int? MaxMinutesPerMonth = default(int?), Object Greeting = default(Object), Object ErrorMessage = default(Object), List<Object> Codecs = default(List<Object>))
        {
            this.Name = Name;
            this.Uri = Uri;
            this.MaxConcurrentCalls = MaxConcurrentCalls;
            this.MaxMinutesPerMonth = MaxMinutesPerMonth;
            this.Greeting = Greeting;
            this.ErrorMessage = ErrorMessage;
            this.Codecs = Codecs;
        }
        
        /// <summary>
        /// Name of Trunk
        /// </summary>
        /// <value>Name of Trunk</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// URI of Trunk (in the form of SIP/user@host.com:port)
        /// </summary>
        /// <value>URI of Trunk (in the form of SIP/user@host.com:port)</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Max concurrent calls
        /// </summary>
        /// <value>Max concurrent calls</value>
        [DataMember(Name="max_concurrent_calls", EmitDefaultValue=false)]
        public int? MaxConcurrentCalls { get; set; }

        /// <summary>
        /// Max minutes per month
        /// </summary>
        /// <value>Max minutes per month</value>
        [DataMember(Name="max_minutes_per_month", EmitDefaultValue=false)]
        public int? MaxMinutesPerMonth { get; set; }

        /// <summary>
        /// Recording lookup object
        /// </summary>
        /// <value>Recording lookup object</value>
        [DataMember(Name="greeting", EmitDefaultValue=false)]
        public Object Greeting { get; set; }

        /// <summary>
        /// Recording lookup object
        /// </summary>
        /// <value>Recording lookup object</value>
        [DataMember(Name="error_message", EmitDefaultValue=false)]
        public Object ErrorMessage { get; set; }

        /// <summary>
        /// Custom audio codec configuration
        /// </summary>
        /// <value>Custom audio codec configuration</value>
        [DataMember(Name="codecs", EmitDefaultValue=false)]
        public List<Object> Codecs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrunkParams {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  MaxConcurrentCalls: ").Append(MaxConcurrentCalls).Append("\n");
            sb.Append("  MaxMinutesPerMonth: ").Append(MaxMinutesPerMonth).Append("\n");
            sb.Append("  Greeting: ").Append(Greeting).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Codecs: ").Append(Codecs).Append("\n");
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
            return this.Equals(obj as CreateTrunkParams);
        }

        /// <summary>
        /// Returns true if CreateTrunkParams instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateTrunkParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTrunkParams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.MaxConcurrentCalls == other.MaxConcurrentCalls ||
                    this.MaxConcurrentCalls != null &&
                    this.MaxConcurrentCalls.Equals(other.MaxConcurrentCalls)
                ) && 
                (
                    this.MaxMinutesPerMonth == other.MaxMinutesPerMonth ||
                    this.MaxMinutesPerMonth != null &&
                    this.MaxMinutesPerMonth.Equals(other.MaxMinutesPerMonth)
                ) && 
                (
                    this.Greeting == other.Greeting ||
                    this.Greeting != null &&
                    this.Greeting.Equals(other.Greeting)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.Codecs == other.Codecs ||
                    this.Codecs != null &&
                    this.Codecs.SequenceEqual(other.Codecs)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.MaxConcurrentCalls != null)
                    hash = hash * 59 + this.MaxConcurrentCalls.GetHashCode();
                if (this.MaxMinutesPerMonth != null)
                    hash = hash * 59 + this.MaxMinutesPerMonth.GetHashCode();
                if (this.Greeting != null)
                    hash = hash * 59 + this.Greeting.GetHashCode();
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                if (this.Codecs != null)
                    hash = hash * 59 + this.Codecs.GetHashCode();
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
