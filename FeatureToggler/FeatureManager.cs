//-----------------------------------------------------------------------
// <copyright file="FeatureManager.cs" company="Hamid Shahid">
// Copyright (c) Hamid Shahid. All rights reserved. THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
// FeatureToggler is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
// You should have received a copy of the GNU Lesser General Public License along with FeatureToggler. If not, see http://www.gnu.org/licenses.
// </copyright>
//-----------------------------------------------------------------------

namespace FeatureToggler
{
    using System;
    using System.Configuration;
    using System.Linq;

    /// <summary>
    /// The Feature Manager class is used by clients to determine if a feature is toggled or not
    /// </summary>
    public static class FeatureManager
    {
        /// <summary>
        /// The configuration section member variable
        /// </summary>
        private static FeatureConfigSection configurationSection = null;

        private static FeatureConfigSection ConfigurationSection
        {
            get
            {
                if (configurationSection == null)
                {
                    configurationSection = ConfigurationManager.GetSection("featureConfiguration") as FeatureConfigSection;
                }

                return configurationSection;
            }
        }

        /// <summary>
        /// Determines if the given feature is on or off
        /// </summary>
        /// <param name="featureName">The name of the feature</param>
        /// <returns>True if the feature is on. False otherwise</returns>
        public static bool HasFeature(string featureName)
        {
            return ConfigurationSection.Features.Cast<FeatureConfigElement>().Any(f => string.Compare(f.Name, featureName, StringComparison.CurrentCultureIgnoreCase) == 0 && IsFeatureOn(f));
        }

        /// <summary>
        /// Determines if the given feature element has toggle on or not.
        /// </summary>
        /// <param name="featureElement">The feature element</param>
        /// <returns>True if there is toggle. False otherwise.</returns>
        private static bool IsFeatureOn(FeatureConfigElement featureElement)
        {
            return
                string.Compare(featureElement.Toggle, "on", StringComparison.CurrentCultureIgnoreCase) == 0 ||
                string.Compare(featureElement.Toggle, "true", StringComparison.CurrentCultureIgnoreCase) == 0 ||
                string.Compare(featureElement.Toggle, "1", StringComparison.CurrentCultureIgnoreCase) == 0;
        }
    }
}