/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.13.0
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
    /// CollectionChangesOfChannelProductChangesResponse
    /// </summary>
    [DataContract(Name = "CollectionChangesOfChannelProductChangesResponse")]
    public partial class CollectionChangesOfChannelProductChangesResponse : IEquatable<CollectionChangesOfChannelProductChangesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionChangesOfChannelProductChangesResponse" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="toBeCreatedTotalCount">toBeCreatedTotalCount.</param>
        /// <param name="toBeUpdatedTotalCount">toBeUpdatedTotalCount.</param>
        /// <param name="toBeDeletedTotalCount">toBeDeletedTotalCount.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="logId">logId.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        /// <param name="validationErrors">validationErrors.</param>
        public CollectionChangesOfChannelProductChangesResponse(ChannelProductChangesResponse content = default(ChannelProductChangesResponse), int toBeCreatedTotalCount = default(int), int toBeUpdatedTotalCount = default(int), int toBeDeletedTotalCount = default(int), int statusCode = default(int), string requestId = default(string), string logId = default(string), bool success = default(bool), string message = default(string), Dictionary<string, List<string>> validationErrors = default(Dictionary<string, List<string>>))
        {
            this.Content = content;
            this.ToBeCreatedTotalCount = toBeCreatedTotalCount;
            this.ToBeUpdatedTotalCount = toBeUpdatedTotalCount;
            this.ToBeDeletedTotalCount = toBeDeletedTotalCount;
            this.StatusCode = statusCode;
            this.RequestId = requestId;
            this.LogId = logId;
            this.Success = success;
            this.Message = message;
            this.ValidationErrors = validationErrors;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "Content", EmitDefaultValue = false)]
        public ChannelProductChangesResponse Content { get; set; }

        /// <summary>
        /// Gets or Sets ToBeCreatedTotalCount
        /// </summary>
        [DataMember(Name = "ToBeCreatedTotalCount", EmitDefaultValue = false)]
        public int ToBeCreatedTotalCount { get; set; }

        /// <summary>
        /// Gets or Sets ToBeUpdatedTotalCount
        /// </summary>
        [DataMember(Name = "ToBeUpdatedTotalCount", EmitDefaultValue = false)]
        public int ToBeUpdatedTotalCount { get; set; }

        /// <summary>
        /// Gets or Sets ToBeDeletedTotalCount
        /// </summary>
        [DataMember(Name = "ToBeDeletedTotalCount", EmitDefaultValue = false)]
        public int ToBeDeletedTotalCount { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name = "RequestId", EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets LogId
        /// </summary>
        [DataMember(Name = "LogId", EmitDefaultValue = true)]
        public string LogId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "Success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "Message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets ValidationErrors
        /// </summary>
        [DataMember(Name = "ValidationErrors", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionChangesOfChannelProductChangesResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ToBeCreatedTotalCount: ").Append(ToBeCreatedTotalCount).Append("\n");
            sb.Append("  ToBeUpdatedTotalCount: ").Append(ToBeUpdatedTotalCount).Append("\n");
            sb.Append("  ToBeDeletedTotalCount: ").Append(ToBeDeletedTotalCount).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectionChangesOfChannelProductChangesResponse);
        }

        /// <summary>
        /// Returns true if CollectionChangesOfChannelProductChangesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionChangesOfChannelProductChangesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionChangesOfChannelProductChangesResponse input)
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
                    this.ToBeCreatedTotalCount == input.ToBeCreatedTotalCount ||
                    this.ToBeCreatedTotalCount.Equals(input.ToBeCreatedTotalCount)
                ) && 
                (
                    this.ToBeUpdatedTotalCount == input.ToBeUpdatedTotalCount ||
                    this.ToBeUpdatedTotalCount.Equals(input.ToBeUpdatedTotalCount)
                ) && 
                (
                    this.ToBeDeletedTotalCount == input.ToBeDeletedTotalCount ||
                    this.ToBeDeletedTotalCount.Equals(input.ToBeDeletedTotalCount)
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
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
                hashCode = hashCode * 59 + this.ToBeCreatedTotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.ToBeUpdatedTotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.ToBeDeletedTotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
