/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * OpenAPI spec version: 2.5.2
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
    /// ChannelShipmentResponse
    /// </summary>
    [DataContract]
    public partial class ChannelShipmentResponse :  IEquatable<ChannelShipmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelShipmentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelShipmentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelShipmentResponse" /> class.
        /// </summary>
        /// <param name="channelOrderNo">channelOrderNo (required).</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="trackTraceNo">trackTraceNo.</param>
        /// <param name="trackTraceUrl">trackTraceUrl.</param>
        /// <param name="method">method.</param>
        public ChannelShipmentResponse(string channelOrderNo = default(string), List<ChannelShipmentLineResponse> lines = default(List<ChannelShipmentLineResponse>), string trackTraceNo = default(string), string trackTraceUrl = default(string), string method = default(string))
        {
            // to ensure "channelOrderNo" is required (not null)
            if (channelOrderNo == null)
            {
                throw new InvalidDataException("channelOrderNo is a required property for ChannelShipmentResponse and cannot be null");
            }
            else
            {
                this.ChannelOrderNo = channelOrderNo;
            }
            // to ensure "lines" is required (not null)
            if (lines == null)
            {
                throw new InvalidDataException("lines is a required property for ChannelShipmentResponse and cannot be null");
            }
            else
            {
                this.Lines = lines;
            }
            this.TrackTraceNo = trackTraceNo;
            this.TrackTraceUrl = trackTraceUrl;
            this.Method = method;
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
        public List<ChannelShipmentLineResponse> Lines { get; set; }

        /// <summary>
        /// Gets or Sets TrackTraceNo
        /// </summary>
        [DataMember(Name="TrackTraceNo", EmitDefaultValue=false)]
        public string TrackTraceNo { get; set; }

        /// <summary>
        /// Gets or Sets TrackTraceUrl
        /// </summary>
        [DataMember(Name="TrackTraceUrl", EmitDefaultValue=false)]
        public string TrackTraceUrl { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="Method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelShipmentResponse {\n");
            sb.Append("  ChannelOrderNo: ").Append(ChannelOrderNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  TrackTraceNo: ").Append(TrackTraceNo).Append("\n");
            sb.Append("  TrackTraceUrl: ").Append(TrackTraceUrl).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as ChannelShipmentResponse);
        }

        /// <summary>
        /// Returns true if ChannelShipmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelShipmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelShipmentResponse input)
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
                    this.TrackTraceNo == input.TrackTraceNo ||
                    (this.TrackTraceNo != null &&
                    this.TrackTraceNo.Equals(input.TrackTraceNo))
                ) && 
                (
                    this.TrackTraceUrl == input.TrackTraceUrl ||
                    (this.TrackTraceUrl != null &&
                    this.TrackTraceUrl.Equals(input.TrackTraceUrl))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.TrackTraceNo != null)
                    hashCode = hashCode * 59 + this.TrackTraceNo.GetHashCode();
                if (this.TrackTraceUrl != null)
                    hashCode = hashCode * 59 + this.TrackTraceUrl.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
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
            // TrackTraceNo (string) maxLength
            if(this.TrackTraceNo != null && this.TrackTraceNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceNo, length must be less than 50.", new [] { "TrackTraceNo" });
            }

            // TrackTraceNo (string) minLength
            if(this.TrackTraceNo != null && this.TrackTraceNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceNo, length must be greater than 0.", new [] { "TrackTraceNo" });
            }

            // TrackTraceUrl (string) maxLength
            if(this.TrackTraceUrl != null && this.TrackTraceUrl.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceUrl, length must be less than 250.", new [] { "TrackTraceUrl" });
            }

            // TrackTraceUrl (string) minLength
            if(this.TrackTraceUrl != null && this.TrackTraceUrl.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TrackTraceUrl, length must be greater than 0.", new [] { "TrackTraceUrl" });
            }

            // Method (string) maxLength
            if(this.Method != null && this.Method.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Method, length must be less than 50.", new [] { "Method" });
            }

            // Method (string) minLength
            if(this.Method != null && this.Method.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Method, length must be greater than 0.", new [] { "Method" });
            }

            yield break;
        }
    }

}
