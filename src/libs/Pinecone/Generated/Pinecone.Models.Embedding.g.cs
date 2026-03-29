#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Embedding of a single input
    /// </summary>
    public readonly partial struct Embedding : global::System.IEquatable<Embedding>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Pinecone.EmbeddingDiscriminatorVectorType? VectorType { get; }

        /// <summary>
        /// A dense embedding of a single input
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.DenseEmbedding? Dense { get; init; }
#else
        public global::Pinecone.DenseEmbedding? Dense { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dense))]
#endif
        public bool IsDense => Dense != null;

        /// <summary>
        /// A sparse embedding of a single input
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.SparseEmbedding? Sparse { get; init; }
#else
        public global::Pinecone.SparseEmbedding? Sparse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sparse))]
#endif
        public bool IsSparse => Sparse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Embedding(global::Pinecone.DenseEmbedding value) => new Embedding((global::Pinecone.DenseEmbedding?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.DenseEmbedding?(Embedding @this) => @this.Dense;

        /// <summary>
        /// 
        /// </summary>
        public Embedding(global::Pinecone.DenseEmbedding? value)
        {
            Dense = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Embedding(global::Pinecone.SparseEmbedding value) => new Embedding((global::Pinecone.SparseEmbedding?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.SparseEmbedding?(Embedding @this) => @this.Sparse;

        /// <summary>
        /// 
        /// </summary>
        public Embedding(global::Pinecone.SparseEmbedding? value)
        {
            Sparse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Embedding(
            global::Pinecone.EmbeddingDiscriminatorVectorType? vectorType,
            global::Pinecone.DenseEmbedding? dense,
            global::Pinecone.SparseEmbedding? sparse
            )
        {
            VectorType = vectorType;

            Dense = dense;
            Sparse = sparse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Sparse as object ??
            Dense as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dense?.ToString() ??
            Sparse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDense && !IsSparse || !IsDense && IsSparse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Pinecone.DenseEmbedding?, TResult>? dense = null,
            global::System.Func<global::Pinecone.SparseEmbedding?, TResult>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDense && dense != null)
            {
                return dense(Dense!);
            }
            else if (IsSparse && sparse != null)
            {
                return sparse(Sparse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Pinecone.DenseEmbedding?>? dense = null,
            global::System.Action<global::Pinecone.SparseEmbedding?>? sparse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDense)
            {
                dense?.Invoke(Dense!);
            }
            else if (IsSparse)
            {
                sparse?.Invoke(Sparse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dense,
                typeof(global::Pinecone.DenseEmbedding),
                Sparse,
                typeof(global::Pinecone.SparseEmbedding),
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
        public bool Equals(Embedding other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.DenseEmbedding?>.Default.Equals(Dense, other.Dense) &&
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.SparseEmbedding?>.Default.Equals(Sparse, other.Sparse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Embedding obj1, Embedding obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Embedding>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Embedding obj1, Embedding obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Embedding o && Equals(o);
        }
    }
}
