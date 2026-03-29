#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Response containing read capacity configuration
    /// </summary>
    public readonly partial struct ReadCapacityResponse : global::System.IEquatable<ReadCapacityResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Pinecone.ReadCapacityResponseDiscriminatorMode? Mode { get; }

        /// <summary>
        /// Example: {"mode":"OnDemand","status":{"state":"Ready"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.ReadCapacityOnDemandSpecResponse? OnDemand { get; init; }
#else
        public global::Pinecone.ReadCapacityOnDemandSpecResponse? OnDemand { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OnDemand))]
#endif
        public bool IsOnDemand => OnDemand != null;

        /// <summary>
        /// Example: {"dedicated":{"manual":{"replicas":2,"shards":2},"node_type":"t1","scaling":"Manual"},"mode":"Dedicated","status":{"current_replicas":2,"current_shards":2,"state":"Ready"}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.ReadCapacityDedicatedSpecResponse? Dedicated { get; init; }
#else
        public global::Pinecone.ReadCapacityDedicatedSpecResponse? Dedicated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dedicated))]
#endif
        public bool IsDedicated => Dedicated != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadCapacityResponse(global::Pinecone.ReadCapacityOnDemandSpecResponse value) => new ReadCapacityResponse((global::Pinecone.ReadCapacityOnDemandSpecResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.ReadCapacityOnDemandSpecResponse?(ReadCapacityResponse @this) => @this.OnDemand;

        /// <summary>
        /// 
        /// </summary>
        public ReadCapacityResponse(global::Pinecone.ReadCapacityOnDemandSpecResponse? value)
        {
            OnDemand = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadCapacityResponse(global::Pinecone.ReadCapacityDedicatedSpecResponse value) => new ReadCapacityResponse((global::Pinecone.ReadCapacityDedicatedSpecResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.ReadCapacityDedicatedSpecResponse?(ReadCapacityResponse @this) => @this.Dedicated;

        /// <summary>
        /// 
        /// </summary>
        public ReadCapacityResponse(global::Pinecone.ReadCapacityDedicatedSpecResponse? value)
        {
            Dedicated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadCapacityResponse(
            global::Pinecone.ReadCapacityResponseDiscriminatorMode? mode,
            global::Pinecone.ReadCapacityOnDemandSpecResponse? onDemand,
            global::Pinecone.ReadCapacityDedicatedSpecResponse? dedicated
            )
        {
            Mode = mode;

            OnDemand = onDemand;
            Dedicated = dedicated;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dedicated as object ??
            OnDemand as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OnDemand?.ToString() ??
            Dedicated?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOnDemand && !IsDedicated || !IsOnDemand && IsDedicated;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Pinecone.ReadCapacityOnDemandSpecResponse?, TResult>? onDemand = null,
            global::System.Func<global::Pinecone.ReadCapacityDedicatedSpecResponse?, TResult>? dedicated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOnDemand && onDemand != null)
            {
                return onDemand(OnDemand!);
            }
            else if (IsDedicated && dedicated != null)
            {
                return dedicated(Dedicated!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Pinecone.ReadCapacityOnDemandSpecResponse?>? onDemand = null,
            global::System.Action<global::Pinecone.ReadCapacityDedicatedSpecResponse?>? dedicated = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOnDemand)
            {
                onDemand?.Invoke(OnDemand!);
            }
            else if (IsDedicated)
            {
                dedicated?.Invoke(Dedicated!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OnDemand,
                typeof(global::Pinecone.ReadCapacityOnDemandSpecResponse),
                Dedicated,
                typeof(global::Pinecone.ReadCapacityDedicatedSpecResponse),
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
        public bool Equals(ReadCapacityResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.ReadCapacityOnDemandSpecResponse?>.Default.Equals(OnDemand, other.OnDemand) &&
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.ReadCapacityDedicatedSpecResponse?>.Default.Equals(Dedicated, other.Dedicated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReadCapacityResponse obj1, ReadCapacityResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReadCapacityResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReadCapacityResponse obj1, ReadCapacityResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReadCapacityResponse o && Equals(o);
        }
    }
}
