using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public int shootingStrength = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject throwable = Instantiate(bullet);
            throwable.transform.position = this.transform.localPosition;
            throwable.GetComponent<Rigidbody>().AddForce(Vector3.right * shootingStrength);
            
        }
    }


   
}
