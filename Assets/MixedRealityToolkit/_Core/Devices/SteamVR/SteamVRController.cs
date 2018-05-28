﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Definitions;
using Microsoft.MixedReality.Toolkit.Internal.Definitions.Devices;
using Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem;
using System.Collections.Generic;

namespace Microsoft.MixedReality.Toolkit.Internal.Devices.SteamVR
{
    // TODO - Implement
    public struct SteamVRController : IMixedRealityController
    {
        #region Private properties

        #endregion Private properties

        public SteamVRController(uint sourceId, Handedness handedness)
        {
            ControllerState = ControllerState.None;

            ControllerHandedness = handedness;

            InputSource = null;

            Interactions = new Dictionary<DeviceInputType, InteractionDefinition>();
        }

        #region IMixedRealityController Interface Members

        public ControllerState ControllerState { get; private set; }

        public Handedness ControllerHandedness { get; }

        public IMixedRealityInputSource InputSource { get; private set; }

        public Dictionary<DeviceInputType, InteractionDefinition> Interactions { get; private set; }

        public void SetupInputSource<T>(T state)
        {
            // TODO
        }

        public void UpdateInputSource<T>(T state)
        {
            // TODO
        }

        #endregion IMixedRealityInputSource Interface Members

        #region Setup and Update functions

        // TODO

        #endregion Setup and Update functions

        #region Utilities

        // TODO - if required

        #endregion Utilities
    }
}