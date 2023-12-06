using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text[] Texts;
    public Animator animator;
    private int CurrentText = 0;

    private void Start()
    {
        animator.SetTrigger("UnGrow");
    }
    // Update is called once per frame
    private void OnMouseDown()
    {
        CurrentText++;
        NextText();
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
        SceneManager.LoadScene("Hints");
    }
}
