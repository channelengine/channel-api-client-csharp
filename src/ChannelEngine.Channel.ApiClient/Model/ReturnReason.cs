/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.10
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
    /// Defines ReturnReason
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReturnReason
    {
        /// <summary>
        /// Enum PRODUCTDEFECT for value: PRODUCT_DEFECT
        /// </summary>
        [EnumMember(Value = "PRODUCT_DEFECT")]
        PRODUCT_DEFECT = 1,

        /// <summary>
        /// Enum PRODUCTUNSATISFACTORY for value: PRODUCT_UNSATISFACTORY
        /// </summary>
        [EnumMember(Value = "PRODUCT_UNSATISFACTORY")]
        PRODUCT_UNSATISFACTORY = 2,

        /// <summary>
        /// Enum WRONGPRODUCT for value: WRONG_PRODUCT
        /// </summary>
        [EnumMember(Value = "WRONG_PRODUCT")]
        WRONG_PRODUCT = 3,

        /// <summary>
        /// Enum TOOMANYPRODUCTS for value: TOO_MANY_PRODUCTS
        /// </summary>
        [EnumMember(Value = "TOO_MANY_PRODUCTS")]
        TOO_MANY_PRODUCTS = 4,

        /// <summary>
        /// Enum REFUSED for value: REFUSED
        /// </summary>
        [EnumMember(Value = "REFUSED")]
        REFUSED = 5,

        /// <summary>
        /// Enum REFUSEDDAMAGED for value: REFUSED_DAMAGED
        /// </summary>
        [EnumMember(Value = "REFUSED_DAMAGED")]
        REFUSED_DAMAGED = 6,

        /// <summary>
        /// Enum WRONGADDRESS for value: WRONG_ADDRESS
        /// </summary>
        [EnumMember(Value = "WRONG_ADDRESS")]
        WRONG_ADDRESS = 7,

        /// <summary>
        /// Enum NOTCOLLECTED for value: NOT_COLLECTED
        /// </summary>
        [EnumMember(Value = "NOT_COLLECTED")]
        NOT_COLLECTED = 8,

        /// <summary>
        /// Enum WRONGSIZE for value: WRONG_SIZE
        /// </summary>
        [EnumMember(Value = "WRONG_SIZE")]
        WRONG_SIZE = 9,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 10

    }
}
