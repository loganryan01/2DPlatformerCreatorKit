using UnityEngine;

using TwoDimensionalPlatformerCreatorKit;

namespace TwoDimensionalPlatformerDemo
{
    public class DemoMovingPlatform : MovingPlatform
    {
        protected Vector3 initialPosition;
        protected bool isMovingForward = true;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            initialPosition = transform.position;
        }

        /// <summary>
        /// Handles the movement logic.
        /// </summary>
        protected override void MovePlatform()
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

