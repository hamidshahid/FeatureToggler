//-----------------------------------------------------------------------
// <copyright file="FeatureConfigSection.cs" company="Hamid Shahid">
// Copyright (c) Hamid Shahid. All rights reserved. THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
// FeatureToggler is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
// You should have received a copy of the GNU Lesser General Public License along with FeatureToggler. If not, see http://www.gnu.org/licenses.
// </copyright>
//-----------------------------------------------------------------------
namespace FeatureToggler
{
    using System.Configuration;

    /// <summary>
    /// Wrapper class for strongly typed configuration setting for features.
    /// </summary>
    public class FeatureConfigSection : ConfigurationSection 
    {
        /// <summary>
        /// Gets or sets Features Collection in the configuration section
        /// </summary>
        [ConfigurationProperty("features", IsRequired = true, IsDefaultCollection = true)]
        [ConfigurationCollection(typeof(FeatureConfigElementCollection))]
        public FeatureConfigElementCollection Features
        {
            get
            {
                return (FeatureConfigElementCollection)this["features"];
            }
        }
    }    
}