#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The spec object defines how the index should be deployed.<br/>
    /// For serverless indexes, you define only the [cloud and region](http://docs.pinecone.io/guides/index-data/create-an-index#cloud-regions) where the index should be hosted. For pod-based indexes, you define the [environment](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-environments) where the index should be hosted, the [pod type and size](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-types) to use, and other index characteristics.
    /// </summary>
    public readonly partial struct IndexSpec : global::System.IEquatable<IndexSpec>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.IndexSpecServerless? Serverless { get; init; }
#else
        public global::Pinecone.IndexSpecServerless? Serverless { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Serverless))]
#endif
        public bool IsServerless => Serverless != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.IndexSpecPodBased? PodBased { get; init; }
#else
        public global::Pinecone.IndexSpecPodBased? PodBased { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PodBased))]
#endif
        public bool IsPodBased => PodBased != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.IndexSpecByoc? Byoc { get; init; }
#else
        public global::Pinecone.IndexSpecByoc? Byoc { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Byoc))]
#endif
        public bool IsByoc => Byoc != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexSpec(global::Pinecone.IndexSpecServerless value) => new IndexSpec((global::Pinecone.IndexSpecServerless?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.IndexSpecServerless?(IndexSpec @this) => @this.Serverless;

        /// <summary>
        /// 
        /// </summary>
        public IndexSpec(global::Pinecone.IndexSpecServerless? value)
        {
            Serverless = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexSpec(global::Pinecone.IndexSpecPodBased value) => new IndexSpec((global::Pinecone.IndexSpecPodBased?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.IndexSpecPodBased?(IndexSpec @this) => @this.PodBased;

        /// <summary>
        /// 
        /// </summary>
        public IndexSpec(global::Pinecone.IndexSpecPodBased? value)
        {
            PodBased = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexSpec(global::Pinecone.IndexSpecByoc value) => new IndexSpec((global::Pinecone.IndexSpecByoc?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.IndexSpecByoc?(IndexSpec @this) => @this.Byoc;

        /// <summary>
        /// 
        /// </summary>
        public IndexSpec(global::Pinecone.IndexSpecByoc? value)
        {
            Byoc = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IndexSpec(
            global::Pinecone.IndexSpecServerless? serverless,
            global::Pinecone.IndexSpecPodBased? podBased,
            global::Pinecone.IndexSpecByoc? byoc
            )
        {
            Serverless = serverless;
            PodBased = podBased;
            Byoc = byoc;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Byoc as object ??
            PodBased as object ??
            Serverless as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Serverless?.ToString() ??
            PodBased?.ToString() ??
            Byoc?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsServerless && !IsPodBased && !IsByoc || !IsServerless && IsPodBased && !IsByoc || !IsServerless && !IsPodBased && IsByoc;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Pinecone.IndexSpecServerless?, TResult>? serverless = null,
            global::System.Func<global::Pinecone.IndexSpecPodBased?, TResult>? podBased = null,
            global::System.Func<global::Pinecone.IndexSpecByoc?, TResult>? byoc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsServerless && serverless != null)
            {
                return serverless(Serverless!);
            }
            else if (IsPodBased && podBased != null)
            {
                return podBased(PodBased!);
            }
            else if (IsByoc && byoc != null)
            {
                return byoc(Byoc!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Pinecone.IndexSpecServerless?>? serverless = null,
            global::System.Action<global::Pinecone.IndexSpecPodBased?>? podBased = null,
            global::System.Action<global::Pinecone.IndexSpecByoc?>? byoc = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsServerless)
            {
                serverless?.Invoke(Serverless!);
            }
            else if (IsPodBased)
            {
                podBased?.Invoke(PodBased!);
            }
            else if (IsByoc)
            {
                byoc?.Invoke(Byoc!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Serverless,
                typeof(global::Pinecone.IndexSpecServerless),
                PodBased,
                typeof(global::Pinecone.IndexSpecPodBased),
                Byoc,
                typeof(global::Pinecone.IndexSpecByoc),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(IndexSpec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.IndexSpecServerless?>.Default.Equals(Serverless, other.Serverless) &&
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.IndexSpecPodBased?>.Default.Equals(PodBased, other.PodBased) &&
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.IndexSpecByoc?>.Default.Equals(Byoc, other.Byoc) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndexSpec obj1, IndexSpec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndexSpec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndexSpec obj1, IndexSpec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndexSpec o && Equals(o);
        }
    }
}
