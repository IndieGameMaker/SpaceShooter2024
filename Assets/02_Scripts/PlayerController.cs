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

        transform.position += new Vector3(0, 0, 0.01f);
        //transform.position = transform.position + new Vector3(0, 0, 0.01f);
    }

}

/*
    int
    float
    bool
    string

    if , if else
    for, foreach, while
    switch

    array 배열
    List 배열

*/
