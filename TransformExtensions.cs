using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZExtensions
{/// <summary>
///Author: @Zainjer | github.com/zainjer
/// Date Created: November 22nd, 2020
 /// </summary>
    public static class TransformExtensions
    {

        #region Rotation
        
        #region Yaw
        public static Transform SetYaw(this Transform transform, float yaw)
        {
            var angles = transform.eulerAngles;
            transform.eulerAngles = new Vector3(angles.x,yaw,angles.z);
            return transform;
        }

        public static float GetYaw(this Transform transform)
        {
            return transform.eulerAngles.y;
        }
        public static Transform FlipYaw(this Transform transform)
        {
            var angles = transform.eulerAngles;
                
            transform.eulerAngles = new Vector3(angles.x, 
                angles.y-180, //Where Yaw gets flipped
                angles.z);
            return transform;
        }
        
        #endregion

        #region Pitch
        public static Transform SetPitch(this Transform transform, float pitch)
        {
            var angles = transform.eulerAngles;
            transform.eulerAngles = new Vector3(pitch,angles.y,angles.z);
            return transform;
        }

        public static float GetPitch(this Transform transform)
        {
            return transform.eulerAngles.x;
        }

        public static Transform FlipPitch(this Transform transform)
        {
            var angles = transform.eulerAngles;
            
            transform.eulerAngles = new Vector3(angles.x-180, //Where pitch gets flipped
                angles.y,
                angles.z);
            return transform;
        }
        #endregion
        
        #region Roll
        public static Transform SetRoll(this Transform transform, float roll)
        {
            var angles = transform.eulerAngles;
            transform.eulerAngles = new Vector3(angles.x,angles.y,roll);
            return transform;
        }
        
        public static float GetRoll(this Transform transform)
        {
            return transform.eulerAngles.z;
        }
        
        public static Transform FlipRoll(this Transform transform)
        {
            var angles = transform.eulerAngles;
            transform.eulerAngles = new Vector3(angles.x-180, 
                angles.y,
                angles.z-180);//Where Roll gets flipped
            return transform;
        }
        
        #endregion
        
        #endregion
        
        
    }

}