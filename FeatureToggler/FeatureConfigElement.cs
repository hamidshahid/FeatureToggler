//-----------------------------------------------------------------------
// <copyright file="FeatureConfigElement.cs" company="Hamid Shahid">
// Copyright (c) Hamid Shahid. All rights reserved. THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
// FeatureToggler is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
// You should have received a copy of the GNU Lesser General Public License along with FeatureToggler. If not, see http://www.gnu.org/licenses.
// </copyright>
//-----------------------------------------------------------------------

namespace FeatureToggler
{
    using System.Configuration;

    /// <summary>
    /// Feature Config Element wrapper class
    /// </summary>
    public class FeatureConfigElement : ConfigurationElement
    {
        /// <summary>
        /// Name of feature attribute
        /// </summary>
        private const string FeatureNameAttribute = "name";

        /// <summary>
        /// Name of toggle attribute
        /// </summary>
        private const string FeatureToggleAttribute = "toggle";

        /// <summary>
        /// Gets or sets the name of the feature
        /// </summary>
        [ConfigurationProperty(FeatureNameAttribute, IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)base[FeatureNameAttribute];
            }

            set
            {
                base[FeatureNameAttribute] = value;
            }
        }

        /// <summary>
        /// Gets or sets the toggle of the feature
        /// </summary>
        [ConfigurationProperty(FeatureToggleAttribute, IsKey = true, IsRequired = true)]
        public string Toggle
        {
            get
            {
                return (string)base[FeatureToggleAttribute];
            }

            set
            {
                base[FeatureToggleAttribute] = value;
            }
        }
    }
}