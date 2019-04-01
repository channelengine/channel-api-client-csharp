/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ChannelEngine.Channel.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Channel.ApiClient.Model
{
    /// <summary>
    /// ChannelOrderLineRequest
    /// </summary>
    [DataContract]
    public partial class ChannelOrderLineRequest :  IEquatable<ChannelOrderLineRequest>
    {
        /// <summary>
        /// The condition of the product, this can be used to indicate that a product is a second-hand product
        /// </summary>
        /// <value>The condition of the product, this can be used to indicate that a product is a second-hand product</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionEnum
        {
            
            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW = 1,
            
            /// <summary>
            /// Enum NEWREFURBISHED for value: NEW_REFURBISHED
            /// </summary>
            [EnumMember(Value = "NEW_REFURBISHED")]
            NEWREFURBISHED = 2,
            
            /// <summary>
            /// Enum USEDASNEW for value: USED_AS_NEW
            /// </summary>
            [EnumMember(Value = "USED_AS_NEW")]
            USEDASNEW = 3,
            
            /// <summary>
            /// Enum USEDGOOD for value: USED_GOOD
            /// </summary>
            [EnumMember(Value = "USED_GOOD")]
            USEDGOOD = 4,
            
            /// <summary>
            /// Enum USEDREASONABLE for value: USED_REASONABLE
            /// </summary>
            [EnumMember(Value = "USED_REASONABLE")]
            USEDREASONABLE = 5,
            
            /// <summary>
            /// Enum USEDMEDIOCRE for value: USED_MEDIOCRE
            /// </summary>
            [EnumMember(Value = "USED_MEDIOCRE")]
            USEDMEDIOCRE = 6,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 7,
            
            /// <summary>
            /// Enum USEDVERYGOOD for value: USED_VERY_GOOD
            /// </summary>
            [EnumMember(Value = "USED_VERY_GOOD")]
            USEDVERYGOOD = 8
        }

        /// <summary>
        /// The condition of the product, this can be used to indicate that a product is a second-hand product
        /// </summary>
        /// <value>The condition of the product, this can be used to indicate that a product is a second-hand product</value>
        [DataMember(Name="Condition", EmitDefaultValue=false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelOrderLineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelOrderLineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelOrderLineRequest" /> class.
        /// </summary>
        /// <param name="channelProductNo">The unique order reference used by the channel (required).</param>
        /// <param name="quantity">The number of items of the product (required).</param>
        /// <param name="cancellationRequestedQuantity">The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine.</param>
        /// <param name="unitPriceInclVat">The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering). (required).</param>
        /// <param name="feeFixed">A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable..</param>
        /// <param name="feeRate">A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable..</param>
        /// <param name="condition">The condition of the product, this can be used to indicate that a product is a second-hand product.</param>
        public ChannelOrderLineRequest(string channelProductNo = default(string), int? quantity = default(int?), int? cancellationRequestedQuantity = default(int?), decimal? unitPriceInclVat = default(decimal?), decimal? feeFixed = default(decimal?), decimal? feeRate = default(decimal?), ConditionEnum? condition = default(ConditionEnum?))
        {
            // to ensure "channelProductNo" is required (not null)
            if (channelProductNo == null)
            {
                throw new InvalidDataException("channelProductNo is a required property for ChannelOrderLineRequest and cannot be null");
            }
            else
            {
                this.ChannelProductNo = channelProductNo;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for ChannelOrderLineRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "unitPriceInclVat" is required (not null)
            if (unitPriceInclVat == null)
            {
                throw new InvalidDataException("unitPriceInclVat is a required property for ChannelOrderLineRequest and cannot be null");
            }
            else
            {
                this.UnitPriceInclVat = unitPriceInclVat;
            }
            this.CancellationRequestedQuantity = cancellationRequestedQuantity;
            this.FeeFixed = feeFixed;
            this.FeeRate = feeRate;
            this.Condition = condition;
        }
        
        /// <summary>
        /// The unique order reference used by the channel
        /// </summary>
        /// <value>The unique order reference used by the channel</value>
        [DataMember(Name="ChannelProductNo", EmitDefaultValue=false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// The number of items of the product
        /// </summary>
        /// <value>The number of items of the product</value>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine
        /// </summary>
        /// <value>The number of items for which cancellation was requested by the customer.  Some channels allow a customer to cancel an order until it has been shipped.  When an order has already been acknowledged in ChannelEngine, it can only be cancelled by creating a cancellation.  Use this field to check whether it is still possible to cancel the order. If this is the case, submit a cancellation to ChannelEngine</value>
        [DataMember(Name="CancellationRequestedQuantity", EmitDefaultValue=false)]
        public int? CancellationRequestedQuantity { get; set; }

        /// <summary>
        /// The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).
        /// </summary>
        /// <value>The value of a single unit of the ordered product including VAT  (in the shop&#39;s base currency calculated using the exchange rate at the time of ordering).</value>
        [DataMember(Name="UnitPriceInclVat", EmitDefaultValue=false)]
        public decimal? UnitPriceInclVat { get; set; }

        /// <summary>
        /// A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name="FeeFixed", EmitDefaultValue=false)]
        public decimal? FeeFixed { get; set; }

        /// <summary>
        /// A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.
        /// </summary>
        /// <value>A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable.</value>
        [DataMember(Name="FeeRate", EmitDefaultValue=false)]
        public decimal? FeeRate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelOrderLineRequest {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  CancellationRequestedQuantity: ").Append(CancellationRequestedQuantity).Append("\n");
            sb.Append("  UnitPriceInclVat: ").Append(UnitPriceInclVat).Append("\n");
            sb.Append("  FeeFixed: ").Append(FeeFixed).Append("\n");
            sb.Append("  FeeRate: ").Append(FeeRate).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.CancellationRequestedQuantity == input.CancellationRequestedQuantity ||
                    (this.CancellationRequestedQuantity != null &&
                    this.CancellationRequestedQuantity.Equals(input.CancellationRequestedQuantity))
                ) && 
                (
                    this.UnitPriceInclVat == input.UnitPriceInclVat ||
                    (this.UnitPriceInclVat != null &&
                    this.UnitPriceInclVat.Equals(input.UnitPriceInclVat))
                ) && 
                (
                    this.FeeFixed == input.FeeFixed ||
                    (this.FeeFixed != null &&
                    this.FeeFixed.Equals(input.FeeFixed))
                ) && 
                (
                    this.FeeRate == input.FeeRate ||
                    (this.FeeRate != null &&
                    this.FeeRate.Equals(input.FeeRate))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
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
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.CancellationRequestedQuantity != null)
                    hashCode = hashCode * 59 + this.CancellationRequestedQuantity.GetHashCode();
                if (this.UnitPriceInclVat != null)
                    hashCode = hashCode * 59 + this.UnitPriceInclVat.GetHashCode();
                if (this.FeeFixed != null)
                    hashCode = hashCode * 59 + this.FeeFixed.GetHashCode();
                if (this.FeeRate != null)
                    hashCode = hashCode * 59 + this.FeeRate.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                return hashCode;
            }
        }
    }

}
