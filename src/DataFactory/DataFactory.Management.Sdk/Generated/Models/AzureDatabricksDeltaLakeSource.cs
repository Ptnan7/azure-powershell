// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// A copy activity Azure Databricks Delta Lake source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDatabricksDeltaLakeSource")]
    public partial class AzureDatabricksDeltaLakeSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the AzureDatabricksDeltaLakeSource class.
        /// </summary>
        public AzureDatabricksDeltaLakeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureDatabricksDeltaLakeSource class.
        /// </summary>

        /// <param name="additionalProperties">A copy activity source.
        /// </param>

        /// <param name="sourceRetryCount">Source retry count. Type: integer (or Expression with resultType integer).
        /// </param>

        /// <param name="sourceRetryWait">Source retry wait. Type: string (or Expression with resultType string),
        /// pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </param>

        /// <param name="maxConcurrentConnections">The maximum concurrent connection count for the source data store. Type:
        /// integer (or Expression with resultType integer).
        /// </param>

        /// <param name="disableMetricsCollection">If true, disable data store metrics collection. Default is false. Type:
        /// boolean (or Expression with resultType boolean).
        /// </param>

        /// <param name="query">Azure Databricks Delta Lake Sql query. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="exportSettings">Azure Databricks Delta Lake export settings.
        /// </param>
        public AzureDatabricksDeltaLakeSource(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object disableMetricsCollection = default(object), object query = default(object), AzureDatabricksDeltaLakeExportCommand exportSettings = default(AzureDatabricksDeltaLakeExportCommand))

        : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection)
        {
            this.Query = query;
            this.ExportSettings = exportSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets azure Databricks Delta Lake Sql query. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "query")]
        public object Query {get; set; }

        /// <summary>
        /// Gets or sets azure Databricks Delta Lake export settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exportSettings")]
        public AzureDatabricksDeltaLakeExportCommand ExportSettings {get; set; }
    }
}