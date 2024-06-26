using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Keyboard 입력값
    // 1. InputManager (Legacy)
    // 2. InputSystem  (New)

    // Up/Down Arrow 키값을 저장하기 위한 변수를 선언
    // 접근제한자 (public, private)
    private float v; // 상하 화살표 키값 저장할 변수
    private float h; // 좌우 화살표 키값 저장할 변수
    private float r; // 회전 값을 저장할 변수

    // 이동 속도 변수
    [SerializeField] // 직렬화
    private float moveSpeed = 6.0f;  // 이동속도
    [SerializeField]
    private float turnSpeed = 200.0f; // 회전속도

    [SerializeField]
    private Animator animator;

    void Start()
    {
        Debug.Log("Hello World");
    }

    void Update()
    {
        v = Input.GetAxis("Vertical"); // -1.0f ~ 0.0f ~ +1.0f
        h = Input.GetAxis("Horizontal");
        r = Input.GetAxis("Mouse X");

        // 이동처리
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        transform.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
        // 회전처리
        transform.Rotate(Vector3.up * Time.deltaTime * r * turnSpeed);

        // 애니메애션 처리
        animator.SetFloat("forward", v);
        animator.SetFloat("strafe", h);

        // 벡터의 크기를 1로 변경하는 것
        // 벡터의 정규화 , Vector Normalized


        // transform.Translate(Vector3.forward * Time.deltaTime * v * moveSpeed);
        // transform.Translate(Vector3.right * Time.deltaTime * h * moveSpeed);
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
