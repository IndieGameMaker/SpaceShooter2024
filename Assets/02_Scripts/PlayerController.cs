using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Keyboard 입력값
    // 1. InputManager (Legacy)
    // 2. InputSystem  (New)

    // Up/Down Arrow 키값을 저장하기 위한 변수를 선언
    public float v; // 상하 화살표 키값 저장할 변수
    public float h; // 좌우 화살표 키값 저장할 변수

    void Start()
    {
        Debug.Log("Hello World");
    }

    void Update()
    {
        v = Input.GetAxis("Vertical"); // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");

        // Debug.Log("v=" + v);
        // Debug.Log("h=" + h);


        Debug.Log($"h={h} / v={v}");
    }

}
