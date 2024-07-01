using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    //충돌 콜백함수
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "BULLET")
        {
            // BULLET 삭제
            Destroy(coll.gameObject);
        }
    }
}
/*
    1. Collider 컴포넌트의 IsTrigger 속성 언체크

        OnCollisionEnter    1
        OnCollisionStay     n
        OnCollisionExit     1

    2. Collider 컴포넌트의 IsTrigger 속성 체크

        OnTriggerEnter      1
        OnTriggerStay       n
        OnTriggerExit       1

    3. 충돌 콜백함수가 호출되는 필수조건

        1. 양쪽 다 Collider 컴포넌트가 있어야 함.
        2. 이동하는 게임오브젝트에는 Rigidbody 반드시 있어야 함.
*/