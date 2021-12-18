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
    /// Prepayment
    /// </summary>
    [DataContract]
    public partial class Prepayment :  IEquatable<Prepayment>, IValidatableObject
    {
        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum RECEIVEPREPAYMENT for value: RECEIVE-PREPAYMENT
            /// </summary>
            [EnumMember(Value = "RECEIVE-PREPAYMENT")]
            RECEIVEPREPAYMENT = 1,

            /// <summary>
            /// Enum SPENDPREPAYMENT for value: SPEND-PREPAYMENT
            /// </summary>
            [EnumMember(Value = "SPEND-PREPAYMENT")]
            SPENDPREPAYMENT = 2,

            /// <summary>
            /// Enum ARPREPAYMENT for value: ARPREPAYMENT
            /// </summary>
            [EnumMember(Value = "ARPREPAYMENT")]
            ARPREPAYMENT = 3,

            /// <summary>
            /// Enum APPREPAYMENT for value: APPREPAYMENT
            /// </summary>
            [EnumMember(Value = "APPREPAYMENT")]
            APPREPAYMENT = 4

        }

        /// <summary>
        /// See Prepayment Types
        /// </summary>
        /// <value>See Prepayment Types</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// See Prepayment Status Codes
        /// </summary>
        /// <value>See Prepayment Status Codes</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 1,

            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 2,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 3

        }

        /// <summary>
        /// See Prepayment Status Codes
        /// </summary>
        /// <value>See Prepayment Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public LineAmountTypes LineAmountTypes { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The date the prepayment is created YYYY-MM-DD
        /// </summary>
        /// <value>The date the prepayment is created YYYY-MM-DD</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// See Prepayment Line Items
        /// </summary>
        /// <value>See Prepayment Line Items</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The subtotal of the prepayment excluding taxes
        /// </summary>
        /// <value>The subtotal of the prepayment excluding taxes</value>
        [DataMember(Name="SubTotal", EmitDefaultValue=false)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// The total tax on the prepayment
        /// </summary>
        /// <value>The total tax on the prepayment</value>
        [DataMember(Name="TotalTax", EmitDefaultValue=false)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// The total of the prepayment(subtotal + total tax)
        /// </summary>
        /// <value>The total of the prepayment(subtotal + total tax)</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Returns Invoice number field. Reference field isn&#39;t available.
        /// </summary>
        /// <value>Returns Invoice number field. Reference field isn&#39;t available.</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// UTC timestamp of last update to the prepayment
        /// </summary>
        /// <value>UTC timestamp of last update to the prepayment</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Xero generated unique identifier
        /// </summary>
        /// <value>Xero generated unique identifier</value>
        [DataMember(Name="PrepaymentID", EmitDefaultValue=false)]
        public Guid? PrepaymentID { get; set; }

        /// <summary>
        /// The currency rate for a multicurrency prepayment. If no rate is specified, the XE.com day rate is used
        /// </summary>
        /// <value>The currency rate for a multicurrency prepayment. If no rate is specified, the XE.com day rate is used</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// The remaining credit balance on the prepayment
        /// </summary>
        /// <value>The remaining credit balance on the prepayment</value>
        [DataMember(Name="RemainingCredit", EmitDefaultValue=false)]
        public decimal? RemainingCredit { get; set; }

        /// <summary>
        /// See Allocations
        /// </summary>
        /// <value>See Allocations</value>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<Allocation> Allocations { get; set; }

        /// <summary>
        /// See Payments
        /// </summary>
        /// <value>See Payments</value>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// The amount of applied to an invoice
        /// </summary>
        /// <value>The amount of applied to an invoice</value>
        [DataMember(Name="AppliedAmount", EmitDefaultValue=false)]
        public double? AppliedAmount { get; set; }

        /// <summary>
        /// boolean to indicate if a prepayment has an attachment
        /// </summary>
        /// <value>boolean to indicate if a prepayment has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// See Attachments
        /// </summary>
        /// <value>See Attachments</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Prepayment {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  PrepaymentID: ").Append(PrepaymentID).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  RemainingCredit: ").Append(RemainingCredit).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  AppliedAmount: ").Append(AppliedAmount).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as Prepayment);
        }

        /// <summary>
        /// Returns true if Prepayment instances are equal
        /// </summary>
        /// <param name="input">Instance of Prepayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Prepayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    (this.SubTotal != null &&
                    this.SubTotal.Equals(input.SubTotal))
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    (this.TotalTax != null &&
                    this.TotalTax.Equals(input.TotalTax))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.PrepaymentID == input.PrepaymentID ||
                    (this.PrepaymentID != null &&
                    this.PrepaymentID.Equals(input.PrepaymentID))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && 
                (
                    this.RemainingCredit == input.RemainingCredit ||
                    (this.RemainingCredit != null &&
                    this.RemainingCredit.Equals(input.RemainingCredit))
                ) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    input.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.AppliedAmount == input.AppliedAmount ||
                    (this.AppliedAmount != null &&
                    this.AppliedAmount.Equals(input.AppliedAmount))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    (this.HasAttachments != null &&
                    this.HasAttachments.Equals(input.HasAttachments))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.SubTotal != null)
                    hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                if (this.TotalTax != null)
                    hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.PrepaymentID != null)
                    hashCode = hashCode * 59 + this.PrepaymentID.GetHashCode();
                if (this.CurrencyRate != null)
                    hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                if (this.RemainingCredit != null)
                    hashCode = hashCode * 59 + this.RemainingCredit.GetHashCode();
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.AppliedAmount != null)
                    hashCode = hashCode * 59 + this.AppliedAmount.GetHashCode();
                if (this.HasAttachments != null)
                    hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
