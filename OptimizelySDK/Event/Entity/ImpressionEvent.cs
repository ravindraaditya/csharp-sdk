﻿/* 
 * Copyright 2019, Optimizely
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
using OptimizelySDK.Entity;

namespace OptimizelySDK.Event.Entity
{
    public class ImpressionEvent : UserEvent
    {
        public string UserId { get; private set; }
        public VisitorAttribute[] UserAttributes { get; private set; }

        public Experiment Experiment { get; set; }
        public Variation Variation { get; set; }        
    }
}