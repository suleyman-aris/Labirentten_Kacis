using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    bool jump = true;

    int level = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Terrain")
        {
            jump = true;
        }
        if (collision.collider.tag == "Bitiþ")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            level += 1;
            if (level > 3)
            {
                level = 1;
            }
            PlayerPrefs.SetInt("level", level);
        }
        if (collision.collider.tag == "Kaybettiniz")
        {
            Debug.Log("aaaa");
            SceneManager.LoadScene("Kaybettiniz");
        }
    }
    private void OnTriggerEnter(Collider other)
    {

    }
    void Start()
    {
        level = PlayerPrefs.GetInt("level");
        Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        if (jump && Input.GetKeyDown(KeyCode.Space))
        {
            jump = false;
            GetComponent<Rigidbody>().AddForce(0, 600, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 55);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -55);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-55, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(55, 0, 0);
        }

    }
    public void Bölümü_Tekrarla()
    {
        level = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene(level);
    }

    public void ÝlkBölüm()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("level", 1);
    }

    public void AnaSayfa()
    {
        level = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene(level);
    }
}
