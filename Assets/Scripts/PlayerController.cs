/***
 * AFIX MEDIA 2018
 */
using UnityEngine;

/**
 * Controla el movimiento del personake.
 */
public class PlayerController : MonoBehaviour {

	public float speed 				= 10F; // Velocidad del personaje.
	public float jumpSpeed 			= 15F; // Velocidad de salto.
	public float gravity 			= 20.0F; // Gravedad.
	private Vector3 moveDirection 	= Vector3.zero; // Direccion en que se mueve.
    public float fuerzaLanzamiento = 30.0f;
    public float fuerzaLanzamientoArriba = 15.0f;

    GameObject referenciaBala,Character;

    public bool balaAgarrada = false;

    private void Start()
    {
        referenciaBala = GameObject.Find("Bala");
        Character = GameObject.Find("Player");

        Debug.Log("En el start");
    }

    void FixedUpdate()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded) {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
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
            referenciaBala.GetComponent<Rigidbody>().useGravity = true;

            float fuerzaLanzamientoAplicada = fuerzaLanzamiento;

            Debug.Log(moveDirection);
            if (moveDirection == new Vector3(0f,-0.4f,0f))
            {
                Debug.Log("Solto sin nada");
                moveDirection = new Vector3(0,1.0f,0);
                fuerzaLanzamientoAplicada = fuerzaLanzamientoArriba;
            }

            Rigidbody rb = referenciaBala.GetComponent<Rigidbody>();
            rb.velocity = moveDirection.normalized * fuerzaLanzamientoAplicada;

        }

    }

    /**
     * Manejo de eventos de colision.
     */
    void OnTriggerEnter(Collider collision)
    {
       // Debug.Log("Colision con:" + collision.gameObject.name);

        CharacterController controller = GetComponent<CharacterController>();

        Debug.Log(collision.gameObject.name);
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.name.Equals("Bala"))
        {
            //if (Input.GetKeyDown(KeyCode.E)) {
            balaAgarrada = true;
            //}       
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
            referenciaBala.GetComponent<Rigidbody>().useGravity = false;
            if (referenciaBala != null)
            {
                referenciaBala.transform.position = this.transform.position + new Vector3(0, 4.7f, 0);
            }
        }
    }
}
