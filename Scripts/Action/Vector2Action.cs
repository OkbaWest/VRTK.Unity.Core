﻿namespace VRTK.Core.Action
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;
    using VRTK.Core.Extension;
    using VRTK.Core.Utility;

    /// <summary>
    /// Emits a <see cref="Vector2"/> value.
    /// </summary>
    public class Vector2Action : BaseAction<Vector2Action, Vector2, Vector2Action.WrappedEvent, Vector2Action.Event>
    {
        /// <summary>
        /// Defines the wrapped event with the <see cref="Vector2"/> state.
        /// </summary>
        [Serializable]
        public class WrappedEvent : WrappedUnityEvent<Vector2, Event>
        {
        }

        /// <summary>
        /// Defines the event with the <see cref="Vector2"/> state.
        /// </summary>
        [Serializable]
        public class Event : UnityEvent<Vector2>
        {
        }

        /// <summary>
        /// The tolerance of equality between two <see cref="Vector2"/> values.
        /// </summary>
        [Tooltip("The tolerance of equality between two Vector2 values.")]
        public float equalityTolerance = float.Epsilon;

        /// <inheritdoc />
        protected override bool IsValueEqual(Vector2 value)
        {
            return Value.ApproxEquals(value, equalityTolerance);
        }

        /// <inheritdoc />
        protected override bool ShouldActivate(Vector2 value)
        {
            return !defaultValue.ApproxEquals(value, equalityTolerance);
        }
    }
}