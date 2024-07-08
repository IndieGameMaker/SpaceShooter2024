using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // 변수명 파스칼케이스 사용 : 소문자로 시작
    public GameObject bulletPrefab;
    public Transform firePos;

    private new AudioSource audio;
    private MeshRenderer muzzleFlash;
    private CinemachineImpulseSource impulseSource;

    [SerializeField] private AudioClip fireSfx;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        impulseSource = GetComponent<CinemachineImpulseSource>();

        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
        muzzleFlash.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();

            // 총소리 발생
            audio.PlayOneShot(fireSfx, 0.8f);

            // Muzzle Flash
            StartCoroutine(ShowMuzzleFlash());
        }
    }

    private void Fire()
    {
        // 동적으로 Bullet 생성
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        // 타격감 연출
        impulseSource.GenerateImpulse();
    }

    // 코루틴 (Coroutine)
    IEnumerator ShowMuzzleFlash()
    {
        // Texture Offset 변경
        // (0, 0), (0, 0.5), (0.5, 0), (0.5, 0.5)
        // Random.Range(0, 2) => (0, 1) * 0.5
        Vector2 offset = new Vector2(Random.Range(0, 2), Random.Range(0, 2)) * 0.5f;
        muzzleFlash.material.mainTextureOffset = offset;

        // Scale 변경
        float scale = Random.Range(1.0f, 2.5f);
        muzzleFlash.transform.localScale = Vector3.one * scale;
        //new Vector3(scale, scale, scale);

        muzzleFlash.enabled = true;

        yield return new WaitForSeconds(0.2f);

        muzzleFlash.enabled = false;
    }
}
