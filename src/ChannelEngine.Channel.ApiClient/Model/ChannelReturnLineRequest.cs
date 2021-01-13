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
    /// ChannelReturnLineRequest
    /// </summary>
    [DataContract]
    public partial class ChannelReturnLineRequest :  IEquatable<ChannelReturnLineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelReturnLineRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelReturnLineRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelReturnLineRequest" /> class.
        /// </summary>
        /// <param name="channelProductNo">The unique product reference used by the Channel..</param>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant..</param>
        /// <param name="quantity">Number of items of the product in this return. (required).</param>
        public ChannelReturnLineRequest(string channelProductNo = default(string), string merchantProductNo = default(string), int quantity = default(int))
        {
            this.Quantity = quantity;
            this.ChannelProductNo = channelProductNo;
            this.MerchantProductNo = merchantProductNo;
        }
        
        /// <summary>
        /// The unique product reference used by the Channel.
        /// </summary>
        /// <value>The unique product reference used by the Channel.</value>
        [DataMember(Name="ChannelProductNo", EmitDefaultValue=true)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// The unique product reference used by the Merchant.
        /// </summary>
        /// <value>The unique product reference used by the Merchant.</value>
        [DataMember(Name="MerchantProductNo", EmitDefaultValue=true)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// Number of items of the product in this return.
        /// </summary>
        /// <value>Number of items of the product in this return.</value>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelReturnLineRequest {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelReturnLineRequest);
        }

        /// <summary>
        /// Returns true if ChannelReturnLineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelReturnLineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelReturnLineRequest input)
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
