using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public static class SaveSystem
    {
        /// <summary>
        /// Method to save the player's position in the level.
        /// </summary>
        /// <param name="playerPosition"></param>
        public static void SavePlayer(Vector3 playerPosition)
        {
            PlayerPrefs.SetFloat("PlayerPosX", playerPosition.x);
            PlayerPrefs.SetFloat("PlayerPosY", playerPosition.y);
            PlayerPrefs.SetFloat("PlayerPosZ", playerPosition.z);
            PlayerPrefs.Save();
        }
        
        /// <summary>
        /// Method to load the player's last saved position.
        /// </summary>
        /// <returns></returns>
        public static Vector3 LoadPlayer()
        {
            float x = PlayerPrefs.GetFloat("PlayerPosX");
            float y = PlayerPrefs.GetFloat("PlayerPosY");
            float z = PlayerPrefs.GetFloat("PlayerPosZ");

            return new Vector3(x, y, z);
        }
    }
}