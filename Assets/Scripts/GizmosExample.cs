using UnityEngine;
public class GizmosExample : MonoBehaviour
{
    void OnDrawGizmosSelected()
    {
        // Draw a yellow cube at the transform position
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireCube(transform.position, new Vector3(10, 10, 10));
    }
}