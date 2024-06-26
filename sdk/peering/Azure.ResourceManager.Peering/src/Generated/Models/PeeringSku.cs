// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The SKU that defines the tier and kind of the peering. </summary>
    public partial class PeeringSku
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PeeringSku"/>. </summary>
        public PeeringSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeeringSku"/>. </summary>
        /// <param name="name"> The name of the peering SKU. </param>
        /// <param name="tier"> The tier of the peering SKU. </param>
        /// <param name="family"> The family of the peering SKU. </param>
        /// <param name="size"> The size of the peering SKU. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringSku(string name, PeeringTier? tier, PeeringFamily? family, PeeringSize? size, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Family = family;
            Size = size;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the peering SKU. </summary>
        public string Name { get; set; }
        /// <summary> The tier of the peering SKU. </summary>
        public PeeringTier? Tier { get; }
        /// <summary> The family of the peering SKU. </summary>
        public PeeringFamily? Family { get; }
        /// <summary> The size of the peering SKU. </summary>
        public PeeringSize? Size { get; }
    }
}
