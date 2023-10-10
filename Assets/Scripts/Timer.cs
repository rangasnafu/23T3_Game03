using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 0f;

    public GameObject timerUI;

    [SerializeField] TMP_Text countdownText;

    public AudioSource audioSource;
    public AudioClip timer;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (timerUI.activeSelf)
        {
            currentTime += Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            //if (currentTime <= 10)
            //{
            //    countdownText.color = Color.red;
            //}

            //if (currentTime < 0)
            //{
            //    Debug.Log("GameOver!");
            //    Time.timeScale = 0f;
            //
            //}
        }

    }

    public void TimerSound()
    {
        audioSource.clip = timer;
        audioSource.Play();

        //if (Time.timeScale = 0f)
        //{
        //    Destroy(gameObject);
        //}

    }
}
