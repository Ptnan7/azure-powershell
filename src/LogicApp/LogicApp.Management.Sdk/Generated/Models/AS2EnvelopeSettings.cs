// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The AS2 agreement envelope settings.
    /// </summary>
    public partial class AS2EnvelopeSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2EnvelopeSettings class.
        /// </summary>
        public AS2EnvelopeSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AS2EnvelopeSettings class.
        /// </summary>

        /// <param name="messageContentType">The message content type.
        /// </param>

        /// <param name="transmitFileNameInMimeHeader">The value indicating whether to transmit file name in mime header.
        /// </param>

        /// <param name="fileNameTemplate">The template for file name.
        /// </param>

        /// <param name="suspendMessageOnFileNameGenerationError">The value indicating whether to suspend message on file name generation
        /// error.
        /// </param>

        /// <param name="autogenerateFileName">The value indicating whether to auto generate file name.
        /// </param>
        public AS2EnvelopeSettings(string messageContentType, bool transmitFileNameInMimeHeader, string fileNameTemplate, bool suspendMessageOnFileNameGenerationError, bool autogenerateFileName)

        {
            this.MessageContentType = messageContentType;
            this.TransmitFileNameInMimeHeader = transmitFileNameInMimeHeader;
            this.FileNameTemplate = fileNameTemplate;
            this.SuspendMessageOnFileNameGenerationError = suspendMessageOnFileNameGenerationError;
            this.AutogenerateFileName = autogenerateFileName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the message content type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "messageContentType")]
        public string MessageContentType {get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to transmit file name in mime
        /// header.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "transmitFileNameInMimeHeader")]
        public bool TransmitFileNameInMimeHeader {get; set; }

        /// <summary>
        /// Gets or sets the template for file name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileNameTemplate")]
        public string FileNameTemplate {get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to suspend message on file name
        /// generation error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "suspendMessageOnFileNameGenerationError")]
        public bool SuspendMessageOnFileNameGenerationError {get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to auto generate file name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autogenerateFileName")]
        public bool AutogenerateFileName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.MessageContentType == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "MessageContentType");
            }
            if (this.FileNameTemplate == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "FileNameTemplate");
            }


        }
    }
}