// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support
{

    /// <summary>
    /// The scope for the virtual machine affinity or anti-affinity placement hint. It should always be "Machine" in the case
    /// of node affinity.
    /// </summary>
    public partial struct VirtualMachinePlacementHintPodAffinityScope :
        System.IEquatable<VirtualMachinePlacementHintPodAffinityScope>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope Machine = @"Machine";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope Rack = @"Rack";

        /// <summary>
        /// the value for an instance of the <see cref="VirtualMachinePlacementHintPodAffinityScope" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to VirtualMachinePlacementHintPodAffinityScope</summary>
        /// <param name="value">the value to convert to an instance of <see cref="VirtualMachinePlacementHintPodAffinityScope" />.</param>
        internal static object CreateFrom(object value)
        {
            return new VirtualMachinePlacementHintPodAffinityScope(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type VirtualMachinePlacementHintPodAffinityScope</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type VirtualMachinePlacementHintPodAffinityScope (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is VirtualMachinePlacementHintPodAffinityScope && Equals((VirtualMachinePlacementHintPodAffinityScope)obj);
        }

        /// <summary>Returns hashCode for enum VirtualMachinePlacementHintPodAffinityScope</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for VirtualMachinePlacementHintPodAffinityScope</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Creates an instance of the <see cref="VirtualMachinePlacementHintPodAffinityScope"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private VirtualMachinePlacementHintPodAffinityScope(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>
        /// Implicit operator to convert string to VirtualMachinePlacementHintPodAffinityScope
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="VirtualMachinePlacementHintPodAffinityScope" />.</param>

        public static implicit operator VirtualMachinePlacementHintPodAffinityScope(string value)
        {
            return new VirtualMachinePlacementHintPodAffinityScope(value);
        }

        /// <summary>
        /// Implicit operator to convert VirtualMachinePlacementHintPodAffinityScope to string
        /// </summary>
        /// <param name="e">the value to convert to an instance of <see cref="VirtualMachinePlacementHintPodAffinityScope" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum VirtualMachinePlacementHintPodAffinityScope</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope e1, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum VirtualMachinePlacementHintPodAffinityScope</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope e1, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.VirtualMachinePlacementHintPodAffinityScope e2)
        {
            return e2.Equals(e1);
        }
    }
}