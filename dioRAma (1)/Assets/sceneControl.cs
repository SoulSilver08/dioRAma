using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class sceneControl : MonoBehaviour
{
    //[SerializeField] Slider scale;
    [SerializeField] Slider scale;
    [SerializeField] GameObject Dio;
    public void loadForest() 
    {
        SceneManager.LoadScene(2);
    }

    public void loadCity()
    {
        SceneManager.LoadScene(1);
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void scaleValue() 
    {
        Dio.GetComponent<Transform>().localScale = new Vector3(scale.value, scale.value, scale.value);
    }
}
