using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
    public GameObject Book;
    public TextMeshProUGUI Text;
    public TextAsset TextFile;
    public GameObject[] buttons = new GameObject[3];


    private void Start()
    {
        Book.SetActive(false);
    }

    public void ShowHint()
    {
        Text.text = TextFile.text;
        Book.SetActive(true);
       
        foreach (GameObject buttonObject in buttons)
        {
            buttonObject.SetActive(false);
        }
    }

    public void GoBack()
    {
        
        foreach (GameObject buttonObject in buttons)
        {
            buttonObject.SetActive(true);
        }
        Book.SetActive(false);
        
    }
}

