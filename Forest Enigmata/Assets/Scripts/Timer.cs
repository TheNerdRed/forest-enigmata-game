using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerCounterText;

    public bool timerActive = true;

    private float secondsCount;

    void Update()
    {
        if(timerActive)
        {
            UpdateTimerUI();
        }
    }

    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerCounterText.text = "" + (int)secondsCount;
    }

    public void stopTimer()
    {
        timerActive = false;
    }
}
