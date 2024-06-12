using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float zInicial;
    public float zFinal;
	public float velocidad;
	public int sentido;
    



    void Start()
    {
        StartCoroutine("CambioVelocidad");
        
    }


    IEnumerator CambioVelocidad()
    {
        float cambioV = Random.Range(2.0f,8.0f);
        yield return new WaitForSeconds(cambioV);
		velocidad = Random.Range(1.0f, 5.0f);
	}

    
    void Update()
    {
        if (this.transform.position.z <= zInicial && sentido == -1) {
            sentido = 1;
        } else if (this.transform.position.z >= zFinal && sentido == 1) {
            sentido = -1;
        }
        this.transform.position = this.transform.position + this.transform.forward * sentido * velocidad * Time.deltaTime;
        
    }
}
