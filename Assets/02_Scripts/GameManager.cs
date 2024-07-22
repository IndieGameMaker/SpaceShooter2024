using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();//new();

    void Start()
    {
        GameObject.Find("SpawnPointGroup")?.GetComponentsInChildren<Transform>(points);
    }
}
