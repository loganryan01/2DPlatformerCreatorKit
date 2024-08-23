using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class MovingPlatform : MonoBehaviour
    {
        public enum MovementType { HORIZONTAL, VERTICAL }
        [SerializeField, Tooltip("Determines if the platform is moving horizontally or vertically.")]
        private MovementType movementType;

        [SerializeField, Tooltip("Speed of the platform.")]
        private float speed = 2.0f;
        [SerializeField, Tooltip("Distance the platform travels from its initial position.")]
        private float distance = 5.0f;

        private Vector3 initialPosition;
        private bool isMovingForward = true;
        
        // Start is called before the first frame update
        void Start()
        {
            initialPosition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            MovePlatform();
        }

        /// <summary>
        /// Handles the movement logic.
        /// </summary>
        private void MovePlatform()
        {
            Vector3 targetPosition = initialPosition;
            if (movementType == MovementType.HORIZONTAL)
            {
                targetPosition.x += isMovingForward ? distance : -distance;
            }
            else if (movementType == MovementType.VERTICAL)
            {
                targetPosition.y += isMovingForward ? distance : -distance;
            }

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                isMovingForward = !isMovingForward;
            }
        }
    }
}