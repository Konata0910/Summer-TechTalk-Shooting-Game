using UnityEngine;
using UnityEngine.Events;

public class DeathSystem : MonoBehaviour
{
    [Header("¯•ÊƒR[ƒh")]
    public int IFF;

    public void Death()
    {
        Destroy(this.gameObject);
    }
}
