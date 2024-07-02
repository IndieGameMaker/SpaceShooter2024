using System.Collections;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // 변수명 파스칼케이스 사용 : 소문자로 시작
    public GameObject bulletPrefab;
    public Transform firePos;

    private new AudioSource audio;
    private MeshRenderer muzzleFlash;

    [SerializeField] private AudioClip fireSfx;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
        muzzleFlash.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 동적으로 Bullet 생성
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);

            // 총소리 발생
            audio.PlayOneShot(fireSfx, 0.8f);

            // Muzzle Flash
            StartCoroutine(ShowMuzzleFlash());
        }
    }

    // 코루틴 (Coroutine)
    IEnumerator ShowMuzzleFlash()
    {
        muzzleFlash.enabled = true;

        yield return new WaitForSeconds(0.2f);

        muzzleFlash.enabled = false;
    }
}
