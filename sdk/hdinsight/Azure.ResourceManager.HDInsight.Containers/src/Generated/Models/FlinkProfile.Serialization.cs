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
    public partial class FlinkProfile : IUtf8JsonSerializable, IJsonModel<FlinkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FlinkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FlinkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlinkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("storage"u8);
            writer.WriteObjectValue(Storage);
            if (NumReplicas.HasValue)
            {
                writer.WritePropertyName("numReplicas"u8);
                writer.WriteNumberValue(NumReplicas.Value);
            }
            writer.WritePropertyName("jobManager"u8);
            writer.WriteObjectValue(JobManager);
            if (HistoryServer != null)
            {
                writer.WritePropertyName("historyServer"u8);
                writer.WriteObjectValue(HistoryServer);
            }
            writer.WritePropertyName("taskManager"u8);
            writer.WriteObjectValue(TaskManager);
            if (CatalogOptions != null)
            {
                writer.WritePropertyName("catalogOptions"u8);
                writer.WriteObjectValue(CatalogOptions);
            }
            if (DeploymentMode.HasValue)
            {
                writer.WritePropertyName("deploymentMode"u8);
                writer.WriteStringValue(DeploymentMode.Value.ToString());
            }
            if (JobSpec != null)
            {
                writer.WritePropertyName("jobSpec"u8);
                writer.WriteObjectValue(JobSpec);
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

        FlinkProfile IJsonModel<FlinkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlinkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkProfile(document.RootElement, options);
        }

        internal static FlinkProfile DeserializeFlinkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FlinkStorageProfile storage = default;
            int? numReplicas = default;
            ComputeResourceRequirement jobManager = default;
            ComputeResourceRequirement historyServer = default;
            ComputeResourceRequirement taskManager = default;
            FlinkCatalogOptions catalogOptions = default;
            DeploymentMode? deploymentMode = default;
            FlinkJobProfile jobSpec = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storage"u8))
                {
                    storage = FlinkStorageProfile.DeserializeFlinkStorageProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("numReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("jobManager"u8))
                {
                    jobManager = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("historyServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    historyServer = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("taskManager"u8))
                {
                    taskManager = ComputeResourceRequirement.DeserializeComputeResourceRequirement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("catalogOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    catalogOptions = FlinkCatalogOptions.DeserializeFlinkCatalogOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deploymentMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentMode = new DeploymentMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobSpec = FlinkJobProfile.DeserializeFlinkJobProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FlinkProfile(
                storage,
                numReplicas,
                jobManager,
                historyServer,
                taskManager,
                catalogOptions,
                deploymentMode,
                jobSpec,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FlinkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FlinkProfile)} does not support '{options.Format}' format.");
            }
        }

        FlinkProfile IPersistableModel<FlinkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFlinkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FlinkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FlinkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
