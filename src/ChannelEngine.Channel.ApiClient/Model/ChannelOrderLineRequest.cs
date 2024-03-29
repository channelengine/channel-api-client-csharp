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
    /// ChannelOrderLineRequest
    /// </summary>
    [DataContract(Name = "ChannelOrderLineRequest")]
    public partial class ChannelOrderLineRequest : IEquatable<ChannelOrderLineRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "Condition", EmitDefaultValue = false)]
        public Condition? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelOrderLineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelOrderLineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelOrderLineRequest" /> class.
        /// </summary>
        /// <param name="channelProductNo">The unique product reference used by the channel. (required).</param>
        /// <param name="merchantProductNo">The unique product reference used by the merchant..</param>
        /// <param name="quantity">The number of items of the product. (required).</param>
        /// <param name="cancellationRequestedQuantity">The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine..</param>
        /// <param name="unitPriceInclVat">The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering). (required).</param>
        /// <param name="feeFixed">A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable..</param>
        /// <param name="feeRate">A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable..</param>
        /// <param name="condition">condition.</param>
        /// <param name="expectedDeliveryDate">Expected delivery date from channels, empty if channels not support this value.</param>
        public ChannelOrderLineRequest(string channelProductNo = default(string), string merchantProductNo = default(string), int quantity = default(int), int cancellationRequestedQuantity = default(int), decimal unitPriceInclVat = default(decimal), decimal feeFixed = default(decimal), decimal feeRate = default(decimal), Condition? condition = default(Condition?), DateTime? expectedDeliveryDate = default(DateTime?))
        {
            // to ensure "channelProductNo" is required (not null)
            if (channelProductNo == null) {
                throw new ArgumentNullException("channelProductNo is a required property for ChannelOrderLineRequest and cannot be null");
            }
            this.ChannelProductNo = channelProductNo;
            this.Quantity = quantity;
            this.UnitPriceInclVat = unitPriceInclVat;
            this.MerchantProductNo = merchantProductNo;
            this.CancellationRequestedQuantity = cancellationRequestedQuantity;
            this.FeeFixed = feeFixed;
            this.FeeRate = feeRate;
            this.Condition = condition;
            this.ExpectedDeliveryDate = expectedDeliveryDate;
        }

        /// <summary>
        /// The unique product reference used by the channel.
        /// </summary>
        /// <value>The unique product reference used by the channel.</value>
        [DataMember(Name = "ChannelProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// The unique product reference used by the merchant.
        /// </summary>
        /// <value>The unique product reference used by the merchant.</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The number of items of the product.
        /// </summary>
        /// <value>The number of items of the product.</value>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.
        /// </summary>
        /// <value>The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.</value>
        [DataMember(Name = "CancellationRequestedQuantity", EmitDefaultValue = false)]
        public int CancellationRequestedQuantity { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name = "UnitPriceInclVat", IsRequired = true, EmitDefaultValue = false)]
        public decimal UnitPriceInclVat { get; set; }

        /// <summary>
        /// A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A fixed fee that is charged by the Channel for this orderline.  This fee rate is based on the currency of the Channel  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "FeeFixed", EmitDefaultValue = false)]
        public decimal FeeFixed { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name = "FeeRate", EmitDefaultValue = false)]
        public decimal FeeRate { get; set; }

        /// <summary>
        /// Expected delivery date from channels, empty if channels not support this value
        /// </summary>
        /// <value>Expected delivery date from channels, empty if channels not support this value</value>
        [DataMember(Name = "ExpectedDeliveryDate", EmitDefaultValue = true)]
        public DateTime? ExpectedDeliveryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelOrderLineRequest {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CancellationRequestedQuantity: ").Append(CancellationRequestedQuantity).Append("\n");
            sb.Append("  UnitPriceInclVat: ").Append(UnitPriceInclVat).Append("\n");
            sb.Append("  FeeFixed: ").Append(FeeFixed).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  ExpectedDeliveryDate: ").Append(ExpectedDeliveryDate).Append("\n");
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
            return this.Equals(input as ChannelOrderLineRequest);
        }

        /// <summary>
        /// Returns true if ChannelOrderLineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelOrderLineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelOrderLineRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelProductNo == input.ChannelProductNo ||
                    (this.ChannelProductNo != null &&
                    this.ChannelProductNo.Equals(input.ChannelProductNo))
                ) && 
                (
                    this.MerchantProductNo == input.MerchantProductNo ||
                    (this.MerchantProductNo != null &&
                    this.MerchantProductNo.Equals(input.MerchantProductNo))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.CancellationRequestedQuantity == input.CancellationRequestedQuantity ||
                    this.CancellationRequestedQuantity.Equals(input.CancellationRequestedQuantity)
                ) && 
                (
                    this.UnitPriceInclVat == input.UnitPriceInclVat ||
                    this.UnitPriceInclVat.Equals(input.UnitPriceInclVat)
                ) && 
                (
                    this.FeeFixed == input.FeeFixed ||
                    this.FeeFixed.Equals(input.FeeFixed)
                ) && 
                (
                    this.FeeRate == input.FeeRate ||
                    this.FeeRate.Equals(input.FeeRate)
                ) && 
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) && 
                (
                    this.ExpectedDeliveryDate == input.ExpectedDeliveryDate ||
                    (this.ExpectedDeliveryDate != null &&
                    this.ExpectedDeliveryDate.Equals(input.ExpectedDeliveryDate))
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
                if (this.ChannelProductNo != null)
                    hashCode = hashCode * 59 + this.ChannelProductNo.GetHashCode();
                if (this.MerchantProductNo != null)
                    hashCode = hashCode * 59 + this.MerchantProductNo.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                hashCode = hashCode * 59 + this.CancellationRequestedQuantity.GetHashCode();
                hashCode = hashCode * 59 + this.UnitPriceInclVat.GetHashCode();
                hashCode = hashCode * 59 + this.FeeFixed.GetHashCode();
                hashCode = hashCode * 59 + this.FeeRate.GetHashCode();
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.ExpectedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.ExpectedDeliveryDate.GetHashCode();
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
            // ChannelProductNo (string) maxLength
            if(this.ChannelProductNo != null && this.ChannelProductNo.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelProductNo, length must be less than 60.", new [] { "ChannelProductNo" });
            }

            // ChannelProductNo (string) minLength
            if(this.ChannelProductNo != null && this.ChannelProductNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ChannelProductNo, length must be greater than 0.", new [] { "ChannelProductNo" });
            }

            // MerchantProductNo (string) maxLength
            if(this.MerchantProductNo != null && this.MerchantProductNo.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantProductNo, length must be less than 50.", new [] { "MerchantProductNo" });
            }

            // MerchantProductNo (string) minLength
            if(this.MerchantProductNo != null && this.MerchantProductNo.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantProductNo, length must be greater than 0.", new [] { "MerchantProductNo" });
            }

            // Quantity (int) minimum
            if(this.Quantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 0.", new [] { "Quantity" });
            }

            // CancellationRequestedQuantity (int) minimum
            if(this.CancellationRequestedQuantity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CancellationRequestedQuantity, must be a value greater than or equal to 0.", new [] { "CancellationRequestedQuantity" });
            }

            // UnitPriceInclVat (decimal) minimum
            if(this.UnitPriceInclVat < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPriceInclVat, must be a value greater than or equal to 0.", new [] { "UnitPriceInclVat" });
            }

            // FeeFixed (decimal) minimum
            if(this.FeeFixed < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeeFixed, must be a value greater than or equal to 0.", new [] { "FeeFixed" });
            }

            // FeeRate (decimal) minimum
            if(this.FeeRate < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeeRate, must be a value greater than or equal to 0.", new [] { "FeeRate" });
            }

            yield break;
        }
    }

}
