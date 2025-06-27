using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("リジッドボディをアタッチしてください")]
    public Rigidbody2D RB;
    [Header("移動速度")]
    public float Speed;
    [Header("弾プレハブ")]
    public GameObject BulletPrefab;
    [Header("射撃間隔")]
    public float FireInterval;
    float CT;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CT < FireInterval)
            CT += Time.deltaTime;
        else
        {
            CT = 0;
            GameObject Bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);

        }
        RB.linearVelocity = -Vector2.up * Speed; 

    }
}
