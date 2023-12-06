using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text[] Texts;
    private int CurrentText = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CurrentText++;
            NextText();
        }
    }

    private void NextText()
    {
        if (CurrentText < Texts.Length)
        {
            for (int i = 0; i < Texts.Length; i++)
            {
                if (Texts[CurrentText] != null)
                {
                    if (CurrentText - 1 > -1)
                    {   
                        Texts[CurrentText - 1].enabled = false;
                    }
                    Texts[CurrentText].enabled = true;
                }
            }
        }
    }

    public void ToHints()
    {
        Debug.Log("hello");
        SceneManager.LoadScene("Hints");
    }
}
