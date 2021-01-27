using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondGameManager : MonoBehaviour
{

    public GameObject maincamera;
    public GameObject camera;
    public Button reset;
    public Button first;
    public Button second;
    void Start()
    {
        maincamera.SetActive(true);
        camera.SetActive(false);
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

        camera.SetActive(true);
           
    }
    void SecondButton()
    {
        camera.SetActive(true);
      
    }
}


    

