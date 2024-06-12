using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
   
    public GameObject Bala;
    private GameObject boquilla;


    // Start is called before the first frame update
    void Start()
    {
        boquilla = this.transform.GetChild(0).transform.gameObject;

        StartCoroutine("Disparar");

    }

    IEnumerator Disparar()
    {

        while (true)
        {
			float retardo = Random.Range(0.5f, 3.0f);
			yield return new WaitForSeconds(retardo);

            GameObject b = Instantiate(Bala, boquilla.transform.position, Quaternion.identity);

            b.GetComponent<Rigidbody>().AddForce(boquilla.transform.up * 800);
        }
    }

   
}
