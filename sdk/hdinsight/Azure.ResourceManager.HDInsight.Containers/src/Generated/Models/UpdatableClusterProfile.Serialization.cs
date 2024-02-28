// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class UpdatableClusterProfile : IUtf8JsonSerializable, IJsonModel<UpdatableClusterProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdatableClusterProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdatableClusterProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ServiceConfigsProfiles is ChangeTrackingList<ClusterServiceConfigsProfile> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("serviceConfigsProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceConfigsProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SshProfile != null)
            {
                writer.WritePropertyName("sshProfile"u8);
                writer.WriteObjectValue(SshProfile);
            }
            if (AutoscaleProfile != null)
            {
                writer.WritePropertyName("autoscaleProfile"u8);
                writer.WriteObjectValue(AutoscaleProfile);
            }
            if (AuthorizationProfile != null)
            {
                writer.WritePropertyName("authorizationProfile"u8);
                writer.WriteObjectValue(AuthorizationProfile);
            }
            if (LogAnalyticsProfile != null)
            {
                writer.WritePropertyName("logAnalyticsProfile"u8);
                writer.WriteObjectValue(LogAnalyticsProfile);
            }
            if (PrometheusProfile != null)
            {
                writer.WritePropertyName("prometheusProfile"u8);
                writer.WriteObjectValue(PrometheusProfile);
            }
            if (RangerPluginProfile != null)
            {
                writer.WritePropertyName("rangerPluginProfile"u8);
                writer.WriteObjectValue(RangerPluginProfile);
            }
            if (RangerProfile != null)
            {
                writer.WritePropertyName("rangerProfile"u8);
                writer.WriteObjectValue(RangerProfile);
            }
            if (!(ScriptActionProfiles is ChangeTrackingList<ScriptActionProfile> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("scriptActionProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScriptActionProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        UpdatableClusterProfile IJsonModel<UpdatableClusterProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdatableClusterProfile(document.RootElement, options);
        }

        internal static UpdatableClusterProfile DeserializeUpdatableClusterProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ClusterServiceConfigsProfile> serviceConfigsProfiles = default;
            ClusterSshProfile sshProfile = default;
            ClusterAutoscaleProfile autoscaleProfile = default;
            AuthorizationProfile authorizationProfile = default;
            ClusterLogAnalyticsProfile logAnalyticsProfile = default;
            ClusterPrometheusProfile prometheusProfile = default;
            ClusterRangerPluginProfile rangerPluginProfile = default;
            RangerProfile rangerProfile = default;
            IList<ScriptActionProfile> scriptActionProfiles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceConfigsProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServiceConfigsProfile> array = new List<ClusterServiceConfigsProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServiceConfigsProfile.DeserializeClusterServiceConfigsProfile(item, options));
                    }
                    serviceConfigsProfiles = array;
                    continue;
                }
                if (property.NameEquals("sshProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshProfile = ClusterSshProfile.DeserializeClusterSshProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("autoscaleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleProfile = ClusterAutoscaleProfile.DeserializeClusterAutoscaleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authorizationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationProfile = AuthorizationProfile.DeserializeAuthorizationProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logAnalyticsProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logAnalyticsProfile = ClusterLogAnalyticsProfile.DeserializeClusterLogAnalyticsProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("prometheusProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusProfile = ClusterPrometheusProfile.DeserializeClusterPrometheusProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rangerPluginProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rangerPluginProfile = ClusterRangerPluginProfile.DeserializeClusterRangerPluginProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rangerProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rangerProfile = RangerProfile.DeserializeRangerProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scriptActionProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScriptActionProfile> array = new List<ScriptActionProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScriptActionProfile.DeserializeScriptActionProfile(item, options));
                    }
                    scriptActionProfiles = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdatableClusterProfile(
                serviceConfigsProfiles ?? new ChangeTrackingList<ClusterServiceConfigsProfile>(),
                sshProfile,
                autoscaleProfile,
                authorizationProfile,
                logAnalyticsProfile,
                prometheusProfile,
                rangerPluginProfile,
                rangerProfile,
                scriptActionProfiles ?? new ChangeTrackingList<ScriptActionProfile>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdatableClusterProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support '{options.Format}' format.");
            }
        }

        UpdatableClusterProfile IPersistableModel<UpdatableClusterProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdatableClusterProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdatableClusterProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdatableClusterProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdatableClusterProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
