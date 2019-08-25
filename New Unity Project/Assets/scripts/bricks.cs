using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bricks : MonoBehaviour
{
    public GameObject brickParticle;

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        gameManager.intstance.DestroyBrick();
        Destroy(gameObject);
    }

}
