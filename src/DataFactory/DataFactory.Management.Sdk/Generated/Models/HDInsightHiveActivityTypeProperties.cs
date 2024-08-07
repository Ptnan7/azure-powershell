// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// HDInsight Hive activity properties.
    /// </summary>
    public partial class HDInsightHiveActivityTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightHiveActivityTypeProperties class.
        /// </summary>
        public HDInsightHiveActivityTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightHiveActivityTypeProperties class.
        /// </summary>

        /// <param name="storageLinkedServices">Storage linked service references.
        /// </param>

        /// <param name="arguments">User specified arguments to HDInsightActivity.
        /// </param>

        /// <param name="getDebugInfo">Debug info option.
        /// Possible values include: &#39;None&#39;, &#39;Always&#39;, &#39;Failure&#39;</param>

        /// <param name="scriptPath">Script path. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="scriptLinkedService">Script linked service reference.
        /// </param>

        /// <param name="defines">Allows user to specify defines for Hive job request.
        /// </param>

        /// <param name="variables">User specified arguments under hivevar namespace.
        /// </param>

        /// <param name="queryTimeout">Query timeout value (in minutes).  Effective when the HDInsight cluster is
        /// with ESP (Enterprise Security Package)
        /// </param>
        public HDInsightHiveActivityTypeProperties(System.Collections.Generic.IList<LinkedServiceReference> storageLinkedServices = default(System.Collections.Generic.IList<LinkedServiceReference>), System.Collections.Generic.IList<object> arguments = default(System.Collections.Generic.IList<object>), string getDebugInfo = default(string), object scriptPath = default(object), LinkedServiceReference scriptLinkedService = default(LinkedServiceReference), System.Collections.Generic.IDictionary<string, object> defines = default(System.Collections.Generic.IDictionary<string, object>), System.Collections.Generic.IDictionary<string, object> variables = default(System.Collections.Generic.IDictionary<string, object>), int? queryTimeout = default(int?))

        {
            this.StorageLinkedServices = storageLinkedServices;
            this.Arguments = arguments;
            this.GetDebugInfo = getDebugInfo;
            this.ScriptPath = scriptPath;
            this.ScriptLinkedService = scriptLinkedService;
            this.Defines = defines;
            this.Variables = variables;
            this.QueryTimeout = queryTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageLinkedServices")]
        public System.Collections.Generic.IList<LinkedServiceReference> StorageLinkedServices {get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.IList<object> Arguments {get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: &#39;None&#39;, &#39;Always&#39;, &#39;Failure&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "getDebugInfo")]
        public string GetDebugInfo {get; set; }

        /// <summary>
        /// Gets or sets script path. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scriptPath")]
        public object ScriptPath {get; set; }

        /// <summary>
        /// Gets or sets script linked service reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scriptLinkedService")]
        public LinkedServiceReference ScriptLinkedService {get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for Hive job request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defines")]
        public System.Collections.Generic.IDictionary<string, object> Defines {get; set; }

        /// <summary>
        /// Gets or sets user specified arguments under hivevar namespace.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.IDictionary<string, object> Variables {get; set; }

        /// <summary>
        /// Gets or sets query timeout value (in minutes).  Effective when the
        /// HDInsight cluster is with ESP (Enterprise Security Package)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "queryTimeout")]
        public int? QueryTimeout {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StorageLinkedServices != null)
            {
                foreach (var element in this.StorageLinkedServices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }



            if (this.ScriptLinkedService != null)
            {
                this.ScriptLinkedService.Validate();
            }


        }
    }
}