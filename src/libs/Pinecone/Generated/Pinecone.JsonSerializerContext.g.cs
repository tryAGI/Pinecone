
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Pinecone.JsonConverters.ReadCapacityDiscriminatorModeJsonConverter),

            typeof(global::Pinecone.JsonConverters.ReadCapacityDiscriminatorModeNullableJsonConverter),

            typeof(global::Pinecone.JsonConverters.ReadCapacityResponseDiscriminatorModeJsonConverter),

            typeof(global::Pinecone.JsonConverters.ReadCapacityResponseDiscriminatorModeNullableJsonConverter),

            typeof(global::Pinecone.JsonConverters.EmbeddingDiscriminatorVectorTypeJsonConverter),

            typeof(global::Pinecone.JsonConverters.EmbeddingDiscriminatorVectorTypeNullableJsonConverter),

            typeof(global::Pinecone.JsonConverters.ReadCapacityJsonConverter),

            typeof(global::Pinecone.JsonConverters.IndexSpecJsonConverter),

            typeof(global::Pinecone.JsonConverters.ReadCapacityResponseJsonConverter),

            typeof(global::Pinecone.JsonConverters.EmbeddingJsonConverter),

            typeof(global::Pinecone.JsonConverters.OneOfJsonConverter<global::Pinecone.ConfigureIndexRequestSpecServerless, global::Pinecone.ConfigureIndexRequestSpecPodBased, global::Pinecone.ConfigureIndexRequestSpecByoc>),

            typeof(global::Pinecone.JsonConverters.OneOfJsonConverter<global::Pinecone.IndexModelSpecServerless, global::Pinecone.IndexModelSpecPodBased, global::Pinecone.IndexModelSpecByoc>),

            typeof(global::Pinecone.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Pinecone.JsonConverters.AnyOfJsonConverter<string, int?, float?, bool?>),

            typeof(global::Pinecone.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateIndexFromBackupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacity), TypeInfoPropertyName = "ReadCapacity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityOnDemandSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityDedicatedSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityDiscriminatorMode), TypeInfoPropertyName = "ReadCapacityDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.MetadataSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Pinecone.MetadataSchemaFields2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.MetadataSchemaFields2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexSpec), TypeInfoPropertyName = "IndexSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexSpecServerless))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ServerlessSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexSpecPodBased))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.PodSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexSpecByoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ByocSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.OneOf<global::Pinecone.ConfigureIndexRequestSpecServerless, global::Pinecone.ConfigureIndexRequestSpecPodBased, global::Pinecone.ConfigureIndexRequestSpecByoc>), TypeInfoPropertyName = "OneOfConfigureIndexRequestSpecServerlessConfigureIndexRequestSpecPodBasedConfigureIndexRequestSpecByoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestSpecServerless))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestSpecServerlessServerless))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestSpecPodBased))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestSpecPodBasedPod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestSpecByoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestSpecByocByoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ConfigureIndexRequestEmbed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CollectionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.CollectionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CollectionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityOnDemandSpecResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.RestoreJobModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityResponse), TypeInfoPropertyName = "ReadCapacityResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityDedicatedSpecResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityResponseDiscriminatorMode), TypeInfoPropertyName = "ReadCapacityResponseDiscriminatorMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.RestoreJobList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.RestoreJobModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.PaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ModelIndexEmbed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.OneOf<global::Pinecone.IndexModelSpecServerless, global::Pinecone.IndexModelSpecPodBased, global::Pinecone.IndexModelSpecByoc>), TypeInfoPropertyName = "OneOfIndexModelSpecServerlessIndexModelSpecPodBasedIndexModelSpecByoc2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexModelSpecServerless))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ServerlessSpecResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexModelSpecPodBased))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexModelSpecByoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ByocSpecResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexModelStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateIndexForModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateIndexForModelRequestEmbed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateIndexRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateBackupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ReadCapacityDedicatedConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ScalingConfigManual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.PodSpecMetadataConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.BackupList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.BackupModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.BackupModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.CreateIndexFromBackupResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.IndexList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.IndexModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ModelInfoSupportedParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.AnyOf<string, int?, float?, bool?>), TypeInfoPropertyName = "AnyOfStringInt32SingleBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.SparseEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.Document))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.EmbeddingsList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.Embedding), TypeInfoPropertyName = "Embedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.EmbeddingsListUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ModelInfoList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.RerankResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.RankedDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.RankedDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.RerankResultUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.DenseEmbedding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.EmbeddingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.EmbeddingDiscriminatorVectorType), TypeInfoPropertyName = "EmbeddingDiscriminatorVectorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.EmbedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.EmbedRequestInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Pinecone.EmbedRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Pinecone.ModelInfoSupportedParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.CollectionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.RestoreJobModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.BackupModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.IndexModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.Embedding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.Document>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.RankedDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.EmbedRequestInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Pinecone.ModelInfoSupportedParameter>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}