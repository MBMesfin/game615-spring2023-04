using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{



    public GameObject Bullet;

    public GameObject Plane;
    public Renderer PlaneRend;

    public Color ColorToUse;

    public Material MatToUse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // This will instantiate and launch 100 prefabs of the banana car.
            for (int i = 0; i < 100; i++)
            {
                GameObject ice = Instantiate(Bullet, gameObject.transform.position, Quaternion.identity);
                // float rotXAmount = Random.Range(-89, -10);
                // float rotYAmount = Random.Range(0, 360);
                // ice.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody rb = ice.GetComponent<Rigidbody>();
                rb.AddForce(ice.transform.forward * 1000);

                Destroy(ice, 10f);
            }

        }


    }
}
