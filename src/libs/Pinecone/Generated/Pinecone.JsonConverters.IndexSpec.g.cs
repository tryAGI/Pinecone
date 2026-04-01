#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Pinecone.JsonConverters
{
    /// <inheritdoc />
    public class IndexSpecJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pinecone.IndexSpec>
    {
        /// <inheritdoc />
        public override global::Pinecone.IndexSpec Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("serverless")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("pod")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("byoc")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Pinecone.IndexSpecServerless? serverless = default;
            global::Pinecone.IndexSpecPodBased? podBased = default;
            global::Pinecone.IndexSpecByoc? byoc = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecServerless), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecServerless> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecServerless).Name}");
                        serverless = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecPodBased), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecPodBased> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecPodBased).Name}");
                        podBased = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecByoc), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecByoc> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecByoc).Name}");
                        byoc = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (serverless == null && podBased == null && byoc == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecServerless), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecServerless> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecServerless).Name}");
                    serverless = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecPodBased), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecPodBased> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecPodBased).Name}");
                    podBased = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecByoc), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecByoc> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecByoc).Name}");
                    byoc = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Pinecone.IndexSpec(
                serverless,

                podBased,

                byoc
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pinecone.IndexSpec value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsServerless)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecServerless), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecServerless?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecServerless).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Serverless!, typeInfo);
            }
            else if (value.IsPodBased)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecPodBased), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecPodBased?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecPodBased).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PodBased!, typeInfo);
            }
            else if (value.IsByoc)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.IndexSpecByoc), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.IndexSpecByoc?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.IndexSpecByoc).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Byoc!, typeInfo);
            }
        }
    }
}