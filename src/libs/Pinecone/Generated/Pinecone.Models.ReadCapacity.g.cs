#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
    /// </summary>
    public readonly partial struct ReadCapacity : global::System.IEquatable<ReadCapacity>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Pinecone.ReadCapacityDiscriminatorMode? Mode { get; }

        /// <summary>
        /// Example: {"mode":"OnDemand"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.ReadCapacityOnDemandSpec? OnDemand { get; init; }
#else
        public global::Pinecone.ReadCapacityOnDemandSpec? OnDemand { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OnDemand))]
#endif
        public bool IsOnDemand => OnDemand != null;

        /// <summary>
        /// Example: {"dedicated":{"manual":{"replicas":1,"shards":1},"node_type":"t1","scaling":"Manual"},"mode":"Dedicated"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Pinecone.ReadCapacityDedicatedSpec? Dedicated { get; init; }
#else
        public global::Pinecone.ReadCapacityDedicatedSpec? Dedicated { get; }
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
        public static implicit operator ReadCapacity(global::Pinecone.ReadCapacityOnDemandSpec value) => new ReadCapacity((global::Pinecone.ReadCapacityOnDemandSpec?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.ReadCapacityOnDemandSpec?(ReadCapacity @this) => @this.OnDemand;

        /// <summary>
        /// 
        /// </summary>
        public ReadCapacity(global::Pinecone.ReadCapacityOnDemandSpec? value)
        {
            OnDemand = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReadCapacity(global::Pinecone.ReadCapacityDedicatedSpec value) => new ReadCapacity((global::Pinecone.ReadCapacityDedicatedSpec?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Pinecone.ReadCapacityDedicatedSpec?(ReadCapacity @this) => @this.Dedicated;

        /// <summary>
        /// 
        /// </summary>
        public ReadCapacity(global::Pinecone.ReadCapacityDedicatedSpec? value)
        {
            Dedicated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReadCapacity(
            global::Pinecone.ReadCapacityDiscriminatorMode? mode,
            global::Pinecone.ReadCapacityOnDemandSpec? onDemand,
            global::Pinecone.ReadCapacityDedicatedSpec? dedicated
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
            global::System.Func<global::Pinecone.ReadCapacityOnDemandSpec?, TResult>? onDemand = null,
            global::System.Func<global::Pinecone.ReadCapacityDedicatedSpec?, TResult>? dedicated = null,
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
            global::System.Action<global::Pinecone.ReadCapacityOnDemandSpec?>? onDemand = null,
            global::System.Action<global::Pinecone.ReadCapacityDedicatedSpec?>? dedicated = null,
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
                typeof(global::Pinecone.ReadCapacityOnDemandSpec),
                Dedicated,
                typeof(global::Pinecone.ReadCapacityDedicatedSpec),
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
        public bool Equals(ReadCapacity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.ReadCapacityOnDemandSpec?>.Default.Equals(OnDemand, other.OnDemand) &&
                global::System.Collections.Generic.EqualityComparer<global::Pinecone.ReadCapacityDedicatedSpec?>.Default.Equals(Dedicated, other.Dedicated) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReadCapacity obj1, ReadCapacity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReadCapacity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReadCapacity obj1, ReadCapacity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReadCapacity o && Equals(o);
        }
    }
}
