using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public int jumpLimit = 3;
    //private bool jumpTriggerBool = true;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f);

        JumpMechanics();
        rb.AddForce(movement * speed);

        if (transform.position.y > jumpLimit){
            GetComponent<ConstantForce>().force = new Vector3(0, -40.0f, 0);
        }
        else {
        }
    }

    void JumpMechanics()
    {

        if (Input.GetKeyDown("space"))
        {
            Vector3 jump = new Vector3(0.0f, 200.0f, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump);
        }
    }

}