using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TwoDimensionalPlatformerCreatorKit
{
    public class PlayerPoints : MonoBehaviour
    {
        private int points = 0; // Tracks player's points
        private int currency = 0; // Tracks player's currency

        /// <summary>
        /// Method to add points.
        /// </summary>
        /// <param name="amount"></param>
        public void AddPoints(int amount)
        {
            points += amount;
            Debug.Log("Points: " + points);
        }

        /// <summary>
        /// Method to add currency.
        /// </summary>
        /// <param name="amount"></param>
        public void AddCurrency(int amount)
        {
            currency += amount;
            Debug.Log("Currency: " + currency);
        }
    }
}