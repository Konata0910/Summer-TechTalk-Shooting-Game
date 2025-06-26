using UnityEngine;

public class RockController : MonoBehaviour
{

    float fallspeed;
    float rotspeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.fallspeed = 0.03f + 0.3f * Random.value;
        this.rotspeed = 5f + 3f * Random.value;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -fallspeed, 0, Space.World);
        transform.Rotate(0, 0, rotspeed);

        if(transform.position.y<-5.5f)
        {
            Destroy(gameObject);
        }
    }
}
