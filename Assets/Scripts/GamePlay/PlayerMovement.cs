using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform orientation;


    [SerializeField] private Transform GroundCheck;
    [SerializeField] private float checkRadius = 0.5f;
    [SerializeField] private LayerMask Ground;
    [SerializeField] float jumpForce = 350f;



    private Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private bool onGround;
    private Vector3 moveDirection;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }


    void Update()
    {
        MyInput();
        CheckingGround();
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }


    private void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    private void Move()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * speed * 10, ForceMode.Force);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
            rb.AddForce(Vector3.up * jumpForce);
    }
    private void CheckingGround()
    {
        Collider[] colliders = Physics.OverlapSphere(GroundCheck.position, checkRadius, Ground);
        onGround = colliders.Length > 0 ? true : false;
    }

}
