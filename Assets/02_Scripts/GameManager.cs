using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 싱글턴 변수
    public static GameManager instance = null;

    public List<Transform> points = new List<Transform>();//new();
    public GameObject monsterPrefab;

    private bool isGameOver;

    // 프로퍼티 : 외부에 공개되는 속성값
    public bool IsGameOver
    {
        get
        {
            return isGameOver;
        }
        set
        {
            isGameOver = value;
            // 몬스터 생성을 중지
            CancelInvoke(nameof(CreateMonster));
        }
    }

    void Awake()
    {
        //instance = this;

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        // // get
        // bool aaa = GameManager.IsGameOver;
        // // set
        // GameManager.IsGameOver = true;

        GameObject.Find("SpawnPointGroup")?.GetComponentsInChildren<Transform>(points);

        //Invoke("호출할 함수", 지연시간);
        InvokeRepeating(nameof(CreateMonster), 2.0f, 3.0f);
    }

    void CreateMonster()
    {
        // 불규칙한 위치를 추출하기 위한 단수 발생
        int index = Random.Range(1, points.Count);
        // 몬스터 생성
        Instantiate(monsterPrefab, points[index].position, Quaternion.identity);
    }
}
