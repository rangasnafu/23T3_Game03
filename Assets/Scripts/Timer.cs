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

            if (currentTime >= 20)
            {
                countdownText.color = Color.yellow;
            }

            //if (currentTime < 0)
            //{
            //    Debug.Log("GameOver!");
            //    Time.timeScale = 0f;
            //
            //}

            if (gameOverUI.activeSelf && currentTime <= 10)
            {
                gradeFUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 11 && currentTime <= 20)
            {
                gradeEUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 21 && currentTime <= 30)
            {
                gradeDUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 31 && currentTime <= 40)
            {
                gradeCUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 41 && currentTime <= 50)
            {
                gradeBUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 51 && currentTime <= 60)
            {
                gradeAUI.SetActive(true);
            }

            if (gameOverUI.activeSelf && currentTime >= 61)
            {
                gradeSUI.SetActive(true);
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
