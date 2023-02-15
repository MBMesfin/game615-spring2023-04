using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{



    public GameObject Bullet;

    public GameObject Plane;
    //public Renderer PlaneRend;

    public Color ColorToUse;

    public Material MatToUse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    // This will instantiate and launch 100 prefabs of the banana car.
        //    for (int i = 0; i < 100; i++)
        //    {
        //        GameObject ice = Instantiate(Bullet, gameObject.transform.position, Quaternion.identity);
        //        // float rotXAmount = Random.Range(-89, -10);
        //        // float rotYAmount = Random.Range(0, 360);
        //        // ice.transform.Rotate(rotXAmount, rotYAmount, 0);
        //        Rigidbody rb = ice.GetComponent<Rigidbody>();
        //        rb.AddForce(ice.transform.forward * 1000);

        //        Destroy(ice, 10f);
        //    }

        //}
    }
    private IEnumerator Countdown2()
        {

            {
                yield return new WaitForSeconds(2); //wait 2 seconds
                                                    //do thing
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    GameObject ice = Instantiate(Bullet, new Vector3(gameObject.transform.position.x,
                    gameObject.transform.position.y - 2,
                    gameObject.transform.position.z), Quaternion.identity);
                    float rotXAmount = Random.Range(-89, -10);
                    float rotYAmount = Random.Range(0, 360);
                    ice.transform.Rotate(rotXAmount, rotYAmount, 0);
                    Rigidbody carRB = ice.AddComponent<Rigidbody>();
                    ice.GetComponent<Rigidbody>().useGravity = false;
                    // carRB.AddForce(car.transform.forward*1000);
                    //iceCount++;
                }
            }
        }


   
}
