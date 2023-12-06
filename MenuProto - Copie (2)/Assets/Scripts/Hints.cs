using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
    public GameObject[] Image;
    public TextMeshProUGUI[] Text;
    public TextAsset[] TextFile = new TextAsset[9];
    public GameObject[] buttons = new GameObject[3];
    private int CurrentHint = -1;
    public int CurrentShit;
    public Animator animator;


    private void Start()
    {
        animator.SetTrigger("UnGrow");
        Image[CurrentShit].SetActive(false);
    }

    public void ShowHint(int j)
    {
        CurrentShit = j;
        NextHint(j * 3);
        Image[CurrentShit].SetActive(true);

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
        Image[CurrentShit].SetActive(false);

    }

    public void NextHint(int h)
    {
        CurrentHint = CurrentHint < h + 2 && CurrentHint >= h ? CurrentHint + 1 : h;
        Debug.Log(CurrentHint);
        Text[CurrentShit].text = TextFile[CurrentHint].text;
    }
}
