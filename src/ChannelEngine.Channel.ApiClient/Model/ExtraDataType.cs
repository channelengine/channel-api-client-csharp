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
    /// Defines ExtraDataType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ExtraDataType
    {
        /// <summary>
        /// Enum TEXT for value: TEXT
        /// </summary>
        [EnumMember(Value = "TEXT")]
        TEXT = 1,

        /// <summary>
        /// Enum NUMBER for value: NUMBER
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        NUMBER = 2,

        /// <summary>
        /// Enum URL for value: URL
        /// </summary>
        [EnumMember(Value = "URL")]
        URL = 3,

        /// <summary>
        /// Enum IMAGEURL for value: IMAGEURL
        /// </summary>
        [EnumMember(Value = "IMAGEURL")]
        IMAGEURL = 4

    }
}
