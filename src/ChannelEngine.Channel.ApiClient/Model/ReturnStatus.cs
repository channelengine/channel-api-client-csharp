/*
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.11.0
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
    /// Defines ReturnStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReturnStatus
    {
        /// <summary>
        /// Enum INPROGRESS for value: IN_PROGRESS
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS = 1,

        /// <summary>
        /// Enum RECEIVED for value: RECEIVED
        /// </summary>
        [EnumMember(Value = "RECEIVED")]
        RECEIVED = 2,

        /// <summary>
        /// Enum CANCELLED for value: CANCELLED
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        CANCELLED = 3

    }
}
