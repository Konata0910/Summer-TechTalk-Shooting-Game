using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("���W�b�h�{�f�B���A�^�b�`���Ă�������")]
    public Rigidbody2D RB;
    [Header("�ˏo���x")]
    public float Power;
    [Header("���ʃR�[�h")]
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
