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

        // transform.position += new Vector3(0, 0, 0.01f);
        // transform.position += Vector3.forward * 0.01f;

        transform.Translate(Vector3.forward * 0.01f);
    }
    // 함수(Function) , 메소드(Method)

    /*
        Vector3 ShortHand

        Vector3.forward = Vector3(0, 0, 1)
        Vector3.up      = Vector3(0, 1, 0)
        Vector3.right   = Vector3(1, 0, 0)

        Vector3.one     = Vector3(1, 1, 1)
        Vector3.zero    = Vector3(0, 0, 0)    
    */

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
