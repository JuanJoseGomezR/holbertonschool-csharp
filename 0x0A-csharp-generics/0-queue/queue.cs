using System;

/// <summary>
/// My implementation of Queue type
/// </summary>
/// <typeparam name="T">base type</typeparam>
class Queue<T>
{
    public Type CheckType()
    {
        /// <summary>
        /// checks type of T
        /// </summary>
        /// <typeparam name="T">base type</typeparam>
        return typeof(T);
    }
}
