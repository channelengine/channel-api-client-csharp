/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = ChannelEngine.Channel.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Channel.ApiClient.Model
{
    /// <summary>
    /// ChannelReturnRequest
    /// </summary>
    [DataContract]
    public partial class ChannelReturnRequest :  IEquatable<ChannelReturnRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public ReturnReason? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelReturnRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelReturnRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelReturnRequest" /> class.
        /// </summary>
        /// <param name="channelOrderNo">The unique order reference used by the Channel..</param>
        /// <param name="merchantOrderNo">The unique order reference used by the Merchant (sku)..</param>
        /// <param name="channelReference">The unique return reference used by the Channel. (required).</param>
        /// <param name="keyIsMerchantOrderNo">Optional. Is the MON used as key for the order (default value is false)..</param>
        /// <param name="keyIsMerchantProductNo">Optional. Is the MPN used as key for the product (default value is false)..</param>
        /// <param name="lines">lines (required).</param>
        /// <param name="id">The unique return reference used by ChannelEngine..</param>
        /// <param name="reason">reason.</param>
        /// <param name="customerComment">Optional. Comment of customer on the (reason of) the return..</param>
        /// <param name="merchantComment">Optional. Comment of merchant on the return..</param>
        /// <param name="refundInclVat">Refund amount incl. VAT..</param>
        /// <param name="refundExclVat">Refund amount excl. VAT..</param>
        public ChannelReturnRequest(string channelOrderNo = default(string), string merchantOrderNo = default(string), string channelReference = default(string), bool keyIsMerchantOrderNo = default(bool), bool keyIsMerchantProductNo = default(bool), List<ChannelReturnLineRequest> lines = default(List<ChannelReturnLineRequest>), int id = default(int), ReturnReason? reason = default(ReturnReason?), string customerComment = default(string), string merchantComment = default(string), decimal refundInclVat = default(decimal), decimal refundExclVat = default(decimal))
        {
            // to ensure "channelReference" is required (not null)
            this.ChannelReference = channelReference ?? throw new ArgumentNullException("channelReference is a required property for ChannelReturnRequest and cannot be null");
            // to ensure "lines" is required (not null)
            this.Lines = lines ?? throw new ArgumentNullException("lines is a required property for ChannelReturnRequest and cannot be null");
            this.ChannelOrderNo = channelOrderNo;
            this.MerchantOrderNo = merchantOrderNo;
            this.KeyIsMerchantOrderNo = keyIsMerchantOrderNo;
            this.KeyIsMerchantProductNo = keyIsMerchantProductNo;
            this.Id = id;
            this.Reason = reason;
            this.CustomerComment = customerComment;
            this.MerchantComment = merchantComment;
            this.RefundInclVat = refundInclVat;
            this.RefundExclVat = refundExclVat;
        }
        
        /// <summary>
        /// The unique order reference used by the Channel.
        /// </summary>
        /// <value>The unique order reference used by the Channel.</value>
        [DataMember(Name="ChannelOrderNo", EmitDefaultValue=true)]
        public string ChannelOrderNo { get; set; }

        /// <summary>
        /// The unique order reference used by the Merchant (sku).
        /// </summary>
        /// <value>The unique order reference used by the Merchant (sku).</value>
        [DataMember(Name="MerchantOrderNo", EmitDefaultValue=true)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// The unique return reference used by the Channel.
        /// </summary>
        /// <value>The unique return reference used by the Channel.</value>
        [DataMember(Name="ChannelReference", EmitDefaultValue=false)]
        public string ChannelReference { get; set; }

        /// <summary>
        /// Optional. Is the MON used as key for the order (default value is false).
        /// </summary>
        /// <value>Optional. Is the MON used as key for the order (default value is false).</value>
        [DataMember(Name="KeyIsMerchantOrderNo", EmitDefaultValue=false)]
        public bool KeyIsMerchantOrderNo { get; set; }

        /// <summary>
        /// Optional. Is the MPN used as key for the product (default value is false).
        /// </summary>
        /// <value>Optional. Is the MPN used as key for the product (default value is false).</value>
        [DataMember(Name="KeyIsMerchantProductNo", EmitDefaultValue=false)]
        public bool KeyIsMerchantProductNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<ChannelReturnLineRequest> Lines { get; set; }

        /// <summary>
        /// The unique return reference used by ChannelEngine.
        /// </summary>
        /// <value>The unique return reference used by ChannelEngine.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Optional. Comment of customer on the (reason of) the return.
        /// </summary>
        /// <value>Optional. Comment of customer on the (reason of) the return.</value>
        [DataMember(Name="CustomerComment", EmitDefaultValue=true)]
        public string CustomerComment { get; set; }

        /// <summary>
        /// Optional. Comment of merchant on the return.
        /// </summary>
        /// <value>Optional. Comment of merchant on the return.</value>
        [DataMember(Name="MerchantComment", EmitDefaultValue=true)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Refund amount incl. VAT.
        /// </summary>
        /// <value>Refund amount incl. VAT.</value>
        [DataMember(Name="RefundInclVat", EmitDefaultValue=false)]
        public decimal RefundInclVat { get; set; }

        /// <summary>
        /// Refund amount excl. VAT.
        /// </summary>
        /// <value>Refund amount excl. VAT.</value>
        [DataMember(Name="RefundExclVat", EmitDefaultValue=false)]
        public decimal RefundExclVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelReturnRequest {\n");
            sb.Append("  ChannelOrderNo: ").Append(ChannelOrderNo).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  ChannelReference: ").Append(ChannelReference).Append("\n");
            sb.Append("  KeyIsMerchantOrderNo: ").Append(KeyIsMerchantOrderNo).Append("\n");
            sb.Append("  KeyIsMerchantProductNo: ").Append(KeyIsMerchantProductNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  CustomerComment: ").Append(CustomerComment).Append("\n");
            sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
            sb.Append("  RefundInclVat: ").Append(RefundInclVat).Append("\n");
            sb.Append("  RefundExclVat: ").Append(RefundExclVat).Append("\n");
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
            return this.Equals(input as ChannelReturnRequest);
        }

        /// <summary>
        /// Returns true if ChannelReturnRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelReturnRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelReturnRequest input)
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
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.ChannelReference == input.ChannelReference ||
                    (this.ChannelReference != null &&
                    this.ChannelReference.Equals(input.ChannelReference))
                ) && 
                (
                    this.KeyIsMerchantOrderNo == input.KeyIsMerchantOrderNo ||
                    this.KeyIsMerchantOrderNo.Equals(input.KeyIsMerchantOrderNo)
                ) && 
                (
                    this.KeyIsMerchantProductNo == input.KeyIsMerchantProductNo ||
                    this.KeyIsMerchantProductNo.Equals(input.KeyIsMerchantProductNo)
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    input.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Reason == input.Reason ||
                    this.Reason.Equals(input.Reason)
                ) && 
                (
                    this.CustomerComment == input.CustomerComment ||
                    (this.CustomerComment != null &&
                    this.CustomerComment.Equals(input.CustomerComment))
                ) && 
                (
                    this.MerchantComment == input.MerchantComment ||
                    (this.MerchantComment != null &&
                    this.MerchantComment.Equals(input.MerchantComment))
                ) && 
                (
                    this.RefundInclVat == input.RefundInclVat ||
                    this.RefundInclVat.Equals(input.RefundInclVat)
                ) && 
                (
                    this.RefundExclVat == input.RefundExclVat ||
                    this.RefundExclVat.Equals(input.RefundExclVat)
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
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.ChannelReference != null)
                    hashCode = hashCode * 59 + this.ChannelReference.GetHashCode();
                hashCode = hashCode * 59 + this.KeyIsMerchantOrderNo.GetHashCode();
                hashCode = hashCode * 59 + this.KeyIsMerchantProductNo.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.CustomerComment != null)
                    hashCode = hashCode * 59 + this.CustomerComment.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
                hashCode = hashCode * 59 + this.RefundInclVat.GetHashCode();
                hashCode = hashCode * 59 + this.RefundExclVat.GetHashCode();
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
            // CustomerComment (string) maxLength
            if(this.CustomerComment != null && this.CustomerComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be less than 4001.", new [] { "CustomerComment" });
            }

            // CustomerComment (string) minLength
            if(this.CustomerComment != null && this.CustomerComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be greater than 0.", new [] { "CustomerComment" });
            }

            // MerchantComment (string) maxLength
            if(this.MerchantComment != null && this.MerchantComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be less than 4001.", new [] { "MerchantComment" });
            }

            // MerchantComment (string) minLength
            if(this.MerchantComment != null && this.MerchantComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be greater than 0.", new [] { "MerchantComment" });
            }

            yield break;
        }
    }

}
