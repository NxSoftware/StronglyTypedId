using System;

namespace StronglyTypedIds
{
    /// <summary>
    /// Used to control the default Place on partial structs to make the type a strongly-typed ID
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    [System.Diagnostics.Conditional("STRONGLY_TYPED_ID_USAGES")]
    public sealed class StronglyTypedIdDefaultsAttribute : Attribute
    {
        /// <summary>
        /// Set the default values used for strongly typed ids
        /// </summary>
        /// <param name="backingType">The <see cref="Type"/> to use to store the strongly-typed ID value.
        /// Defaults to <see cref="StronglyTypedIdBackingType.Guid"/></param>
        /// <param name="converters">JSON library used to serialize/deserialize strongly-typed ID value.
        /// Defaults to <see cref="StronglyTypedIdConverter.NewtonsoftJson"/> and <see cref="StronglyTypedIdConverter.TypeConverter"/></param>
        /// <param name="implementations">Interfaces and patterns the strongly typed id should implement
        /// Defaults to <see cref="StronglyTypedIdImplementations.IEquatable"/> and <see cref="StronglyTypedIdImplementations.IComparable"/></param>
        /// <param name="constructor">Indicates how the constructor should be generated
        /// Defaults to <see cref="StronglyTypedIdConstructor.Public"/></param>
        public StronglyTypedIdDefaultsAttribute(
            StronglyTypedIdBackingType backingType = StronglyTypedIdBackingType.Default,
            StronglyTypedIdConverter converters = StronglyTypedIdConverter.Default,
            StronglyTypedIdImplementations implementations = StronglyTypedIdImplementations.Default,
            StronglyTypedIdConstructor constructor = StronglyTypedIdConstructor.Default)
        {
            BackingType = backingType;
            Converters = converters;
            Implementations = implementations;
            Constructor = constructor;
        }

        /// <summary>
        /// The default <see cref="Type"/> to use to store the strongly-typed ID values.
        /// </summary>
        public StronglyTypedIdBackingType BackingType { get; }

        /// <summary>
        /// The default converters to create for serializing/deserializing strongly-typed ID values.
        /// </summary>
        public StronglyTypedIdConverter Converters { get; }

        /// <summary>
        /// Interfaces and patterns the strongly typed id should implement
        /// </summary>
        public StronglyTypedIdImplementations Implementations { get; }

        /// <summary>
        /// Indicates how the constructor should be generated
        /// </summary>
        public StronglyTypedIdConstructor Constructor { get; }
    }
}