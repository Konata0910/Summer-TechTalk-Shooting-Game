using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D RB;
    [SerializeField] float Power;
    // Start is called once bef
    void Start()
    {
        RB.AddForce(Vector2.up * Power, ForceMode2D.Impulse);
    }
}
