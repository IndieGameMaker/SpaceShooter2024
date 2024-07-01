using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 동적으로 Bullet 생성
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }
    }
}
