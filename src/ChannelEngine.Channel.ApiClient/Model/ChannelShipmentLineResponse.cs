/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.7
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
    /// ChannelShipmentLineResponse
    /// </summary>
    [DataContract(Name = "ChannelShipmentLineResponse")]
    public partial class ChannelShipmentLineResponse : IEquatable<ChannelShipmentLineResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [DataMember(Name = "ShipmentStatus", EmitDefaultValue = false)]
        public ShipmentLineStatus? ShipmentStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelShipmentLineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelShipmentLineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelShipmentLineResponse" /> class.
        /// </summary>
        /// <param name="channelProductNo">The unique product reference used by the Channel. (required).</param>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant..</param>
        /// <param name="orderLine">orderLine.</param>
        /// <param name="shipmentStatus">shipmentStatus.</param>
        /// <param name="quantity">Number of items of the product in the shipment. (required).</param>
        public ChannelShipmentLineResponse(string channelProductNo = default(string), string merchantProductNo = default(string), ChannelOrderLineResponse orderLine = default(ChannelOrderLineResponse), ShipmentLineStatus? shipmentStatus = default(ShipmentLineStatus?), int quantity = default(int))
        {
            // to ensure "channelProductNo" is required (not null)
            this.ChannelProductNo = channelProductNo ?? throw new ArgumentNullException("channelProductNo is a required property for ChannelShipmentLineResponse and cannot be null");
            this.Quantity = quantity;
            this.MerchantProductNo = merchantProductNo;
            this.OrderLine = orderLine;
            this.ShipmentStatus = shipmentStatus;
        }

        /// <summary>
        /// The unique product reference used by the Channel.
        /// </summary>
        /// <value>The unique product reference used by the Channel.</value>
        [DataMember(Name = "ChannelProductNo", IsRequired = true, EmitDefaultValue = false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// The unique product reference used by the Merchant.
        /// </summary>
        /// <value>The unique product reference used by the Merchant.</value>
        [DataMember(Name = "MerchantProductNo", EmitDefaultValue = true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Gets or Sets OrderLine
        /// </summary>
        [DataMember(Name = "OrderLine", EmitDefaultValue = false)]
        public ChannelOrderLineResponse OrderLine { get; set; }

        /// <summary>
        /// Number of items of the product in the shipment.
        /// </summary>
        /// <value>Number of items of the product in the shipment.</value>
        [DataMember(Name = "Quantity", IsRequired = true, EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelShipmentLineResponse {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  OrderLine: ").Append(OrderLine).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as ChannelShipmentLineResponse);
        }

        /// <summary>
        /// Returns true if ChannelShipmentLineResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelShipmentLineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelShipmentLineResponse input)
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
                    this.OrderLine == input.OrderLine ||
                    (this.OrderLine != null &&
                    this.OrderLine.Equals(input.OrderLine))
                ) && 
                (
                    this.ShipmentStatus == input.ShipmentStatus ||
                    this.ShipmentStatus.Equals(input.ShipmentStatus)
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.OrderLine != null)
                    hashCode = hashCode * 59 + this.OrderLine.GetHashCode();
                hashCode = hashCode * 59 + this.ShipmentStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
