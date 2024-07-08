using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // 열거형 변수를 정의
    public enum State { IDLE, TRACE, ATTACK, DIE };

    // 몬스터의 상태를 저장하는 변수
    public State state = State.IDLE;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
