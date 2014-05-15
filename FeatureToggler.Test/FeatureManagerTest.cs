//-----------------------------------------------------------------------
// <copyright file="FeatureManagerTest.cs" company="Hamid Shahid">
// Copyright (c) Hamid Shahid. All rights reserved. THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
// FeatureFlipper is free software: you can redistribute it and/or modify it under the terms of the GNU Lesser General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
// You should have received a copy of the GNU Lesser General Public License along with FeatureFlipper. If not, see http://www.gnu.org/licenses.
// </copyright>
//-----------------------------------------------------------------------

namespace FeatureToggler.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FeatureManagerTest
    {
        [TestMethod]
        public void TestFeatureToggle()
        {
            var b = FeatureManager.HasFeature("PrivateProfiles");
            Assert.IsTrue(b);
            Assert.IsFalse(FeatureManager.HasFeature("photosharing"));
            Assert.IsTrue(FeatureManager.HasFeature("videos"));
            Assert.IsTrue(FeatureManager.HasFeature("bookmarks"));
        }
    }
}