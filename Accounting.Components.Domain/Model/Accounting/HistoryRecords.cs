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
    /// HistoryRecords
    /// </summary>
    [DataContract]
    public partial class HistoryRecords :  IEquatable<HistoryRecords>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _HistoryRecords
        /// </summary>
        [DataMember(Name="HistoryRecords", EmitDefaultValue=false)]
        public List<HistoryRecord> _HistoryRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryRecords {\n");
            sb.Append("  _HistoryRecords: ").Append(_HistoryRecords).Append("\n");
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
            return this.Equals(input as HistoryRecords);
        }

        /// <summary>
        /// Returns true if HistoryRecords instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryRecords to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryRecords input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._HistoryRecords == input._HistoryRecords ||
                    this._HistoryRecords != null &&
                    input._HistoryRecords != null &&
                    this._HistoryRecords.SequenceEqual(input._HistoryRecords)
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
                if (this._HistoryRecords != null)
                    hashCode = hashCode * 59 + this._HistoryRecords.GetHashCode();
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
