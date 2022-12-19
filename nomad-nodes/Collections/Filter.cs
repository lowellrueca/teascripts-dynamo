using System.Collections.Generic;
using Revit.Elements;
using Collections.Internal;
using Data;

namespace Collections
{
    public static class Filter
    {
        public static IEnumerable<Element>? ByParameterValue(
            IEnumerable<Element> elements,
            string parameterName,
            object parameterValue,
            DataOfType dataOfType)
        {
            return FilterHandler.FilterElementByParameterValue(
                elements, parameterName, parameterValue, dataOfType);
        }

        public static IEnumerable<Element> FilterElementsWithEqualXYParameter(
            IEnumerable<Element> elements,
            string parameterNameX,
            string parameterNameY)
        {
            return FilterHandler.FilterElementsWithEqualXYParameter(elements, parameterNameX, parameterNameY);
        }
    }
}
