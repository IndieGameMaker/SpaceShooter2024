using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    [SerializeField] private GameObject sparkEffect;

    //충돌 콜백함수
    void OnCollisionEnter(Collision coll)
    {
        //if (coll.collider.tag == "BULLET") // Garbage Collection 발생

        if (coll.collider.CompareTag("BULLET"))
        {
            // 스파크이펙트 발생            


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

/*
        # AudioListener 
            1. 소리를 듣는 역할 , 귀
            2. 씬에 유일하게 하나만 존재

        # AudioSource
            1. 소리를 발생시키는 역할, 스피커
            2. 여러개 존재가능

*/