using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 5f;

    public GameObject bulletPrefab;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
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
