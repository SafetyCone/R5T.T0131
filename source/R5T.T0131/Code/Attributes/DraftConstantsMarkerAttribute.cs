using System;

using R5T.T0143;


namespace R5T.T0131
{
    /// <summary>
    /// <para>OBSOLETE - Use values instead.</para>
    /// Attribute indicating a class contains draft constants.
    /// The marker attribute is useful for surveying draft constants classes and building a catalogue of draft constants as a kind of TODO list.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class DraftConstantsMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsConstants;
        /// <summary>
        /// Allows specifying that a class is *not* a draft constants class.
        /// This is useful for marking classes that end up canonical draft constants code file locations, but are not draft constants classes.
        /// </summary>
        public bool IsConstants
        {
            get
            {
                return this.zIsConstants;
            }
        }


        public DraftConstantsMarkerAttribute(
            bool isConstants = true)
        {
            this.zIsConstants = isConstants;
        }
    }
}
