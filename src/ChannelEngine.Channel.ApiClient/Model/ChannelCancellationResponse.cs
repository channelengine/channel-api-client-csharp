/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * OpenAPI spec version: 2.6.1
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
    /// ChannelCancellationResponse
    /// </summary>
    [DataContract]
    public partial class ChannelCancellationResponse :  IEquatable<ChannelCancellationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCancellationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCancellationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCancellationResponse" /> class.
        /// </summary>
        /// <param name="channelOrderNo">channelOrderNo (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="reason">reason.</param>
        public ChannelCancellationResponse(string channelOrderNo = default(string), List<ChannelCancellationLineResponse> lines = default(List<ChannelCancellationLineResponse>), string reason = default(string))
        {
            // to ensure "channelOrderNo" is required (not null)
            if (channelOrderNo == null)
            {
                throw new InvalidDataException("channelOrderNo is a required property for ChannelCancellationResponse and cannot be null");
            }
            else
            {
                this.ChannelOrderNo = channelOrderNo;
            }
            // to ensure "lines" is required (not null)
            if (lines == null)
            {
                throw new InvalidDataException("lines is a required property for ChannelCancellationResponse and cannot be null");
            }
            else
            {
                this.Lines = lines;
            }
            this.Reason = reason;
        }
        
        /// <summary>
        /// Gets or Sets ChannelOrderNo
        /// </summary>
        [DataMember(Name="ChannelOrderNo", EmitDefaultValue=false)]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<ChannelCancellationLineResponse> Lines { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
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
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
