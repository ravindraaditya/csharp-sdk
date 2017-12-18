﻿/* 
 * Copyright 2017, Optimizely
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;

namespace OptimizelySDK.Entity
{
    public class FeatureDecision
    {
        public const string DECISION_SOURCE_EXPERIMENT = "experiment";
        public const string DECISION_SOURCE_ROLLOUT = "rollout";

        public string ExperimentId { get; }
        public string VariationId { get; }
        public string Source { get; }

        public FeatureDecision(string experimentId, string variationId, string source)
        {
            ExperimentId = experimentId;
            VariationId = variationId;
            Source = source;
        }
    }
}
