// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Extensions;

    /// <summary>Information of backup set</summary>
    public partial class SqlBackupSetInfo
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.ISqlBackupSetInfo.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.ISqlBackupSetInfo.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.ISqlBackupSetInfo FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json ? new SqlBackupSetInfo(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject into a new instance of <see cref="SqlBackupSetInfo" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SqlBackupSetInfo(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_backupSetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("backupSetId"), out var __jsonBackupSetId) ? (string)__jsonBackupSetId : (string)BackupSetId;}
            {_firstLsn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("firstLSN"), out var __jsonFirstLsn) ? (string)__jsonFirstLsn : (string)FirstLsn;}
            {_lastLsn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("lastLSN"), out var __jsonLastLsn) ? (string)__jsonLastLsn : (string)LastLsn;}
            {_backupType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("backupType"), out var __jsonBackupType) ? (string)__jsonBackupType : (string)BackupType;}
            {_listOfBackupFile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonArray>("listOfBackupFiles"), out var __jsonListOfBackupFiles) ? If( __jsonListOfBackupFiles as Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.ISqlBackupFileInfo[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.ISqlBackupFileInfo) (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Models.Api20250315Preview.SqlBackupFileInfo.FromJson(__u) )) ))() : null : ListOfBackupFile;}
            {_backupStartDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("backupStartDate"), out var __jsonBackupStartDate) ? global::System.DateTime.TryParse((string)__jsonBackupStartDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonBackupStartDateValue) ? __jsonBackupStartDateValue : BackupStartDate : BackupStartDate;}
            {_backupFinishDate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString>("backupFinishDate"), out var __jsonBackupFinishDate) ? global::System.DateTime.TryParse((string)__jsonBackupFinishDate, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonBackupFinishDateValue) ? __jsonBackupFinishDateValue : BackupFinishDate : BackupFinishDate;}
            {_isBackupRestored = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonBoolean>("isBackupRestored"), out var __jsonIsBackupRestored) ? (bool?)__jsonIsBackupRestored : IsBackupRestored;}
            {_hasBackupChecksum = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonBoolean>("hasBackupChecksums"), out var __jsonHasBackupChecksums) ? (bool?)__jsonHasBackupChecksums : HasBackupChecksum;}
            {_familyCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNumber>("familyCount"), out var __jsonFamilyCount) ? (int?)__jsonFamilyCount : FamilyCount;}
            {_ignoreReason = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonArray>("ignoreReasons"), out var __jsonIgnoreReasons) ? If( __jsonIgnoreReasons as Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : IgnoreReason;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SqlBackupSetInfo" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SqlBackupSetInfo" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._backupSetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._backupSetId.ToString()) : null, "backupSetId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._firstLsn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._firstLsn.ToString()) : null, "firstLSN" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._lastLsn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._lastLsn.ToString()) : null, "lastLSN" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._backupType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._backupType.ToString()) : null, "backupType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._listOfBackupFile)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.XNodeArray();
                    foreach( var __x in this._listOfBackupFile )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("listOfBackupFiles",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._backupStartDate ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._backupStartDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "backupStartDate" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._backupFinishDate ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(this._backupFinishDate?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "backupFinishDate" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._isBackupRestored ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonBoolean((bool)this._isBackupRestored) : null, "isBackupRestored" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._hasBackupChecksum ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonBoolean((bool)this._hasBackupChecksum) : null, "hasBackupChecksums" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._familyCount ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNumber((int)this._familyCount) : null, "familyCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._ignoreReason)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.XNodeArray();
                    foreach( var __s in this._ignoreReason )
                    {
                        AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DataMigration.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                    }
                    container.Add("ignoreReasons",__r);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}