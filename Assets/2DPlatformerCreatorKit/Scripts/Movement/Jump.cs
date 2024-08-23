using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Jump : MonoBehaviour
    {
        [SerializeField, Tooltip("A reference to the GroundCheck script for the object.")]
        private GroundCheck groundCheck;
        [SerializeField, Tooltip("A reference to the CeilingCheck script for the object.")]
        private CeilingCheck ceilingCheck;
        [SerializeField, Tooltip("The force applied to the object when jumping.")]
        private float jumpForce = 10f;

        // A reference to the Rigidbody2D componenet
        private Rigidbody2D rb;
        // A boolean to allow double jumping
        private bool canDoubleJump = false;
        
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (groundCheck.IsGrounded())
            {
                canDoubleJump = true;
            }

            if (Input.GetButtonDown("Jump"))
            {
                if (groundCheck.IsGrounded())
                {
                    ApplyJumpForce();
                }
                else if (canDoubleJump)
                {
                    ApplyJumpForce();
                    canDoubleJump = false;
                }
            }
        }

        /// <summary>
        /// Sets the y-velocity of the Rigidbody2D to the 'jumpForce', causing the object to jump.
        /// </summary>
        private void ApplyJumpForce()
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

            if (ceilingCheck.IsTouchingCeiling() && rb.velocity.y > 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
            }
        }
    }
}

