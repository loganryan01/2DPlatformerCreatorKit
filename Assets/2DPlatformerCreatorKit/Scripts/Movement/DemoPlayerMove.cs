using UnityEngine;

using TwoDimensionalPlatformerCreatorKit;

namespace TwoDimensionalPlatformerDemo
{
    public class DemoPlayerMove : PlayerMove
    {
        private Rigidbody2D rb;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        protected virtual void FixedUpdate()
        {
            Move();
        }

        protected override void Move()
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }
    }
}