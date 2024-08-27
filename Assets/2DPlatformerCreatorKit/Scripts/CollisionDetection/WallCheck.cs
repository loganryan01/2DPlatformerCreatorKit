/******************************************************************************
    Name: WallCheck.cs
    Author: Logan Ryan
    Description: Checks if the player character is touching a wall object.
******************************************************************************/
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    /// <summary>
    /// WallCheck checks if the player character is touching a wall object.
    /// </summary>
    public abstract class WallCheck : MonoBehaviour
    {
        /// <summary>
        /// Handle the collision between the player character and the colliding wall object.
        /// </summary>
        protected abstract void OnWallCollision();
    }
}