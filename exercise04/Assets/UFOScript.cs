using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOScript : MonoBehaviour
{
    public int dragonCount =0;
    float forwardSpeed = 5;
    float rotateSpeed = 20;
    public GameObject dragon;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(Countdown2()); 
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.Self);
        gameObject.transform.Translate(transform.forward *3f*Time.deltaTime, Space.World);
       
    }
    private IEnumerator Countdown2() {
    while(true) {
        yield return new WaitForSeconds(2); //wait 2 seconds
        //do thing
        if(dragonCount <=10){
                GameObject car = Instantiate(dragon, new Vector3(gameObject.transform.position.x,
                gameObject.transform.position.y-2,
                gameObject.transform.position.z), Quaternion.identity);
                float rotXAmount = Random.Range(-89, -10);
                float rotYAmount = Random.Range(0, 360);
                car.transform.Rotate(rotXAmount, rotYAmount, 0);
                Rigidbody carRB = car.AddComponent<Rigidbody>();
                car.GetComponent<Rigidbody>().useGravity = false; 
                // carRB.AddForce(car.transform.forward*1000);
                dragonCount++;
        }


                

    }
}
}
