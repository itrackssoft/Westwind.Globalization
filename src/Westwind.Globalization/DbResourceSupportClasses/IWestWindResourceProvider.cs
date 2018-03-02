using System.Globalization;

namespace Westwind.Globalization
{
    /// <summary>
    /// Resource Provider marker interface. Also provides for clearing resources.
    /// </summary>
    public interface IWestWindResourceProvider
    {
        /// <summary>
        /// Interface method used to force providers to register themselves
        /// with DbResourceConfiguration.
        /// </summary>
        /// <param name="culture">The culture to be cleared;<c>null</c> if all should be cleared.</param>
        void ClearResourceCache(CultureInfo culture = null);
    }
}