using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    private Transform cameraTransform;
    public bool gameIsPaused;
    private Vector3 _initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _initialPosition = transform.position;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        MovePlayer();
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, cameraTransform.eulerAngles.y, 0), 100 * Time.deltaTime);
    }

    void MovePlayer()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 dir = transform.TransformVector(new Vector3(moveH, 0, moveV));
        rb.MovePosition(rb.position + dir * speed * Time.deltaTime);
    }

    void ReturnPosition()
    {
        transform.position = _initialPosition;
    }
}
