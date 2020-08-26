﻿//  Copyright 2020 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System.Collections.Generic;

namespace NtApiDotNet.Win32.Device
{
    /// <summary>
    /// Node in the a device tree.
    /// </summary>
    public sealed class DeviceNode : DeviceEntry
    {
        private readonly List<DeviceNode> _children;

        /// <summary>
        /// List of child nodes.
        /// </summary>
        public IReadOnlyList<DeviceNode> Children => _children.AsReadOnly();

        internal void AddRange(IEnumerable<DeviceNode> node)
        {
            _children.AddRange(node);
        }

        internal DeviceNode()
        {
            _children = new List<DeviceNode>();
        }
    }
}
