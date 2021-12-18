/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
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
using OpenAPIDateConverter = Accounting.Components.Domain.Client.OpenAPIDateConverter;

namespace Accounting.Components.Domain.Model.Accounting
{
    /// <summary>
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// User role that defines permissions in Xero and via API (READONLY, INVOICEONLY, STANDARD, FINANCIALADVISER, etc)
        /// </summary>
        /// <value>User role that defines permissions in Xero and via API (READONLY, INVOICEONLY, STANDARD, FINANCIALADVISER, etc)</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum OrganisationRoleEnum
        {
            /// <summary>
            /// Enum READONLY for value: READONLY
            /// </summary>
            [EnumMember(Value = "READONLY")]
            READONLY = 1,

            /// <summary>
            /// Enum INVOICEONLY for value: INVOICEONLY
            /// </summary>
            [EnumMember(Value = "INVOICEONLY")]
            INVOICEONLY = 2,

            /// <summary>
            /// Enum STANDARD for value: STANDARD
            /// </summary>
            [EnumMember(Value = "STANDARD")]
            STANDARD = 3,

            /// <summary>
            /// Enum FINANCIALADVISER for value: FINANCIALADVISER
            /// </summary>
            [EnumMember(Value = "FINANCIALADVISER")]
            FINANCIALADVISER = 4,

            /// <summary>
            /// Enum MANAGEDCLIENT for value: MANAGEDCLIENT
            /// </summary>
            [EnumMember(Value = "MANAGEDCLIENT")]
            MANAGEDCLIENT = 5,

            /// <summary>
            /// Enum CASHBOOKCLIENT for value: CASHBOOKCLIENT
            /// </summary>
            [EnumMember(Value = "CASHBOOKCLIENT")]
            CASHBOOKCLIENT = 6,

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 7

        }

        /// <summary>
        /// User role that defines permissions in Xero and via API (READONLY, INVOICEONLY, STANDARD, FINANCIALADVISER, etc)
        /// </summary>
        /// <value>User role that defines permissions in Xero and via API (READONLY, INVOICEONLY, STANDARD, FINANCIALADVISER, etc)</value>
        [DataMember(Name="OrganisationRole", EmitDefaultValue=false)]
        public OrganisationRoleEnum OrganisationRole { get; set; }
        
        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="UserID", EmitDefaultValue=false)]
        public Guid? UserID { get; set; }

        /// <summary>
        /// Email address of user
        /// </summary>
        /// <value>Email address of user</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// First name of user
        /// </summary>
        /// <value>First name of user</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of user
        /// </summary>
        /// <value>Last name of user</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Timestamp of last change to user
        /// </summary>
        /// <value>Timestamp of last change to user</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Boolean to indicate if user is the subscriber
        /// </summary>
        /// <value>Boolean to indicate if user is the subscriber</value>
        [DataMember(Name="IsSubscriber", EmitDefaultValue=false)]
        public bool? IsSubscriber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  IsSubscriber: ").Append(IsSubscriber).Append("\n");
            sb.Append("  OrganisationRole: ").Append(OrganisationRole).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserID == input.UserID ||
                    (this.UserID != null &&
                    this.UserID.Equals(input.UserID))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
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
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.IsSubscriber == input.IsSubscriber ||
                    (this.IsSubscriber != null &&
                    this.IsSubscriber.Equals(input.IsSubscriber))
                ) && 
                (
                    this.OrganisationRole == input.OrganisationRole ||
                    this.OrganisationRole.Equals(input.OrganisationRole)
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
                if (this.UserID != null)
                    hashCode = hashCode * 59 + this.UserID.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.IsSubscriber != null)
                    hashCode = hashCode * 59 + this.IsSubscriber.GetHashCode();
                hashCode = hashCode * 59 + this.OrganisationRole.GetHashCode();
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
