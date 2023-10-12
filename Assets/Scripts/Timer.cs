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

    public GameObject gradeSUI;
    public GameObject gradeAUI;
    public GameObject gradeBUI;
    public GameObject gradeCUI;
    public GameObject gradeDUI;
    public GameObject gradeEUI;
    public GameObject gradeFUI;

    public GameObject gameOverUI;

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

            if (gameOverUI.activeSelf && currentTime <= 10)
            {
                gradeFUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 11 && currentTime <= 30)
            {
                gradeEUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 31 && currentTime <= 50)
            {
                gradeDUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 51 && currentTime <= 60)
            {
                gradeCUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 61 && currentTime <= 80)
            {
                gradeBUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 81 && currentTime <= 100)
            {
                gradeAUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 101)
            {
                gradeSUI.SetActive(true);
            }

            //////////////////////////////////////
            
            if (currentTime <= 9)
            {
                countdownText.color = Color.magenta;
            }

            if (currentTime >= 10 && currentTime <= 29)
            {
                countdownText.color = Color.blue;
            }

            if (currentTime >= 30 && currentTime <= 49)
            {
                countdownText.color = Color.cyan;
            }

            if (currentTime >= 50 && currentTime <= 59)
            {;
                countdownText.color = Color.green;
            }

            if (currentTime >= 60 && currentTime <= 79)
            {
                countdownText.color = Color.yellow;
            }

            if (currentTime >= 80 && currentTime <= 99)
            {
                countdownText.color = Color.red;
            }

            if (currentTime >= 100)
            {
                countdownText.color = Color.red;
            }
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
