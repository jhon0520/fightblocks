using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_point : MonoBehaviour {

    public GameObject Heart1,Heart2, Heart3, Heart4, Heart5, Heart6;

    int ConstantePlayer1 = 0, ConstantePlayer2 = 0, VidaPlayer1 = 0, VidaPlayer2 = 3;

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
            if (ConstantePlayer1 == 0 && ConstantePlayer2 == 1)
            {
                Debug.Log("Perdio vida personaje 2");
                this.gameObject.transform.position = new Vector3(-7.86f, 6.12f, -1.54f);
                ConstantePlayer2 = 0;
                
                VidaPlayer2++;
                Debug.Log("Estado vida P2: " + VidaPlayer2);
                RestarVida(VidaPlayer2);
            }
            else
            {
                ConstantePlayer1 = 1;
            }

        }
        else if (collision.gameObject.name.Equals("Personaje02"))
        {
            if (ConstantePlayer2 == 0 && ConstantePlayer1 == 1)
            {
                Debug.Log("Perdio vida personaje 1");
                this.gameObject.transform.position = new Vector3(-7.86f, 6.12f, -1.54f);
                ConstantePlayer2 = 0;

                VidaPlayer1++;
                Debug.Log("Estado vida P2: " + VidaPlayer1);
                RestarVida(VidaPlayer1);
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

    void RestarVida( int vida)
    {
        if (vida == 1)
        {
            Heart1.SetActive(false);
        }
        else if (vida == 2)
        {
            Heart2.SetActive(false);
        }
        else if (vida == 3)
        {
            Heart3.SetActive(false);
        }
        else if (vida == 4)
        {
            Heart4.SetActive(false);
        }
        else if (vida == 5)
        {
            Heart5.SetActive(false);
        }
        else if (vida == 6)
        {
            Heart6.SetActive(false);
        }
    }
}
