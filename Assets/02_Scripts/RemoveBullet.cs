using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    //충돌 콜백함수
    void OnCollisionEnter(Collision coll)
    {

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



*/