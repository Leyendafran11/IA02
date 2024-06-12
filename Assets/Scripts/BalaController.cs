using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    
    void Start()
    {
        Invoke("Destruir", 2.0f);        
    }

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Robot") {

            collision.gameObject.GetComponent<RobotController>().quitarVida();
            Destroy(this.gameObject);
        }
	}

    private void Destruir()
    {

        Destroy(this.gameObject);   
    }
}
