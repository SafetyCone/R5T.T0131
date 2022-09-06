using System;

using R5T.T0143;


namespace R5T.T0131
{
    /// <summary>
    /// <para>OBSOLETE - Use values instead.</para>
    /// Attribute indicating a class contains constants.
    /// The marker attribute is useful for surveying constants classes and building a catalogue of constants.
    /// </summary>
    //[Obsolete]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class ConstantsMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsConstants;
        /// <summary>
        /// Allows specifying that a class is *not* a constants class.
        /// This is useful for marking classes that end up canonical constants code file locations, but are not constants classes.
        /// </summary>
        public bool IsConstants
        {
            get
            {
                return this.zIsConstants;
            }
        }


        public ConstantsMarkerAttribute(
            bool isConstants = true)
        {
            this.zIsConstants = isConstants;
        }
    }
}
