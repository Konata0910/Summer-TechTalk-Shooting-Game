using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DestroyZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PlayerMove>())
            return;
        Destroy(other.gameObject);
    }
}
