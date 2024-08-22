using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class PlayerSetup : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Load the player's starting position when the level starts
            Vector3 savedPosition = SaveSystem.LoadPlayer();
            if (savedPosition != Vector3.zero) // Check if a saved position exists
            {
                transform.position = savedPosition;
            }
        }
    }
}

