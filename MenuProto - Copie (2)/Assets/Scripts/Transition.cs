using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator animator;
    public void LoadScene()
    {
        if (SceneManager.GetActiveScene().buildIndex < 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
        }
    }

    private void OnMouseDown()
    {
        Debug.Log("hello");
        animator.SetTrigger("Grow");
        Debug.Log("bye");
    }
 
}
