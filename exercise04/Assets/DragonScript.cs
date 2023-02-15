using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DragonScript : MonoBehaviour
{
    public GameObject player;
    public float followSharpness = 0.05f;
    public float score;
    public TMP_Text ScoreCount;
    
    //public Transform leader;
    void Start()
    {
        GameObject obj= GameObject.Find("ScoreCount");
        ScoreCount = obj.GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Transform leader = player.transform;
        transform.position += (leader.position - transform.position) * followSharpness;
        transform.rotation = Quaternion.Lerp(
                          transform.rotation, 
                          leader.rotation, 
                          followSharpness);
    }

    private void OnTriggerEnter(Collider other){
         if (other.CompareTag("Player")){
            Destroy(gameObject);
            score++;
            ScoreCount.text = score.ToString();
        }
        if (other.CompareTag("Bullet")){
             
                Destroy(gameObject);
                score++;
        }
      }
    
    

    void LateUpdate () {
        // Transform leader = player.transform;
        // transform.position += (leader.position - transform.position) * followSharpness;
        // transform.rotation = Quaternion.Lerp(
        //                   transform.rotation, 
        //                   leader.rotation, 
        //                   followSharpness);
    }
}

