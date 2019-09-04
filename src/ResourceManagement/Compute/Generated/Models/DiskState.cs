// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for DiskState.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<DiskState>))]
    public class DiskState : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<DiskState>
    {
        public static readonly DiskState Unattached = Parse("Unattached");
        public static readonly DiskState Attached = Parse("Attached");
        public static readonly DiskState Reserved = Parse("Reserved");
        public static readonly DiskState ActiveSAS = Parse("ActiveSAS");
        public static readonly DiskState ReadyToUpload = Parse("ReadyToUpload");
        public static readonly DiskState ActiveUpload = Parse("ActiveUpload");
    }
}