using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [Header("リジッドボディをアタッチしてください")]
    public Rigidbody2D rb;

    [Header("速度")]
    public float _speed = 5f;

    [Header("弾プレハブ")]
    public GameObject bulletPrefab;



    void Start()
    {
        rb.gravityScale = 0f;
    }

    void Update()
    {
        UpdateMove();
        ClampPosition();
    }

    private void UpdateMove()
    {
        Vector2 move = Vector2.zero;


        if (Input.GetKey(KeyCode.A))  move += Vector2.left;      
        if (Input.GetKey(KeyCode.D)) move += Vector2.right;
        if (Input.GetKey(KeyCode.W)) move += Vector2.up;
        if (Input.GetKey(KeyCode.S)) move += Vector2.down;

        rb.linearVelocity = move.normalized * _speed;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }       
    }
    private void ClampPosition()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -13f, 13f);
        pos.y = Mathf.Clamp(pos.y, -8f, 8f);

        transform.position = pos;
    }
}
