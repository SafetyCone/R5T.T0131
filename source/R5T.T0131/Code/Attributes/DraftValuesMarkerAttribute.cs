using System;

using R5T.T0143;


namespace R5T.T0131
{
    /// <summary>
    /// Attribute indicating an interface contains draft values.
    /// Values are implemented as arrow-expressions on an interface (interface default methods).
    /// The marker attribute is useful for surveying draft values classes and building a catalogue of draft values as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftValuesMarkerAttribute : Attribute,
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


        public DraftValuesMarkerAttribute(
            bool isValues = true)
        {
            this.zIsValues = isValues;
        }
    }
}
