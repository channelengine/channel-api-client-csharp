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
    /// Defines OrderStatusView
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderStatusView
    {
        /// <summary>
        /// Enum INPROGRESS for value: IN_PROGRESS
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS = 1,

        /// <summary>
        /// Enum SHIPPED for value: SHIPPED
        /// </summary>
        [EnumMember(Value = "SHIPPED")]
        SHIPPED = 2,

        /// <summary>
        /// Enum INBACKORDER for value: IN_BACKORDER
        /// </summary>
        [EnumMember(Value = "IN_BACKORDER")]
        IN_BACKORDER = 3,

        /// <summary>
        /// Enum MANCO for value: MANCO
        /// </summary>
        [EnumMember(Value = "MANCO")]
        MANCO = 4,

        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED = 5,

        /// <summary>
        /// Enum INCOMBI for value: IN_COMBI
        /// </summary>
        [EnumMember(Value = "IN_COMBI")]
        IN_COMBI = 6,

        /// <summary>
        /// Enum CLOSED for value: CLOSED
        /// </summary>
        [EnumMember(Value = "CLOSED")]
        CLOSED = 7,

        /// <summary>
        /// Enum NEW for value: NEW
        /// </summary>
        [EnumMember(Value = "NEW")]
        NEW = 8,

        /// <summary>
        /// Enum RETURNED for value: RETURNED
        /// </summary>
        [EnumMember(Value = "RETURNED")]
        RETURNED = 9,

        /// <summary>
        /// Enum REQUIRESCORRECTION for value: REQUIRES_CORRECTION
        /// </summary>
        [EnumMember(Value = "REQUIRES_CORRECTION")]
        REQUIRES_CORRECTION = 10,

        /// <summary>
        /// Enum AWAITINGPAYMENT for value: AWAITING_PAYMENT
        /// </summary>
        [EnumMember(Value = "AWAITING_PAYMENT")]
        AWAITING_PAYMENT = 11

    }
}