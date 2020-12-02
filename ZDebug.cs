using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ZExtensions
{
    /// <summary>
    /// Extensions for Unity's console debugging
    /// ---------------------------------------
    /// Author: @Zainjer | github.com/zainjer
    /// Date Created: November 20th, 2020
    /// </summary>
    public static class ZDebug
    {
        /// <summary>
        /// Works just like Debug.Log
        /// </summary>
        /// <param name="obj">The sender object (for debugging context)</param>
        /// <param name="message">string message to be logged</param>
        /// <returns>The Sender object</returns>
        public static Object Say(this Object obj, string message)
        {
            Debug.Log(obj.name+" says: "+message,obj);
            return obj;
        }

        /// <summary>
        /// Works just like Debug.LogWarning
        /// </summary>
        /// <param name="obj">The sender object (for debugging context)</param>
        /// <param name="message">string message to be logged</param>
        /// <returns>The Sender object</returns>
        public static Object Warn(this Object obj, string message)
        {
            Debug.LogWarning(obj.name + " warns: "+message,obj);
            return obj;
        }

        /// <summary>
        /// Works just like Debug.LogError
        /// </summary>
        /// <param name="obj">The sender object (for debugging context)</param>
        /// <param name="message">string message to be logged</param>
        /// <returns>The Sender object</returns>
        public static Object Yell(this Object obj, string message)
        {
            Debug.LogError(obj.name + " YELLS: "+message.ToUpper(),obj);
            return obj;
        }

        /// <summary>
        /// Checks if an Object reference is null
        /// </summary>
        /// <param name="obj">Object to be checked for Null</param>
        /// <param name="message">string message to be logged</param>
        /// <param name="context">The sender object (for debugging context)</param>
        /// <returns>True if object is null</returns>
        public static bool IsNull(this Object obj,string message,Object context)
        {
            if (obj is null)
            {
                Debug.LogWarning(":::OBJECT REFERENCE NULL! - "+message,context);
                return true;
            }
            else
                return false;
        }
        
    }
}
