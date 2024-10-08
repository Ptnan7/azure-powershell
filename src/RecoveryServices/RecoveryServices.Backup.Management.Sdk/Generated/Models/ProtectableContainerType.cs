// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{

    /// <summary>
    /// Defines values for ProtectableContainerType.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProtectableContainerType
    {
        [System.Runtime.Serialization.EnumMember(Value = "Invalid")]
        Invalid,
        [System.Runtime.Serialization.EnumMember(Value = "Unknown")]
        Unknown,
        [System.Runtime.Serialization.EnumMember(Value = "IaasVMContainer")]
        IaasVMContainer,
        [System.Runtime.Serialization.EnumMember(Value = "IaasVMServiceContainer")]
        IaasVMServiceContainer,
        [System.Runtime.Serialization.EnumMember(Value = "DPMContainer")]
        DPMContainer,
        [System.Runtime.Serialization.EnumMember(Value = "AzureBackupServerContainer")]
        AzureBackupServerContainer,
        [System.Runtime.Serialization.EnumMember(Value = "MABContainer")]
        MABContainer,
        [System.Runtime.Serialization.EnumMember(Value = "Cluster")]
        Cluster,
        [System.Runtime.Serialization.EnumMember(Value = "AzureSqlContainer")]
        AzureSqlContainer,
        [System.Runtime.Serialization.EnumMember(Value = "Windows")]
        Windows,
        [System.Runtime.Serialization.EnumMember(Value = "VCenter")]
        VCenter,
        [System.Runtime.Serialization.EnumMember(Value = "VMAppContainer")]
        VMAppContainer,
        [System.Runtime.Serialization.EnumMember(Value = "SQLAGWorkLoadContainer")]
        SqlagWorkLoadContainer,
        [System.Runtime.Serialization.EnumMember(Value = "StorageContainer")]
        StorageContainer,
        [System.Runtime.Serialization.EnumMember(Value = "GenericContainer")]
        GenericContainer,
        [System.Runtime.Serialization.EnumMember(Value = "Microsoft.ClassicCompute/virtualMachines")]
        MicrosoftClassicComputeVirtualMachines,
        [System.Runtime.Serialization.EnumMember(Value = "Microsoft.Compute/virtualMachines")]
        MicrosoftComputeVirtualMachines,
        [System.Runtime.Serialization.EnumMember(Value = "AzureWorkloadContainer")]
        AzureWorkloadContainer
    }
    internal static class ProtectableContainerTypeEnumExtension
    {
        internal static string ToSerializedValue(this ProtectableContainerType? value)
        {
            return value == null ? null : ((ProtectableContainerType)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this ProtectableContainerType value)
        {
            switch( value )
            {
                case ProtectableContainerType.Invalid:
                    return "Invalid";
                case ProtectableContainerType.Unknown:
                    return "Unknown";
                case ProtectableContainerType.IaasVMContainer:
                    return "IaasVMContainer";
                case ProtectableContainerType.IaasVMServiceContainer:
                    return "IaasVMServiceContainer";
                case ProtectableContainerType.DPMContainer:
                    return "DPMContainer";
                case ProtectableContainerType.AzureBackupServerContainer:
                    return "AzureBackupServerContainer";
                case ProtectableContainerType.MABContainer:
                    return "MABContainer";
                case ProtectableContainerType.Cluster:
                    return "Cluster";
                case ProtectableContainerType.AzureSqlContainer:
                    return "AzureSqlContainer";
                case ProtectableContainerType.Windows:
                    return "Windows";
                case ProtectableContainerType.VCenter:
                    return "VCenter";
                case ProtectableContainerType.VMAppContainer:
                    return "VMAppContainer";
                case ProtectableContainerType.SqlagWorkLoadContainer:
                    return "SQLAGWorkLoadContainer";
                case ProtectableContainerType.StorageContainer:
                    return "StorageContainer";
                case ProtectableContainerType.GenericContainer:
                    return "GenericContainer";
                case ProtectableContainerType.MicrosoftClassicComputeVirtualMachines:
                    return "Microsoft.ClassicCompute/virtualMachines";
                case ProtectableContainerType.MicrosoftComputeVirtualMachines:
                    return "Microsoft.Compute/virtualMachines";
                case ProtectableContainerType.AzureWorkloadContainer:
                    return "AzureWorkloadContainer";
            }
            return null;
        }
        internal static ProtectableContainerType? ParseProtectableContainerType(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return ProtectableContainerType.Invalid;
                case "Unknown":
                    return ProtectableContainerType.Unknown;
                case "IaasVMContainer":
                    return ProtectableContainerType.IaasVMContainer;
                case "IaasVMServiceContainer":
                    return ProtectableContainerType.IaasVMServiceContainer;
                case "DPMContainer":
                    return ProtectableContainerType.DPMContainer;
                case "AzureBackupServerContainer":
                    return ProtectableContainerType.AzureBackupServerContainer;
                case "MABContainer":
                    return ProtectableContainerType.MABContainer;
                case "Cluster":
                    return ProtectableContainerType.Cluster;
                case "AzureSqlContainer":
                    return ProtectableContainerType.AzureSqlContainer;
                case "Windows":
                    return ProtectableContainerType.Windows;
                case "VCenter":
                    return ProtectableContainerType.VCenter;
                case "VMAppContainer":
                    return ProtectableContainerType.VMAppContainer;
                case "SQLAGWorkLoadContainer":
                    return ProtectableContainerType.SqlagWorkLoadContainer;
                case "StorageContainer":
                    return ProtectableContainerType.StorageContainer;
                case "GenericContainer":
                    return ProtectableContainerType.GenericContainer;
                case "Microsoft.ClassicCompute/virtualMachines":
                    return ProtectableContainerType.MicrosoftClassicComputeVirtualMachines;
                case "Microsoft.Compute/virtualMachines":
                    return ProtectableContainerType.MicrosoftComputeVirtualMachines;
                case "AzureWorkloadContainer":
                    return ProtectableContainerType.AzureWorkloadContainer;
            }
            return null;
        }
    }
}