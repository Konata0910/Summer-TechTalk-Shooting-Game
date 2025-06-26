using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    [SerializeField] float Speed;
   // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * Speed, 0);

        if(transform.position.y < -33.8f)
        {
            transform.position = Vector3.zero;
        }
        else
        {
            Debug.Log(transform.position.y.ToString());
        }
    }
}
