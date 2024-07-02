using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    private int hitCount;
    [SerializeField] private GameObject expEffect;
    [SerializeField] private Texture[] textures;
    private new MeshRenderer renderer;

    void Start()
    {
        renderer = GetComponentInChildren<MeshRenderer>();
    }

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

        Vector3 impactPoint = Random.insideUnitSphere;

        // 폴발 효과 발생
        rb.AddExplosionForce(
                            1500.0f,            // 횡 폭발력
                            transform.position + impactPoint * 2.0f, // 폭발 원점
                            3.0f,               // 폭발 반경
                            1800.0f);           // 종 폭발력

        Instantiate(expEffect, transform.position, Quaternion.identity);
        Destroy(this.gameObject, 2.0f);
    }
}
