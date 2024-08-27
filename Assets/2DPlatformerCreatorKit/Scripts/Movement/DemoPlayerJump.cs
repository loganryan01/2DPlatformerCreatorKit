using UnityEngine;

using TwoDimensionalPlatformerCreatorKit;

namespace TwoDimensionalPlatformerDemo
{
    public class DemoPlayerJump : PlayerJump
    {
        [SerializeField, Tooltip("A reference to the GroundCheck script for the object.")]
        private DemoGroundCheck groundCheck;
        [SerializeField, Tooltip("A reference to the CeilingCheck script for the object.")]
        private CeilingCheck ceilingCheck;

        // A reference to the Rigidbody2D componenet
        private Rigidbody2D rb;
        // A boolean to allow double jumping
        private bool canDoubleJump = false;
        
        // Start is called before the first frame update
        protected virtual void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            if (groundCheck.IsGrounded())
            {
                canDoubleJump = true;
            }

            if (Input.GetButtonDown("Jump"))
            {
                if (groundCheck.IsGrounded())
                {
                    Jump();
                }
                else if (canDoubleJump)
                {
                    Jump();
                    canDoubleJump = false;
                }
            }
        }

        /// <summary>
        /// Sets the y-velocity of the Rigidbody2D to the 'jumpForce', causing the object to jump.
        /// </summary>
        protected override void Jump()
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            if (ceilingCheck.IsTouchingCeiling() && rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
            }
        }
    }
}

