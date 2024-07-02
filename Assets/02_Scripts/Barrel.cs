using System;
using Unity.VisualScripting;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private int hitCount;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            if (++hitCount == 3)
            {
                ExpBarrel();
            }
        }
    }

    private void ExpBarrel()
    {

    }
}
