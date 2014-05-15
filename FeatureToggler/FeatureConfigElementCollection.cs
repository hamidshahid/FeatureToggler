//-----------------------------------------------------------------------
// <copyright file="FeatureConfigElementCollection.cs" company="Hamid Shahid">
// Copyright (c) Hamid Shahid. All rights reserved. THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
// FeatureToggler is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
// You should have received a copy of the GNU Lesser General Public License along with FeatureToggler. If not, see http://www.gnu.org/licenses.
// </copyright>
//-----------------------------------------------------------------------
namespace FeatureToggler
{
    using System.Configuration;

    /// <summary>
    /// Feature Config Element Collection wrapper class
    /// </summary>
    public sealed class FeatureConfigElementCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Overridden method that creates a new element in the collection
        /// </summary>
        /// <returns>The new feature configuration element </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new FeatureConfigElement();
        }

        /// <summary>
        /// Overridden method that returns the key attribute of an element
        /// </summary>        
        /// <param name="element">The element</param>
        /// <returns>The key attribute</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FeatureConfigElement)element).Name;
        }
    }
}