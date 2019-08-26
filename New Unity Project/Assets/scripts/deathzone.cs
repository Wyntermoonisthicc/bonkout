using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathzone : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        gameManager.intstance.LoseLife();
    }
}
