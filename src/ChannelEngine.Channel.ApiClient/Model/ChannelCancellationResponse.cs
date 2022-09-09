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
    /// ChannelCancellationResponse
    /// </summary>
    [DataContract(Name = "ChannelCancellationResponse")]
    public partial class ChannelCancellationResponse : IEquatable<ChannelCancellationResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name = "ReasonCode", EmitDefaultValue = false)]
        public MancoReason? ReasonCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCancellationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCancellationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCancellationResponse" /> class.
        /// </summary>
        /// <param name="channelOrderNo">The unique order reference used by the Channel. (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="createdAt">The date at which the cancellation was created in ChannelEngine..</param>
        /// <param name="updatedAt">The date at which the cancellation was last modified in ChannelEngine..</param>
        /// <param name="reason">Reason for cancellation (text)..</param>
        /// <param name="reasonCode">reasonCode.</param>
        public ChannelCancellationResponse(string channelOrderNo = default(string), List<ChannelCancellationLineResponse> lines = default(List<ChannelCancellationLineResponse>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string reason = default(string), MancoReason? reasonCode = default(MancoReason?))
        {
            // to ensure "channelOrderNo" is required (not null)
            if (channelOrderNo == null) {
                throw new ArgumentNullException("channelOrderNo is a required property for ChannelCancellationResponse and cannot be null");
            }
            this.ChannelOrderNo = channelOrderNo;
            // to ensure "lines" is required (not null)
            if (lines == null) {
                throw new ArgumentNullException("lines is a required property for ChannelCancellationResponse and cannot be null");
            }
            this.Lines = lines;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
        }

        /// <summary>
        /// The unique order reference used by the Channel.
        /// </summary>
        /// <value>The unique order reference used by the Channel.</value>
        [DataMember(Name = "ChannelOrderNo", IsRequired = true, EmitDefaultValue = false)]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name = "Lines", IsRequired = true, EmitDefaultValue = false)]
        public List<ChannelCancellationLineResponse> Lines { get; set; }

        /// <summary>
        /// The date at which the cancellation was created in ChannelEngine.
        /// </summary>
        /// <value>The date at which the cancellation was created in ChannelEngine.</value>
        [DataMember(Name = "CreatedAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date at which the cancellation was last modified in ChannelEngine.
        /// </summary>
        /// <value>The date at which the cancellation was last modified in ChannelEngine.</value>
        [DataMember(Name = "UpdatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Reason for cancellation (text).
        /// </summary>
        /// <value>Reason for cancellation (text).</value>
        [DataMember(Name = "Reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCancellationResponse {\n");
            sb.Append("  ChannelOrderNo: ").Append(ChannelOrderNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
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
            return this.Equals(input as ChannelCancellationResponse);
        }

        /// <summary>
        /// Returns true if ChannelCancellationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelCancellationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCancellationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelOrderNo == input.ChannelOrderNo ||
                    (this.ChannelOrderNo != null &&
                    this.ChannelOrderNo.Equals(input.ChannelOrderNo))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    this.ReasonCode.Equals(input.ReasonCode)
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
                if (this.ChannelOrderNo != null)
                    hashCode = hashCode * 59 + this.ChannelOrderNo.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
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
