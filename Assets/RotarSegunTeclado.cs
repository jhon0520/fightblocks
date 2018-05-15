using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotarSegunTeclado : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.transform.rotation = Quaternion.Euler(0, 45, 0);
        } else {
            if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                transform.transform.rotation = Quaternion.Euler(0, 135, 0);
            } else {
                if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
                {
                    transform.transform.rotation = Quaternion.Euler(0, 225, 0);
                } else {
                    if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
                    {
                        transform.transform.rotation = Quaternion.Euler(0, 315, 0);
                    }
                    else
                    {
                 
                        if (Input.GetKey(KeyCode.W))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 0, 0);
                        }

                        if (Input.GetKey(KeyCode.D))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 90, 0);
                        }

                        if (Input.GetKey(KeyCode.S))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 180, 0);
                        }

                        if (Input.GetKey(KeyCode.A))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 270, 0);
                        }
                    }
                }
            }
        }

    }
}
