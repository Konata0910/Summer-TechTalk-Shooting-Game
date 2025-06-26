using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {               
       transform.Translate(0,0.2f,0);

        if(transform.position.y>10)

          {
              Destroy (gameObject);   
          }       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
           
        }
    }
}
