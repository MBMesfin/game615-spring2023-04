using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public float timeRemaining = 6;

    public bool timerIsRunning = false;
    public float TimeLeft;
    public bool TimerOn = false;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimerText;
    public int score;
   // public TextMeshProUGUI Score;
    int count = 0;
    public TMP_Text dragonCount;
    //public int score;
    // Start is called before the first frame update
    void Start()
    {
      
        timerIsRunning = true;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)

        {

            if (timeRemaining > 0 && score < 20)

            {

                timeRemaining -= Time.deltaTime;
              TimerText.text = timeRemaining.ToString();
               //ScoreText.text = score.ToString();

            }

            else if (timeRemaining > 0 && score == 20)
            {
                ScoreText.text = "You Win!";
            }
            else
            {

              //  Debug.Log("Time ran out!");


                timeRemaining = 0;
                timerIsRunning = false;
                
             TimerText.text = timeRemaining.ToString();

             ScoreText.text = "You lose :( ";


            }
        }
   

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            
            dragonCount.text = count.ToString();
            count++;
        }
     
    }

    
    
}
