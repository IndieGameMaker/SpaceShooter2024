using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    private int hitCount;
    private new MeshRenderer renderer;
    private new AudioSource audio;

    [SerializeField] private GameObject expEffect;
    [SerializeField] private Texture[] textures;
    [SerializeField] private AudioClip expSfx;

    void Start()
    {
        renderer = GetComponentInChildren<MeshRenderer>();
        audio = GetComponent<AudioSource>();

        // 난수 발생
        /*
            Random.Range(min, max)
            - 정수 Random.Range(0, 10) => 0, 1, 2, ..., 9
            - 실수 Random.Range(0.0f, 10.0f) => 0.0f ~ 10.0f
        */

        int index = Random.Range(0, textures.Length); // 0, 1, 2
        // 텍스처 교체
        renderer.material.mainTexture = textures[index];
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

        var obj = Instantiate(expEffect, transform.position, Quaternion.identity);
        Destroy(obj, 3.0f);

        Destroy(this.gameObject, 2.0f);
        // 폭발음 발생
        audio.PlayOneShot(expSfx, 0.9f);
    }
}
