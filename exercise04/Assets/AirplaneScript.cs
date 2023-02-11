using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneScript : MonoBehaviour
{
    float forwardSpeed = 2;
    float rotateSpeed = 20;
    public GameObject Bullet;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Rotate(rotateSpeed * Time.deltaTime *-1, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.S)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Rotate(rotateSpeed * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime *-1, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.D)){
        //gameObject.transform.Translate(gameObject.transform.forward*speed);
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
        }
        //gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
        gameObject.transform.Translate(transform.forward * forwardSpeed * Time.deltaTime, Space.World);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // This will instantiate and launch 100 prefabs of the banana car.
            for (int i = 0; i < 100; i++)
            {
                GameObject ice = Instantiate(Bullet, gameObject.transform.position, Quaternion.identity);
                // float rotXAmount = Random.Range(-89, -10);
                // float rotYAmount = Random.Range(0, 360);
                // ice.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody icerb = ice.AddComponent<Rigidbody>();
                icerb.GetComponent<Rigidbody>().useGravity = false; 
                icerb.AddForce(ice.transform.forward * 1000);

                Destroy(ice, 10f);
            }

        }
    }
}
