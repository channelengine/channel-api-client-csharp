/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * OpenAPI spec version: 2.6.0
 * 
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
using SwaggerDateConverter = ChannelEngine.Channel.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Channel.ApiClient.Model
{
    /// <summary>
    /// SingleOfChannelProductChangesResponse
    /// </summary>
    [DataContract]
    public partial class SingleOfChannelProductChangesResponse :  IEquatable<SingleOfChannelProductChangesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleOfChannelProductChangesResponse" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        /// <param name="validationErrors">validationErrors.</param>
        public SingleOfChannelProductChangesResponse(ChannelProductChangesResponse content = default(ChannelProductChangesResponse), int? statusCode = default(int?), bool? success = default(bool?), string message = default(string), Dictionary<string, List<string>> validationErrors = default(Dictionary<string, List<string>>))
        {
            this.Content = content;
            this.StatusCode = statusCode;
            this.Success = success;
            this.Message = message;
            this.ValidationErrors = validationErrors;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public ChannelProductChangesResponse Content { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="StatusCode", EmitDefaultValue=false)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="Success", EmitDefaultValue=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleOfChannelProductChangesResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as SingleOfChannelProductChangesResponse);
        }

        /// <summary>
        /// Returns true if SingleOfChannelProductChangesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SingleOfChannelProductChangesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleOfChannelProductChangesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.Success == input.Success ||
                    (this.Success != null &&
                    this.Success.Equals(input.Success))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.Success != null)
                    hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
