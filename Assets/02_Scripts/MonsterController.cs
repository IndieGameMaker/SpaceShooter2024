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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
