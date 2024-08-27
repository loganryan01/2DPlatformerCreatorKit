using UnityEngine;

using TwoDimensionalPlatformerCreatorKit;

namespace TwoDimensionalPlatformerDemo
{
    public class DemoWallCheck : WallCheck
    {
        protected virtual void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                // Handle collision with walls if needed
                OnWallCollision();
            }
        }

        protected override void OnWallCollision()
        {
            Debug.Log("Colliding with a wall");
        }
    }
}