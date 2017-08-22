using System;

namespace Shipwreck.OpenGraph
{
    partial class GraphObject
    {
        /// <summary>
        /// Returns a first value of the specified local name of the property as <see cref="Boolean" /> value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Boolean? GetLocalPropertyAsBoolean(string property)
            => Boolean.TryParse(GetLocalProperty(property), out var v) ? v : (Boolean?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, Boolean? value)
            => SetLocalProperty(property, value == null ? null : value == true ? "true" : "false");

        /// <summary>
        /// Returns a first value of the specified local name of the property as <see cref="Int32" /> value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Int32? GetLocalPropertyAsInt32(string property)
            => Int32.TryParse(GetLocalProperty(property), out var v) ? v : (Int32?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, Int32? value)
            => SetLocalProperty(property, value?.ToString());

        /// <summary>
        /// Returns a first value of the specified local name of the property as <see cref="Int64" /> value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Int64? GetLocalPropertyAsInt64(string property)
            => Int64.TryParse(GetLocalProperty(property), out var v) ? v : (Int64?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, Int64? value)
            => SetLocalProperty(property, value?.ToString());

        /// <summary>
        /// Returns a first value of the specified local name of the property as <see cref="Single" /> value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Single? GetLocalPropertyAsSingle(string property)
            => Single.TryParse(GetLocalProperty(property), out var v) ? v : (Single?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, Single? value)
            => SetLocalProperty(property, value?.ToString("0.#######"));

        /// <summary>
        /// Returns a first value of the specified local name of the property as <see cref="DateTime" /> value.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public DateTime? GetLocalPropertyAsDateTime(string property)
            => DateTime.TryParse(GetLocalProperty(property), out var v) ? v : (DateTime?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The local name of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(string property, DateTime? value)
            => SetLocalProperty(property, value?.ToString("o"));

    }
    partial class Graph
    {
        /// <summary>
        /// Returns a first value of the specified path of the property as <see cref="Boolean" /> value.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Boolean? GetLocalPropertyAsBoolean(PropertyPath property)
            => Boolean.TryParse(GetLocalProperty(property), out var v) ? v : (Boolean?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(PropertyPath property, Boolean? value)
            => SetLocalProperty(property, value == null ? null : value == true ? "true" : "false");

        /// <summary>
        /// Returns a first value of the specified path of the property as <see cref="Int32" /> value.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Int32? GetLocalPropertyAsInt32(PropertyPath property)
            => Int32.TryParse(GetLocalProperty(property), out var v) ? v : (Int32?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(PropertyPath property, Int32? value)
            => SetLocalProperty(property, value?.ToString());

        /// <summary>
        /// Returns a first value of the specified path of the property as <see cref="Int64" /> value.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Int64? GetLocalPropertyAsInt64(PropertyPath property)
            => Int64.TryParse(GetLocalProperty(property), out var v) ? v : (Int64?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(PropertyPath property, Int64? value)
            => SetLocalProperty(property, value?.ToString());

        /// <summary>
        /// Returns a first value of the specified path of the property as <see cref="Single" /> value.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public Single? GetLocalPropertyAsSingle(PropertyPath property)
            => Single.TryParse(GetLocalProperty(property), out var v) ? v : (Single?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(PropertyPath property, Single? value)
            => SetLocalProperty(property, value?.ToString("0.#######"));

        /// <summary>
        /// Returns a first value of the specified path of the property as <see cref="DateTime" /> value.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <returns>The value of the first entry in <see cref="GraphObject.LocalProperties" /> that name is <paramref name="property"/>; otherwise, <c>null</c>.</returns>
        public DateTime? GetLocalPropertyAsDateTime(PropertyPath property)
            => DateTime.TryParse(GetLocalProperty(property), out var v) ? v : (DateTime?)null;

        /// <summary>
        /// Removes current <see cref="GraphObject.LocalProperties"/> items that name is <paramref name="property"/> and adds a item that value is <paramref name="value"/>.
        /// </summary>
        /// <param name="property">The path of the property.</param>
        /// <param name="value">A new value to set.</param>
        public void SetLocalProperty(PropertyPath property, DateTime? value)
            => SetLocalProperty(property, value?.ToString("o"));

    }
}