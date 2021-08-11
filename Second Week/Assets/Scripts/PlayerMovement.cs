using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField]float StartSpeed=5f;
    float Speed;
    float shiftSpeed;
    [SerializeField] float rotationSpeed = 300f;
    float mouseX;



    Vector3 moveDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        shiftSpeed = StartSpeed * 3;
        Speed = StartSpeed;
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        mouseX = Input.GetAxis("Mouse X");

        moveDirection = (transform.right * horizontal + transform.forward * vertical).normalized;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = shiftSpeed;
        }
        else
        {
            Speed = StartSpeed;
        }

        transform.Rotate(new Vector3(0f,mouseX*rotationSpeed,0f));
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = moveDirection * Speed;
    }

    
}
