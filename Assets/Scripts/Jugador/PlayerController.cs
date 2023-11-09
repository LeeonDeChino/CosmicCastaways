using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public Transform groundCheck; // Objeto vacío que actuará como ground check
    public LayerMask groundLayer;
    private Vector2 move;
    private bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (groundCheck == null)
        {
            Debug.LogError("Ground check object not assigned!");
        }
    }

    void Update()
    {
        GetPlayerInput();
        MovePlayer();

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    void GetPlayerInput()
    {
        // Aquí puedes manejar la entrada del jugador, por ejemplo, usando Input System.
        // Establece el valor de 'move' según la entrada del jugador.
    }

    void MovePlayer()
    {
        Vector3 movement = new Vector3(move.x, 0f, move.y);

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Comprueba si el objeto está en el suelo.
        isGrounded = Physics.Raycast(groundCheck.position, Vector3.down, 0.1f, groundLayer);
    }

    void Jump()
    {
        if (rb != null)
        {
            // Aplica una fuerza hacia arriba para simular el salto.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
