using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainMenu : MonoBehaviour
{
    public Animator animator;


    public float transitionTime = 1f;
    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadAnim(sceneName));
    }

    IEnumerator LoadAnim(string sceneName)
    {
        animator.SetTrigger("start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneName);

    }
}
