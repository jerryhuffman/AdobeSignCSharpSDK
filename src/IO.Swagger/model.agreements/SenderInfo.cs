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
    /// SenderInfo
    /// </summary>
    [DataContract]
    public partial class SenderInfo :  IEquatable<SenderInfo>, IValidatableObject
    {
        /// <summary>
        /// The agreement status with respect to the participant set. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>The agreement status with respect to the participant set. This cannot be changed as part of the PUT call.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 1,
            
            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 2,
            
            /// <summary>
            /// Enum EXPIRED for value: EXPIRED
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED = 3,
            
            /// <summary>
            /// Enum NOTYETVISIBLE for value: NOT_YET_VISIBLE
            /// </summary>
            [EnumMember(Value = "NOT_YET_VISIBLE")]
            NOTYETVISIBLE = 4,
            
            /// <summary>
            /// Enum WAITINGFORAUTHORING for value: WAITING_FOR_AUTHORING
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_AUTHORING")]
            WAITINGFORAUTHORING = 5,
            
            /// <summary>
            /// Enum WAITINGFORMYDELEGATION for value: WAITING_FOR_MY_DELEGATION
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_DELEGATION")]
            WAITINGFORMYDELEGATION = 6,
            
            /// <summary>
            /// Enum WAITINGFORMYACCEPTANCE for value: WAITING_FOR_MY_ACCEPTANCE
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_ACCEPTANCE")]
            WAITINGFORMYACCEPTANCE = 7,
            
            /// <summary>
            /// Enum WAITINGFORMYACKNOWLEDGEMENT for value: WAITING_FOR_MY_ACKNOWLEDGEMENT
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_ACKNOWLEDGEMENT")]
            WAITINGFORMYACKNOWLEDGEMENT = 8,
            
            /// <summary>
            /// Enum WAITINGFORMYAPPROVAL for value: WAITING_FOR_MY_APPROVAL
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_APPROVAL")]
            WAITINGFORMYAPPROVAL = 9,
            
            /// <summary>
            /// Enum WAITINGFORMYFORMFILLING for value: WAITING_FOR_MY_FORM_FILLING
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_FORM_FILLING")]
            WAITINGFORMYFORMFILLING = 10,
            
            /// <summary>
            /// Enum WAITINGFORMYSIGNATURE for value: WAITING_FOR_MY_SIGNATURE
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_MY_SIGNATURE")]
            WAITINGFORMYSIGNATURE = 11,
            
            /// <summary>
            /// Enum WAITINGFOROTHERS for value: WAITING_FOR_OTHERS
            /// </summary>
            [EnumMember(Value = "WAITING_FOR_OTHERS")]
            WAITINGFOROTHERS = 12
        }

        /// <summary>
        /// The agreement status with respect to the participant set. This cannot be changed as part of the PUT call.
        /// </summary>
        /// <value>The agreement status with respect to the participant set. This cannot be changed as part of the PUT call.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderInfo" /> class.
        /// </summary>
        /// <param name="Company">Company of the sender, if available..</param>
        /// <param name="Email">Email of the sender of the agreement..</param>
        /// <param name="Name">Name of the sender, if available..</param>
        /// <param name="ParticipantId"> The unique identifier of the sender of the agreement..</param>
        /// <param name="Self">True if the sender is the same user that is calling the API..</param>
        /// <param name="Status">The agreement status with respect to the participant set. This cannot be changed as part of the PUT call..</param>
        public SenderInfo(string Company = default(string), string Email = default(string), string Name = default(string), string ParticipantId = default(string), bool? Self = default(bool?), StatusEnum? Status = default(StatusEnum?))
        {
            this.Company = Company;
            this.Email = Email;
            this.Name = Name;
            this.ParticipantId = ParticipantId;
            this.Self = Self;
            this.Status = Status;
        }
        
        /// <summary>
        /// Company of the sender, if available.
        /// </summary>
        /// <value>Company of the sender, if available.</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Email of the sender of the agreement.
        /// </summary>
        /// <value>Email of the sender of the agreement.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Name of the sender, if available.
        /// </summary>
        /// <value>Name of the sender, if available.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        ///  The unique identifier of the sender of the agreement.
        /// </summary>
        /// <value> The unique identifier of the sender of the agreement.</value>
        [DataMember(Name="participantId", EmitDefaultValue=false)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// True if the sender is the same user that is calling the API.
        /// </summary>
        /// <value>True if the sender is the same user that is calling the API.</value>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public bool? Self { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SenderInfo {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SenderInfo);
        }

        /// <summary>
        /// Returns true if SenderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SenderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SenderInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParticipantId == input.ParticipantId ||
                    (this.ParticipantId != null &&
                    this.ParticipantId.Equals(input.ParticipantId))
                ) && 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParticipantId != null)
                    hashCode = hashCode * 59 + this.ParticipantId.GetHashCode();
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
