/* 
 * ChannelEngine Channel API
 *
 * ChannelEngine API for channels
 *
 * The version of the OpenAPI document: 2.9.3
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
    /// Defines Gender
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Gender
    {
        /// <summary>
        /// Enum MALE for value: MALE
        /// </summary>
        [EnumMember(Value = "MALE")]
        MALE = 1,

        /// <summary>
        /// Enum FEMALE for value: FEMALE
        /// </summary>
        [EnumMember(Value = "FEMALE")]
        FEMALE = 2,

        /// <summary>
        /// Enum NOTAPPLICABLE for value: NOT_APPLICABLE
        /// </summary>
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOTAPPLICABLE = 3

    }

}
