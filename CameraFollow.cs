using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;

    private void FixedUpdate()
    {
        transform.position = Player.position + Offset;
    }
}
