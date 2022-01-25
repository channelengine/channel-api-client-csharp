/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.11
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
    /// Defines ShipmentLineStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ShipmentLineStatus
    {
        /// <summary>
        /// Enum SHIPPED for value: SHIPPED
        /// </summary>
        [EnumMember(Value = "SHIPPED")]
        SHIPPED = 1,

        /// <summary>
        /// Enum INBACKORDER for value: IN_BACKORDER
        /// </summary>
        [EnumMember(Value = "IN_BACKORDER")]
        IN_BACKORDER = 2,

        /// <summary>
        /// Enum MANCO for value: MANCO
        /// </summary>
        [EnumMember(Value = "MANCO")]
        MANCO = 3

    }
}
