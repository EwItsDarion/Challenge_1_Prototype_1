using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype1
{
    public class PlayerLoseOnFall : MonoBehaviour
    {
        void Update()
        {
            if (transform.position.y < -10)
            {
                ScoreManager.gameOver = true;
            }

        }
    }
}
