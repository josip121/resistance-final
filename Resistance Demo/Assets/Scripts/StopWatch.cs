using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StopWatch : MonoBehaviour
{

    float timer;
    float seconds;
    float minutes;
    float hours;

    [SerializeField] Text stopWatchText;

    // Start is called before the first frame update
    void Start()
    {
        timer = 60;
        minutes = 44;
    }

    // Update is called once per frame
    void Update()
    {
        StopWatchCalcu();
    }


    void StopWatchCalcu()
    {
        timer -= Time.deltaTime;
        seconds = (int)timer;
        //minutes = (int)((timer / 60) % 60);
        //hours = (int)(timer / 3600);

        stopWatchText.text = /*hours.ToString("00") + ":" +*/ minutes.ToString("00") + ":" + seconds.ToString("00");
        if (timer <= 0)
        {
            minutes = minutes - 1;
            timer = 60;
        }
        if (minutes < 0)
        {
            SceneManager.LoadScene("Main manu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }


    }
}
