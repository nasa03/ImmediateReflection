#if SUPPORTS_CACHING
using System.Diagnostics;
using JetBrains.Annotations;

namespace ImmediateReflection
{
    /// <summary>
    /// Data stored in the default constructor cache.
    /// </summary>
    internal class DefaultConstructorData
    {
        /// <summary>
        /// Indicates if there is a default constructor.
        /// </summary>
        public bool HasDefault { get; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        [NotNull]
        public DefaultConstructorDelegate Constructor { get; }

        public DefaultConstructorData([NotNull] DefaultConstructorDelegate constructor, bool hasDefault)
        {
            Debug.Assert(constructor != null);

            HasDefault = hasDefault;
            Constructor = constructor;
        }
    }
}
#endif