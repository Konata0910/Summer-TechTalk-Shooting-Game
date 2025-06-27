using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("リジッドボディをアタッチしてください")]
    public Rigidbody2D RB;
    [Header("射出速度")]
    public float Power;
    [Header("識別コード")]
    public int IFF;
    // Start is called once bef
    void Start()
    {
        RB.AddForce(this.transform.up * Power, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided" + other.ToString());
        DeathSystem DS = other.gameObject.GetComponent<DeathSystem>();
        if (DS ? DS.IFF != IFF : false)
            DS.Death();
    }
}
