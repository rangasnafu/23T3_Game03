using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalBoundary = 3;

    public GameObject gameOverUI;

    public bool moveLeft = false;
    public bool moveRight = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement1();
        UpdateMovement2();


        if (moveLeft)
        {
            if (transform.position.x >= -horizontalBoundary)
            {
                transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
            }
            else
            {
                moveLeft = false;
            }
        }
        if (moveRight)
        {
            if (transform.position.x < horizontalBoundary)
            {
                transform.Translate(transform.right * movementSpeed * Time.deltaTime);
            }
            else
            {
                moveRight = false;
            }
        }
    }

    public void UpdateMovement1()
    {
        //float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (Input.touchSupported)
        {
            if (Input.GetTouch(0).position.x <= Screen.width / 2f)
            {
                moveLeft = true;
            }
            else
            {
                moveLeft = false;
            }
        }
        else
        {
            if (Input.mousePosition.x <= Screen.width / 2f && Input.GetMouseButton(0))
            {
                moveLeft = true;
            }
            else
            {
                moveLeft = false;
            }
        }
    }

    public void UpdateMovement2()
    {
        //float horizontalInput = Input.GetAxisRaw("Horizontal");
        if (Input.touchSupported)
        {
            if (Input.GetTouch(0).position.x >= Screen.width / 2f)
            {
                moveRight = true;
            }
            else
            {
                moveRight = false;
            }
        }
        else
        {
            if (Input.mousePosition.x >= Screen.width / 2f && Input.GetMouseButton(0))
            {
                moveRight = true;
            }
            else
            {
                moveRight = false;
            }
        }
    }

    public void StopMovement()
    {
        moveLeft = false;
        moveRight = false;
    }

    public void Reload()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
            SceneManager.LoadScene("SampleScene");
            Time.timeScale = 1f;
        //}
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
        }
    }
}
