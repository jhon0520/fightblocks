using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_point : MonoBehaviour {

    int ConstantePlayer1 = 0, ConstantePlayer2 = 0;

    void Update()
    {
        //Debug.Log("Pos en Y: " + this.gameObject.transform.position.y);
        /**
		* Si el balon sale de la psita vuelve a la pista
		*/
        if (this.gameObject.transform.position.y <= 0.0f)
        {
            this.gameObject.transform.position = new Vector3(-7.86f, 6.12f, -1.54f);
        }
    }


    /**
    * Se suma un contador a las colisiones del balon con los personajes
    * para identificar cuando un personaje es golpeado 
    */

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Balon colisiona con:" + collision.gameObject.name);

        if (collision.gameObject.name.Equals("Personaje01"))
        {
            if (ConstantePlayer1 == 1)
            {

                ConstantePlayer1 = 0;
            }
            else
            {
                ConstantePlayer1 = 1;
            }

        }
        else if (collision.gameObject.name.Equals("Personaje02"))
        {
            if (ConstantePlayer1 == 1)
            {

                ConstantePlayer2 = 0;
            }
            else
            {
                ConstantePlayer2 = 1;
            }

        }
        else if (collision.gameObject.name != "Personaje01" || collision.gameObject.name != "Personaje02")
        {
            ConstantePlayer1 = 0;
            ConstantePlayer2 = 0;
        }

        Debug.Log("Estaddos Player_1 && Player_2: " + "P1: " + ConstantePlayer1 + "  P2: " + ConstantePlayer2);

    }
}
