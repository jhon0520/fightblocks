using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionSegunTecladoPersonaje2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else
        {
            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                transform.transform.rotation = Quaternion.Euler(0, 135, 0);
            }
            else
            {
                if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
                {
                    transform.transform.rotation = Quaternion.Euler(0, 225, 0);
                }
                else
                {
                    if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
                    {
                        transform.transform.rotation = Quaternion.Euler(0, 315, 0);
                    }
                    else
                    {

                        if (Input.GetKey(KeyCode.UpArrow))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 0, 0);
                        }

                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 90, 0);
                        }

                        if (Input.GetKey(KeyCode.DownArrow))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 180, 0);
                        }

                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            transform.transform.rotation = Quaternion.Euler(0, 270, 0);
                        }
                    }
                }
            }
        }

    }
}

