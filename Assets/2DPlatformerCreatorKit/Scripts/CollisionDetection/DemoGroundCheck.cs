using UnityEngine;

using TwoDimensionalPlatformerCreatorKit;

namespace TwoDimensionalPlatformerDemo
{
    public class DemoGroundCheck : GroundCheck
    {
        /// <summary>
        /// Checks if the groundCheck object is overlapping with any ground colliders.
        /// </summary>
        protected override void CheckIfGrounded()
        {
            base.CheckIfGrounded();

            // For debug purposes, a ground check line is drawn in the scene view
            Debug.DrawLine(groundCheck.position, groundCheck.position + Vector3.down * groundCheckRadius, isGrounded ? Color.green : Color.red);
        }
    }
}