using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class ObstacleController : MonoBehaviour
    {
        [SerializeField, Tooltip("Is the obstacle moving?")]
        private bool isMoving = false;
        [SerializeField, Tooltip("Direction of movement")]
        private Vector2 movementDirection = Vector2.left;
        [SerializeField, Tooltip("Speed of movement")]
        private float movementSpeed = 2f;
        [SerializeField, Tooltip("Should the obstacle move back and forth?")]
        private bool isPingPong = false;
        [SerializeField, Tooltip("Distance to move back and forth")]
        private float pingPongDistance = 3f;

        // Original position for ping pong movement
        private Vector2 originalPosition;
        
        // Start is called before the first frame update
        void Start()
        {
            originalPosition = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            if (isMoving)
            {
                MoveObstacle();
            }
        }

        /// <summary>
        /// Method to move the obstacle.
        /// </summary>
        private void MoveObstacle()
        {
            if (isPingPong)
            {
                float pingPongValue = Mathf.PingPong(Time.time * movementSpeed, pingPongDistance);
                transform.position = originalPosition + movementDirection.normalized * pingPongValue;
            }
            else
            {
                transform.Translate(movementDirection.normalized * movementSpeed * Time.deltaTime);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("Player hit an obstacle!");
            }
        }
    }
}

