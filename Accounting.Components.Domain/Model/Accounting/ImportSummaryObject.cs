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
    /// ImportSummaryObject
    /// </summary>
    [DataContract]
    public partial class ImportSummaryObject :  IEquatable<ImportSummaryObject>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets ImportSummary
        /// </summary>
        [DataMember(Name="ImportSummary", EmitDefaultValue=false)]
        public ImportSummary ImportSummary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportSummaryObject {\n");
            sb.Append("  ImportSummary: ").Append(ImportSummary).Append("\n");
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
            return this.Equals(input as ImportSummaryObject);
        }

        /// <summary>
        /// Returns true if ImportSummaryObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportSummaryObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportSummaryObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImportSummary == input.ImportSummary ||
                    (this.ImportSummary != null &&
                    this.ImportSummary.Equals(input.ImportSummary))
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
                if (this.ImportSummary != null)
                    hashCode = hashCode * 59 + this.ImportSummary.GetHashCode();
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
