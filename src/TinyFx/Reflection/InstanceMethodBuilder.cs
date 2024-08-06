﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Text;

namespace TinyFx.Reflection
{
    /// <summary>
    /// 通过方法创建委托
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TReturnValue"></typeparam>
    public static class InstanceMethodBuilder<T, TReturnValue>
    {
        /// <summary>
        /// 调用时就像 var result = func(t)。
        /// </summary>
        [Pure]
        public static Func<T, TReturnValue> CreateInstanceMethod<TInstanceType>(TInstanceType instance, MethodInfo method)
        {
            if (instance == null) throw new ArgumentNullException(nameof(instance));
            if (method == null) throw new ArgumentNullException(nameof(method));

            return (Func<T, TReturnValue>)method.CreateDelegate(typeof(Func<T, TReturnValue>), instance);
        }

        /// <summary>
        /// 调用时就像 var result = func(this, t)。
        /// </summary>
        [Pure]
        public static Func<TInstanceType, T, TReturnValue> CreateMethod<TInstanceType>(MethodInfo method)
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            return (Func<TInstanceType, T, TReturnValue>)method.CreateDelegate(typeof(Func<TInstanceType, T, TReturnValue>));
        }
    }
}
