using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrowButton : MonoBehaviour
{
    public bool actif = false;

    [SerializeField]
    Animator animator;

   
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Grow()
    {
        animator.SetTrigger("Grow");
    }

}
