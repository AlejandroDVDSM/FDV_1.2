using UnityEngine;

public class PlayerLog : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log($"<{gameObject.name}> has hit <{hit.gameObject.name}> collision...");
    }
}
