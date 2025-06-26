using UnityEngine;

public class BackGroundController : MonoBehaviour
{
   // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.01f, 0);

        if(transform.position.y<-5f)
        {
            transform.position = new Vector3(0, 5f, 0);
        }
    }
}
