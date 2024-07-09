using System.Collections;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // 열거형 변수를 정의
    public enum State { IDLE, TRACE, ATTACK, DIE };

    // 몬스터의 상태를 저장하는 변수
    public State state = State.IDLE;

    // 공격사정거리
    [SerializeField] private float attackDist = 2.0f;
    // 추적사정거리
    [SerializeField] private float traceDist = 10.0f;

    // 주인공 캐릭터의 Transform 컴포넌트를 저장할 변수
    private Transform playerTr;
    // 몬스터의 Transform
    private Transform monsterTr;

    private bool isDie = false;

    void Start()
    {
        monsterTr = GetComponent<Transform>(); // monsterTr = transform;
        playerTr = GameObject.FindGameObjectWithTag("PLAYER")?.GetComponent<Transform>();

        StartCoroutine(CheckMonsterState());
    }

    IEnumerator CheckMonsterState()
    {
        while (isDie == false)
        {
            // 두 위치간의 거리를 측정
            float distance = Vector3.Distance(monsterTr.position, playerTr.position);
            state = State.IDLE;

            // 추적 사정거리 이내일 경우
            if (distance <= traceDist)
            {
                state = State.TRACE;
            }

            // 공격 사정거리 이내일 경우
            if (distance <= attackDist)
            {
                state = State.ATTACK;
            }

            yield return new WaitForSeconds(0.3f);
        }
    }
}