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
        var rb = this.gameObject.AddComponent<Rigidbody>();
        // 폴발 효과 발생
        rb.AddExplosionForce(
                            1500.0f,            // 횡 폭발력
                            transform.position, // 폭발 원점
                            3.0f,               // 폭발 반경
                            1800.0f);           // 종 폭발력
    }
}
