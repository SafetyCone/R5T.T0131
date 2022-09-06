using System;

using R5T.T0143;


namespace R5T.T0131
{
    /// <summary>
    /// <para>Values interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Attribute indicating an interface contains values.
    /// Values are implemented as arrow-expressions on an interface (interface default methods).
    /// The marker attribute is useful for surveying values classes and building a catalogue of values.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class ValuesMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsValues;
        /// <summary>
        /// Allows specifying that a class is *not* a values class.
        /// This is useful for marking classes that end up canonical values code file locations, but are not values classes.
        /// </summary>
        public bool IsValues
        {
            get
            {
                return this.zIsValues;
            }
        }


        public ValuesMarkerAttribute(
            bool isValues = true)
        {
            this.zIsValues = isValues;
        }
    }
}
