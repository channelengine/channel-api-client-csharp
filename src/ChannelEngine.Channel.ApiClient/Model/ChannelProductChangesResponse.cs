/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.9
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
using OpenAPIDateConverter = ChannelEngine.Channel.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Channel.ApiClient.Model
{
    /// <summary>
    /// ChannelProductChangesResponse
    /// </summary>
    [DataContract(Name = "ChannelProductChangesResponse")]
    public partial class ChannelProductChangesResponse : IEquatable<ChannelProductChangesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelProductChangesResponse" /> class.
        /// </summary>
        /// <param name="toBeCreated">toBeCreated.</param>
        /// <param name="toBeUpdated">toBeUpdated.</param>
        /// <param name="toBeRemoved">toBeRemoved.</param>
        public ChannelProductChangesResponse(List<ChannelProductResponse> toBeCreated = default(List<ChannelProductResponse>), List<ChannelProductResponse> toBeUpdated = default(List<ChannelProductResponse>), List<string> toBeRemoved = default(List<string>))
        {
            this.ToBeCreated = toBeCreated;
            this.ToBeUpdated = toBeUpdated;
            this.ToBeRemoved = toBeRemoved;
        }

        /// <summary>
        /// Gets or Sets ToBeCreated
        /// </summary>
        [DataMember(Name = "ToBeCreated", EmitDefaultValue = true)]
        public List<ChannelProductResponse> ToBeCreated { get; set; }

        /// <summary>
        /// Gets or Sets ToBeUpdated
        /// </summary>
        [DataMember(Name = "ToBeUpdated", EmitDefaultValue = true)]
        public List<ChannelProductResponse> ToBeUpdated { get; set; }

        /// <summary>
        /// Gets or Sets ToBeRemoved
        /// </summary>
        [DataMember(Name = "ToBeRemoved", EmitDefaultValue = true)]
        public List<string> ToBeRemoved { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelProductChangesResponse {\n");
            sb.Append("  ToBeCreated: ").Append(ToBeCreated).Append("\n");
            sb.Append("  ToBeUpdated: ").Append(ToBeUpdated).Append("\n");
            sb.Append("  ToBeRemoved: ").Append(ToBeRemoved).Append("\n");
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
            return this.Equals(input as ChannelProductChangesResponse);
        }

        /// <summary>
        /// Returns true if ChannelProductChangesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelProductChangesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelProductChangesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ToBeCreated == input.ToBeCreated ||
                    this.ToBeCreated != null &&
                    input.ToBeCreated != null &&
                    this.ToBeCreated.SequenceEqual(input.ToBeCreated)
                ) && 
                (
                    this.ToBeUpdated == input.ToBeUpdated ||
                    this.ToBeUpdated != null &&
                    input.ToBeUpdated != null &&
                    this.ToBeUpdated.SequenceEqual(input.ToBeUpdated)
                ) && 
                (
                    this.ToBeRemoved == input.ToBeRemoved ||
                    this.ToBeRemoved != null &&
                    input.ToBeRemoved != null &&
                    this.ToBeRemoved.SequenceEqual(input.ToBeRemoved)
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
                if (this.ToBeCreated != null)
                    hashCode = hashCode * 59 + this.ToBeCreated.GetHashCode();
                if (this.ToBeUpdated != null)
                    hashCode = hashCode * 59 + this.ToBeUpdated.GetHashCode();
                if (this.ToBeRemoved != null)
                    hashCode = hashCode * 59 + this.ToBeRemoved.GetHashCode();
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
