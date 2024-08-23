using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class Move : MonoBehaviour
    {
        [SerializeField, Tooltip("Determine how fast the object moves left or right.")]
        private float moveSpeed = 5f;

        private Rigidbody2D rb;
        private float moveInput;
        
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            moveInput = Input.GetAxis("Horizontal");
        }

        private void FixedUpdate()
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }
    }
}