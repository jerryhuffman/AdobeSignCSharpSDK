/**
*  Copyright 2019 Adobe Systems Incorporated. All rights reserved.
*  This file is licensed to you under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License. You may obtain a copy
*  of the License at http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software distributed under
*  the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
*  OF ANY KIND, either express or implied. See the License for the specific language
*  governing permissions and limitations under the License.
*
*
**/


/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 6.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.model.agreements
{
    /// <summary>
    /// AgreementDocumentImageUrlsInfo
    /// </summary>
    [DataContract]
    public partial class AgreementDocumentImageUrlsInfo :  IEquatable<AgreementDocumentImageUrlsInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementDocumentImageUrlsInfo" /> class.
        /// </summary>
        /// <param name="DocumentId">Id of the document.</param>
        /// <param name="DocumentImageUrlsList">A list of documents image URLs..</param>
        public AgreementDocumentImageUrlsInfo(string DocumentId = default(string), List<DocumentImageUrls> DocumentImageUrlsList = default(List<DocumentImageUrls>))
        {
            this.DocumentId = DocumentId;
            this.DocumentImageUrlsList = DocumentImageUrlsList;
        }
        
        /// <summary>
        /// Id of the document
        /// </summary>
        /// <value>Id of the document</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// A list of documents image URLs.
        /// </summary>
        /// <value>A list of documents image URLs.</value>
        [DataMember(Name="documentImageUrlsList", EmitDefaultValue=false)]
        public List<DocumentImageUrls> DocumentImageUrlsList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgreementDocumentImageUrlsInfo {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentImageUrlsList: ").Append(DocumentImageUrlsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as AgreementDocumentImageUrlsInfo);
        }

        /// <summary>
        /// Returns true if AgreementDocumentImageUrlsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AgreementDocumentImageUrlsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgreementDocumentImageUrlsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.DocumentImageUrlsList == input.DocumentImageUrlsList ||
                    this.DocumentImageUrlsList != null &&
                    this.DocumentImageUrlsList.SequenceEqual(input.DocumentImageUrlsList)
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
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.DocumentImageUrlsList != null)
                    hashCode = hashCode * 59 + this.DocumentImageUrlsList.GetHashCode();
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
