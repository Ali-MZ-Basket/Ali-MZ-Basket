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
    /// PurchaseOrders
    /// </summary>
    [DataContract]
    public partial class PurchaseOrders :  IEquatable<PurchaseOrders>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _PurchaseOrders
        /// </summary>
        [DataMember(Name="PurchaseOrders", EmitDefaultValue=false)]
        public List<PurchaseOrder> _PurchaseOrders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseOrders {\n");
            sb.Append("  _PurchaseOrders: ").Append(_PurchaseOrders).Append("\n");
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
            return this.Equals(input as PurchaseOrders);
        }

        /// <summary>
        /// Returns true if PurchaseOrders instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrders input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._PurchaseOrders == input._PurchaseOrders ||
                    this._PurchaseOrders != null &&
                    input._PurchaseOrders != null &&
                    this._PurchaseOrders.SequenceEqual(input._PurchaseOrders)
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
                if (this._PurchaseOrders != null)
                    hashCode = hashCode * 59 + this._PurchaseOrders.GetHashCode();
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
