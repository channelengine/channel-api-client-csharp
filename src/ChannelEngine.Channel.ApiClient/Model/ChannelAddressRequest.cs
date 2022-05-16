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
    /// ChannelAddressRequest
    /// </summary>
    [DataContract(Name = "ChannelAddressRequest")]
    public partial class ChannelAddressRequest : IEquatable<ChannelAddressRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "Gender", EmitDefaultValue = false)]
        public Gender? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelAddressRequest" /> class.
        /// </summary>
        /// <param name="gender">gender.</param>
        /// <param name="companyName">Optional. Company addressed too..</param>
        /// <param name="firstName">The first name of the customer..</param>
        /// <param name="lastName">The last name of the customer (includes the surname prefix [tussenvoegsel] like &#39;de&#39;, &#39;van&#39;, &#39;du&#39;)..</param>
        /// <param name="streetName">The name of the street (without house number information)  This field might be empty if address validation is disabled in ChannelEngine..</param>
        /// <param name="houseNr">The house number  This field might be empty if address validation is disabled in ChannelEngine..</param>
        /// <param name="houseNrAddition">Optional. Addition to the house number  If the address is: Groenhazengracht 2c, the address will be:  StreetName: Groenhazengracht  HouseNo: 2  HouseNrAddition: c  This field might be empty if address validation is disabled in ChannelEngine..</param>
        /// <param name="zipCode">The zip or postal code..</param>
        /// <param name="city">The name of the city..</param>
        /// <param name="region">Optional. State/province/region..</param>
        /// <param name="countryIso">For example: NL, BE, FR..</param>
        /// <param name="original">Optional. The address as a single string: use in case the address lines are entered  as single lines and later parsed into street, house number and house number addition..</param>
        public ChannelAddressRequest(Gender? gender = default(Gender?), string companyName = default(string), string firstName = default(string), string lastName = default(string), string streetName = default(string), string houseNr = default(string), string houseNrAddition = default(string), string zipCode = default(string), string city = default(string), string region = default(string), string countryIso = default(string), string original = default(string))
        {
            this.Gender = gender;
            this.CompanyName = companyName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StreetName = streetName;
            this.HouseNr = houseNr;
            this.HouseNrAddition = houseNrAddition;
            this.ZipCode = zipCode;
            this.City = city;
            this.Region = region;
            this.CountryIso = countryIso;
            this.Original = original;
        }

        /// <summary>
        /// Optional. Company addressed too.
        /// </summary>
        /// <value>Optional. Company addressed too.</value>
        [DataMember(Name = "CompanyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The first name of the customer.
        /// </summary>
        /// <value>The first name of the customer.</value>
        [DataMember(Name = "FirstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the customer (includes the surname prefix [tussenvoegsel] like &#39;de&#39;, &#39;van&#39;, &#39;du&#39;).
        /// </summary>
        /// <value>The last name of the customer (includes the surname prefix [tussenvoegsel] like &#39;de&#39;, &#39;van&#39;, &#39;du&#39;).</value>
        [DataMember(Name = "LastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The name of the street (without house number information)  This field might be empty if address validation is disabled in ChannelEngine.
        /// </summary>
        /// <value>The name of the street (without house number information)  This field might be empty if address validation is disabled in ChannelEngine.</value>
        [DataMember(Name = "StreetName", EmitDefaultValue = true)]
        public string StreetName { get; set; }

        /// <summary>
        /// The house number  This field might be empty if address validation is disabled in ChannelEngine.
        /// </summary>
        /// <value>The house number  This field might be empty if address validation is disabled in ChannelEngine.</value>
        [DataMember(Name = "HouseNr", EmitDefaultValue = true)]
        public string HouseNr { get; set; }

        /// <summary>
        /// Optional. Addition to the house number  If the address is: Groenhazengracht 2c, the address will be:  StreetName: Groenhazengracht  HouseNo: 2  HouseNrAddition: c  This field might be empty if address validation is disabled in ChannelEngine.
        /// </summary>
        /// <value>Optional. Addition to the house number  If the address is: Groenhazengracht 2c, the address will be:  StreetName: Groenhazengracht  HouseNo: 2  HouseNrAddition: c  This field might be empty if address validation is disabled in ChannelEngine.</value>
        [DataMember(Name = "HouseNrAddition", EmitDefaultValue = true)]
        public string HouseNrAddition { get; set; }

        /// <summary>
        /// The zip or postal code.
        /// </summary>
        /// <value>The zip or postal code.</value>
        [DataMember(Name = "ZipCode", EmitDefaultValue = true)]
        public string ZipCode { get; set; }

        /// <summary>
        /// The name of the city.
        /// </summary>
        /// <value>The name of the city.</value>
        [DataMember(Name = "City", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Optional. State/province/region.
        /// </summary>
        /// <value>Optional. State/province/region.</value>
        [DataMember(Name = "Region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// For example: NL, BE, FR.
        /// </summary>
        /// <value>For example: NL, BE, FR.</value>
        [DataMember(Name = "CountryIso", EmitDefaultValue = true)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Optional. The address as a single string: use in case the address lines are entered  as single lines and later parsed into street, house number and house number addition.
        /// </summary>
        /// <value>Optional. The address as a single string: use in case the address lines are entered  as single lines and later parsed into street, house number and house number addition.</value>
        [DataMember(Name = "Original", EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelAddressRequest {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  HouseNr: ").Append(HouseNr).Append("\n");
            sb.Append("  HouseNrAddition: ").Append(HouseNrAddition).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
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
            return this.Equals(input as ChannelAddressRequest);
        }

        /// <summary>
        /// Returns true if ChannelAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelAddressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.HouseNr == input.HouseNr ||
                    (this.HouseNr != null &&
                    this.HouseNr.Equals(input.HouseNr))
                ) && 
                (
                    this.HouseNrAddition == input.HouseNrAddition ||
                    (this.HouseNrAddition != null &&
                    this.HouseNrAddition.Equals(input.HouseNrAddition))
                ) && 
                (
                    this.ZipCode == input.ZipCode ||
                    (this.ZipCode != null &&
                    this.ZipCode.Equals(input.ZipCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.Original == input.Original ||
                    (this.Original != null &&
                    this.Original.Equals(input.Original))
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
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.HouseNr != null)
                    hashCode = hashCode * 59 + this.HouseNr.GetHashCode();
                if (this.HouseNrAddition != null)
                    hashCode = hashCode * 59 + this.HouseNrAddition.GetHashCode();
                if (this.ZipCode != null)
                    hashCode = hashCode * 59 + this.ZipCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CountryIso != null)
                    hashCode = hashCode * 59 + this.CountryIso.GetHashCode();
                if (this.Original != null)
                    hashCode = hashCode * 59 + this.Original.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // CompanyName (string) maxLength
            if(this.CompanyName != null && this.CompanyName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be less than 50.", new [] { "CompanyName" });
            }

            // CompanyName (string) minLength
            if(this.CompanyName != null && this.CompanyName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be greater than 0.", new [] { "CompanyName" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 50.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if(this.FirstName != null && this.FirstName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 0.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 50.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if(this.LastName != null && this.LastName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 0.", new [] { "LastName" });
            }

            // StreetName (string) maxLength
            if(this.StreetName != null && this.StreetName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetName, length must be less than 50.", new [] { "StreetName" });
            }

            // StreetName (string) minLength
            if(this.StreetName != null && this.StreetName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreetName, length must be greater than 0.", new [] { "StreetName" });
            }

            // HouseNr (string) maxLength
            if(this.HouseNr != null && this.HouseNr.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNr, length must be less than 50.", new [] { "HouseNr" });
            }

            // HouseNr (string) minLength
            if(this.HouseNr != null && this.HouseNr.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNr, length must be greater than 0.", new [] { "HouseNr" });
            }

            // HouseNrAddition (string) maxLength
            if(this.HouseNrAddition != null && this.HouseNrAddition.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNrAddition, length must be less than 50.", new [] { "HouseNrAddition" });
            }

            // HouseNrAddition (string) minLength
            if(this.HouseNrAddition != null && this.HouseNrAddition.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HouseNrAddition, length must be greater than 0.", new [] { "HouseNrAddition" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 50.", new [] { "City" });
            }

            // City (string) minLength
            if(this.City != null && this.City.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be greater than 0.", new [] { "City" });
            }

            // Region (string) maxLength
            if(this.Region != null && this.Region.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be less than 50.", new [] { "Region" });
            }

            // Region (string) minLength
            if(this.Region != null && this.Region.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be greater than 0.", new [] { "Region" });
            }

            // CountryIso (string) maxLength
            if(this.CountryIso != null && this.CountryIso.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryIso, length must be less than 2.", new [] { "CountryIso" });
            }

            // CountryIso (string) minLength
            if(this.CountryIso != null && this.CountryIso.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryIso, length must be greater than 0.", new [] { "CountryIso" });
            }

            // Original (string) maxLength
            if(this.Original != null && this.Original.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Original, length must be less than 256.", new [] { "Original" });
            }

            // Original (string) minLength
            if(this.Original != null && this.Original.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Original, length must be greater than 0.", new [] { "Original" });
            }

            yield break;
        }
    }

}
