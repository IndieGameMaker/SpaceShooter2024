using UnityEngine;

public class MyGizmos : MonoBehaviour
{
    // 색상
    public Color color = Color.yellow;
    // 반지름
    public float radius = 0.3f;

    public void OnDrawGizmos()
    {
        Gizmos.color = this.color;
        Gizmos.DrawSphere(transform.position, this.radius);
    }
}
