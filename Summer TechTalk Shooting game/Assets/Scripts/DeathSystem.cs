using UnityEngine;
using UnityEngine.Events;

public class DeathSystem : MonoBehaviour
{
    [Header("���ʃR�[�h")]
    public int IFF;

    public void Death()
    {
        Destroy(this.gameObject);
    }
}
