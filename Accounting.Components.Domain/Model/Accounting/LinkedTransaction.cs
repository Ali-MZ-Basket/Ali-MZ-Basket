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
    /// LinkedTransaction
    /// </summary>
    [DataContract]
    public partial class LinkedTransaction :  IEquatable<LinkedTransaction>, IValidatableObject
    {
        /// <summary>
        /// Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED.
        /// </summary>
        /// <value>Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED.</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum APPROVED for value: APPROVED
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED = 1,

            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 2,

            /// <summary>
            /// Enum ONDRAFT for value: ONDRAFT
            /// </summary>
            [EnumMember(Value = "ONDRAFT")]
            ONDRAFT = 3,

            /// <summary>
            /// Enum BILLED for value: BILLED
            /// </summary>
            [EnumMember(Value = "BILLED")]
            BILLED = 4,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 5

        }

        /// <summary>
        /// Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED.
        /// </summary>
        /// <value>Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// This will always be BILLABLEEXPENSE. More types may be added in future.
        /// </summary>
        /// <value>This will always be BILLABLEEXPENSE. More types may be added in future.</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BILLABLEEXPENSE for value: BILLABLEEXPENSE
            /// </summary>
            [EnumMember(Value = "BILLABLEEXPENSE")]
            BILLABLEEXPENSE = 1

        }

        /// <summary>
        /// This will always be BILLABLEEXPENSE. More types may be added in future.
        /// </summary>
        /// <value>This will always be BILLABLEEXPENSE. More types may be added in future.</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// The Type of the source tranasction. This will be ACCPAY if the linked transaction was created from an invoice and SPEND if it was created from a bank transaction.
        /// </summary>
        /// <value>The Type of the source tranasction. This will be ACCPAY if the linked transaction was created from an invoice and SPEND if it was created from a bank transaction.</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum SourceTransactionTypeCodeEnum
        {
            /// <summary>
            /// Enum ACCPAY for value: ACCPAY
            /// </summary>
            [EnumMember(Value = "ACCPAY")]
            ACCPAY = 1,

            /// <summary>
            /// Enum SPEND for value: SPEND
            /// </summary>
            [EnumMember(Value = "SPEND")]
            SPEND = 2

        }

        /// <summary>
        /// The Type of the source tranasction. This will be ACCPAY if the linked transaction was created from an invoice and SPEND if it was created from a bank transaction.
        /// </summary>
        /// <value>The Type of the source tranasction. This will be ACCPAY if the linked transaction was created from an invoice and SPEND if it was created from a bank transaction.</value>
        [DataMember(Name="SourceTransactionTypeCode", EmitDefaultValue=false)]
        public SourceTransactionTypeCodeEnum SourceTransactionTypeCode { get; set; }
        
        /// <summary>
        /// Filter by the SourceTransactionID. Get all the linked transactions created from a particular ACCPAY invoice
        /// </summary>
        /// <value>Filter by the SourceTransactionID. Get all the linked transactions created from a particular ACCPAY invoice</value>
        [DataMember(Name="SourceTransactionID", EmitDefaultValue=false)]
        public Guid? SourceTransactionID { get; set; }

        /// <summary>
        /// The line item identifier from the source transaction.
        /// </summary>
        /// <value>The line item identifier from the source transaction.</value>
        [DataMember(Name="SourceLineItemID", EmitDefaultValue=false)]
        public Guid? SourceLineItemID { get; set; }

        /// <summary>
        /// Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED.
        /// </summary>
        /// <value>Filter by the combination of ContactID and Status. Get all the linked transactions that have been assigned to a particular customer and have a particular status e.g. GET /LinkedTransactions?ContactID&#x3D;4bb34b03-3378-4bb2-a0ed-6345abf3224e&amp;Status&#x3D;APPROVED.</value>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public Guid? ContactID { get; set; }

        /// <summary>
        /// Filter by the TargetTransactionID. Get all the linked transactions  allocated to a particular ACCREC invoice
        /// </summary>
        /// <value>Filter by the TargetTransactionID. Get all the linked transactions  allocated to a particular ACCREC invoice</value>
        [DataMember(Name="TargetTransactionID", EmitDefaultValue=false)]
        public Guid? TargetTransactionID { get; set; }

        /// <summary>
        /// The line item identifier from the target transaction. It is possible  to link multiple billable expenses to the same TargetLineItemID.
        /// </summary>
        /// <value>The line item identifier from the target transaction. It is possible  to link multiple billable expenses to the same TargetLineItemID.</value>
        [DataMember(Name="TargetLineItemID", EmitDefaultValue=false)]
        public Guid? TargetLineItemID { get; set; }

        /// <summary>
        /// The Xero identifier for an Linked Transaction e.g./LinkedTransactions/297c2dc5-cc47-4afd-8ec8-74990b8761e9
        /// </summary>
        /// <value>The Xero identifier for an Linked Transaction e.g./LinkedTransactions/297c2dc5-cc47-4afd-8ec8-74990b8761e9</value>
        [DataMember(Name="LinkedTransactionID", EmitDefaultValue=false)]
        public Guid? LinkedTransactionID { get; set; }

        /// <summary>
        /// The last modified date in UTC format
        /// </summary>
        /// <value>The last modified date in UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkedTransaction {\n");
            sb.Append("  SourceTransactionID: ").Append(SourceTransactionID).Append("\n");
            sb.Append("  SourceLineItemID: ").Append(SourceLineItemID).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  TargetTransactionID: ").Append(TargetTransactionID).Append("\n");
            sb.Append("  TargetLineItemID: ").Append(TargetLineItemID).Append("\n");
            sb.Append("  LinkedTransactionID: ").Append(LinkedTransactionID).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  SourceTransactionTypeCode: ").Append(SourceTransactionTypeCode).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as LinkedTransaction);
        }

        /// <summary>
        /// Returns true if LinkedTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkedTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkedTransaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceTransactionID == input.SourceTransactionID ||
                    (this.SourceTransactionID != null &&
                    this.SourceTransactionID.Equals(input.SourceTransactionID))
                ) && 
                (
                    this.SourceLineItemID == input.SourceLineItemID ||
                    (this.SourceLineItemID != null &&
                    this.SourceLineItemID.Equals(input.SourceLineItemID))
                ) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && 
                (
                    this.TargetTransactionID == input.TargetTransactionID ||
                    (this.TargetTransactionID != null &&
                    this.TargetTransactionID.Equals(input.TargetTransactionID))
                ) && 
                (
                    this.TargetLineItemID == input.TargetLineItemID ||
                    (this.TargetLineItemID != null &&
                    this.TargetLineItemID.Equals(input.TargetLineItemID))
                ) && 
                (
                    this.LinkedTransactionID == input.LinkedTransactionID ||
                    (this.LinkedTransactionID != null &&
                    this.LinkedTransactionID.Equals(input.LinkedTransactionID))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.SourceTransactionTypeCode == input.SourceTransactionTypeCode ||
                    this.SourceTransactionTypeCode.Equals(input.SourceTransactionTypeCode)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.SourceTransactionID != null)
                    hashCode = hashCode * 59 + this.SourceTransactionID.GetHashCode();
                if (this.SourceLineItemID != null)
                    hashCode = hashCode * 59 + this.SourceLineItemID.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.TargetTransactionID != null)
                    hashCode = hashCode * 59 + this.TargetTransactionID.GetHashCode();
                if (this.TargetLineItemID != null)
                    hashCode = hashCode * 59 + this.TargetLineItemID.GetHashCode();
                if (this.LinkedTransactionID != null)
                    hashCode = hashCode * 59 + this.LinkedTransactionID.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.SourceTransactionTypeCode.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
