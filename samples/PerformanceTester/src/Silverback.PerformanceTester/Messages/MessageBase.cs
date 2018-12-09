﻿// Copyright (c) 2018 Sergio Aquilini
// This code is licensed under MIT license (see LICENSE file for details)

using System;

namespace Silverback.PerformanceTester.Messages
{
    public abstract class MessageBase
    {
        public string Timestamp { get; } = DateTime.Now.ToLongTimeString();
    }
}