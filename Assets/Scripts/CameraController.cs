/***
 * AFIX MEDIA 2018 
 */
using UnityEngine;

/**
 * Este script se encarga de seguir al player.
 */
public class CameraController : MonoBehaviour {

    // Posicion inicial de la camara.
	Vector3 cameraPosition = new Vector3 (0.0f , 6.0f, -10.0f);

	void Update () {
		// Siga al personaje desde una posicion elevada.
		this.transform.position = GameObject.Find ("Jugador").transform.position	+ cameraPosition;
	}
}
