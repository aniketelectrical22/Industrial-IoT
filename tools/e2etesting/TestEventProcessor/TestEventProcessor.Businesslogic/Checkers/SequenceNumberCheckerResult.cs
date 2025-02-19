﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace TestEventProcessor.BusinessLogic.Checkers {

    /// <summary>
    /// Result of IncrementalIntValueChecker monitoring.
    /// </summary>
    class SequenceNumberCheckerResult {

        /// <summary>
        /// Indicates number of dropped messages that were observed. It is calculated by detecting
        /// gaps in the value changes.
        /// </summary>
        public uint DroppedValueCount { get; set; } = 0;

        /// <summary>
        /// Indicates number of consecutive duplicate values that were observed.
        /// </summary>
        public uint DuplicateValueCount { get; set; } = 0;

        /// <summary>
        /// Indicates number of resets in the values that were observed.
        /// </summary>
        public uint ResetsValueCount { get; set; } = 0;
    }
}
