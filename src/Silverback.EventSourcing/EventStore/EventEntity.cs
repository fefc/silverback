﻿// Copyright (c) 2020 Sergio Aquilini
// This code is licensed under MIT license (see LICENSE file for details)

using System;

namespace Silverback.EventStore
{
    /// <inheritdoc cref="IEventEntity" />
    public abstract class EventEntity : IEventEntity
    {
        /// <inheritdoc cref="IEventEntity.Timestamp" />
        public DateTime Timestamp { get; set; }

        /// <inheritdoc cref="IEventEntity.Sequence" />
        public int Sequence { get; set; }

        /// <inheritdoc cref="IEventEntity.SerializedEvent" />
        public string SerializedEvent { get; set; } = null!;
    }
}
