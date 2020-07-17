using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    private float seconds;                   //variable to keep track of the seconds
    public float limit;                 
    private int mashCount;                  //varibale to keep track of the mash presses
    private float stats;
    public Text displayTimer;               //reference to our display Timer Text
    public Text displayScore;               //reference to our display score Text
    public Text displayStats;
    public Text displayStatsDes;
    public Button mainButton;               //reference to our main button
    public Button mashButton;               //reference to our mash button
    public Button resetButton;              //reference to our reset button

    private void Start()
    {
        mashCount = 0;
        stats = 0.0f;
        displayTimer.text = seconds.ToString("f1");
    }

    public void buttonPressed()
    {
        StartCoroutine(RunTimer());
        mainButton.gameObject.SetActive(false);
        mashButton.gameObject.SetActive(true);
    }//end buttonPressed

    IEnumerator RunTimer()
    {
        seconds = limit;
        while (seconds > 0.0f)
        {
            yield return new WaitForSeconds(0.1f);
            seconds = seconds - 0.1f;
            if (seconds <= 0.0f)
                seconds = 0.0f;
            displayTimer.text = seconds.ToString("f1");
        }
        stats = mashCount / limit;
        displayStatsDes.gameObject.SetActive(true);
        displayStats.gameObject.SetActive(true);
        displayStats.text = stats.ToString("f1");
        resetButton.gameObject.SetActive(true);
    }// end RunTimer

    public void mashIncrement()
    {
        if (seconds > 0.0f)
        {
            mashCount++;
            displayScore.text = mashCount.ToString();
        }//end if seconds > 0.0f
    }//end mash Button

    public void reset()
    {
        SceneManager.LoadScene(0);
    }//end reset
}//end class
