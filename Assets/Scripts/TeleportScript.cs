/**
 * Este script se debe anexar a los objetos teleport.
 */
using UnityEngine;

public class TeleportScript : MonoBehaviour {
    public GameObject destino;

    void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("Teleport colisione con:"+collision.gameObject.name);
        if (destino != null)
        {
            if (collision.gameObject.name.Equals("Personaje01") || collision.gameObject.name.Equals("Personaje02"))
            {
                collision.gameObject.transform.position = destino.transform.position;
            }
        }
    }

}
