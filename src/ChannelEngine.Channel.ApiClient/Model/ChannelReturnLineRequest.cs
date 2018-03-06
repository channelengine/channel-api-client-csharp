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
        /// <param name="channelProductNo">channelProductNo (required).</param>
        /// <param name="quantity">quantity (required).</param>
        public ChannelReturnLineRequest(string channelProductNo = default(string), int? quantity = default(int?))
        {
            // to ensure "channelProductNo" is required (not null)
            if (channelProductNo == null)
            {
                throw new InvalidDataException("channelProductNo is a required property for ChannelReturnLineRequest and cannot be null");
            }
            else
            {
                this.ChannelProductNo = channelProductNo;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for ChannelReturnLineRequest and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
        }
        
        /// <summary>
        /// Gets or Sets ChannelProductNo
        /// </summary>
        [DataMember(Name="ChannelProductNo", EmitDefaultValue=false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelReturnLineRequest {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
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
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
