/***
 * AFIX MEDIA 2018
 */
using UnityEngine;

/**
 * Controla el movimiento del personake.
 */
public class PlayerController : MonoBehaviour {

	public float speed 				= 6.0F; // Velocidad del personaje.
	public float jumpSpeed 			= 8.0F; // Velocidad de salto.
	public float gravity 			= 20.0F; // Gravedad.
	private Vector3 moveDirection 	= Vector3.zero; // Direccion en que se mueve.
    public float fuerzaLanzamiento = 100.0f;

    GameObject referenciaBala;

    public bool balaAgarrada = false;

    private void Start()
    {
        referenciaBala = GameObject.Find("Bala");
    }

    void FixedUpdate()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded) {
            

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump")) {
                moveDirection.y = jumpSpeed;
            }

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        verificarAgarreBala();

        // Si presiono R cuando tenia la bala agarrada deberia soltar bala.
        if (Input.GetKeyDown(KeyCode.R) && balaAgarrada)
        {
            balaAgarrada = false;

            Rigidbody rb = referenciaBala.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-20, 0, 0);
            /*
            Rigidbody rb = referenciaBala.GetComponent<Rigidbody>();
            rb.AddForce((new Vector3(0,20.0f,0.0f)) * fuerzaLanzamiento);*/
        }

    }

    /**
     * Manejo de eventos de colision.
     */
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name.Equals("Bala")) {
            if (Input.GetKeyDown(KeyCode.E)) {
                balaAgarrada = true;
            }       
        }
    }

    /**
    * Este metodo verifica si se a activado el flag agarrar bala,
    * si esta activado busca la bala y actualiza la posicion.
    */
    void verificarAgarreBala()
    {
        if (balaAgarrada)
        {
            if (referenciaBala != null)
            {
                referenciaBala.transform.position = this.transform.position + new Vector3(0, 1f, 0);
            }
        }
    }
}
