using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button reset;
    public Button first;
    public Button second;

    public GameObject camera1;
    public GameObject camera2;
    public GameObject maincamera;


    private void Start()
    {

        maincamera.SetActive(true);
        camera1.SetActive(false);
        camera2.SetActive(false);
        reset.onClick.AddListener(() => Restart());
        first.onClick.AddListener(() => FirstButton());
        second.onClick.AddListener(() => SecondButton());
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    void FirstButton()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        maincamera.SetActive(false);
    }
    void SecondButton()
    {
        maincamera.SetActive(false);
        camera1.SetActive(false);
        camera2.SetActive(true);
    }
}



