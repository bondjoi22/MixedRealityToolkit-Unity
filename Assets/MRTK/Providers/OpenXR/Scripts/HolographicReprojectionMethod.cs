﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.MixedReality.Toolkit.XRSDK.OpenXR
{
    /// <summary>
    /// Enumeration defining how holograms are stabilized during reprojection.
    /// </summary>
    public enum HolographicReprojectionMethod
    {
        /// <summary>
        /// Turns any reprojection off.
        /// </summary>
        NoReprojection = 0,

        /// <summary>
        /// Use the depth buffer.
        /// </summary>
        Depth = 1,

        /// <summary>
        /// Automatically-placed plane based on the depth buffer.
        /// </summary>
        PlanarFromDepth = 2,

        /// <summary>
        /// Manually-placed plane.
        /// </summary>
        PlanarManual = 3,

        /// <summary>
        /// Reprojection for an orientation-only experience.
        /// </summary>
        OrientationOnly = 4
    }
}