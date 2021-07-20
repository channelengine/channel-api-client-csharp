/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.8
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
    /// Defines MancoReason
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MancoReason
    {
        /// <summary>
        /// Enum NOTINSTOCK for value: NOT_IN_STOCK
        /// </summary>
        [EnumMember(Value = "NOT_IN_STOCK")]
        NOT_IN_STOCK = 1,

        /// <summary>
        /// Enum DAMAGED for value: DAMAGED
        /// </summary>
        [EnumMember(Value = "DAMAGED")]
        DAMAGED = 2,

        /// <summary>
        /// Enum INCOMPLETE for value: INCOMPLETE
        /// </summary>
        [EnumMember(Value = "INCOMPLETE")]
        INCOMPLETE = 3,

        /// <summary>
        /// Enum CLIENTCANCELLED for value: CLIENT_CANCELLED
        /// </summary>
        [EnumMember(Value = "CLIENT_CANCELLED")]
        CLIENT_CANCELLED = 4,

        /// <summary>
        /// Enum INVALIDADDRESS for value: INVALID_ADDRESS
        /// </summary>
        [EnumMember(Value = "INVALID_ADDRESS")]
        INVALID_ADDRESS = 5,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 6

    }
}
