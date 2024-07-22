using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();//new();
    public GameObject monsterPrefab;

    void Start()
    {
        GameObject.Find("SpawnPointGroup")?.GetComponentsInChildren<Transform>(points);
    }

    void CreateMonster()
    {
        // 불규칙한 위치를 추출하기 위한 단수 발생
        int index = Random.Range(1, points.Count);
        // 몬스터 생성
        Instantiate(monsterPrefab, points[index].position, Quaternion.identity);
    }
}