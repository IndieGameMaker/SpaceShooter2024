using System;
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

    private float initHp = 100.0f;
    private float currHp = 100.0f;

    // 이벤트 선언
    // 델리게이트 (Delegate : 대리자)
    public delegate void PlayerDie();
    public static event PlayerDie OnPlayerDie;

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

    }

    void OnTriggerEnter(Collider coll)
    {
        if (currHp > 0.0f && coll.CompareTag("PUNCH"))
        {
            currHp -= 10.0f;
            if (currHp <= 0.0f)
            {
                //GameObject.Find("Game Manager").GetComponent<GameManager>().IsGameOver = true;
                GameManager.instance.IsGameOver = true;
                OnPlayerDie(); // 이벤트 호출 (발생 : Raise)
                //PlayerDie();
            }
        }
    }

    // private void PlayerDie()
    // {
    //     GameObject[] monsters = GameObject.FindGameObjectsWithTag("MONSTER");
    //     foreach (var monster in monsters)
    //     {
    //         monster.GetComponent<MonsterController>().YouWin();
    //     }
    // }
}