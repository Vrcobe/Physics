using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed ;
    Rigidbody rigid;
    public int fuerza;
    private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        fuerza = 20;
        speed = 15;
        rigid = GetComponent<Rigidbody>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Time.deltaTime * Vector3.down *speed;
        }
        if (Input.GetKey(KeyCode.UpArrow) && canJump)
        {
            //rigid.AddForce(transform.up * fuerza );
            rigid.AddForce(new Vector3(0,1,0) * fuerza);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Time.deltaTime * Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Time.deltaTime * Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += Time.deltaTime * Vector3.forward *speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += Time.deltaTime * Vector3.back * speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = false;
        }
            
    }
}
