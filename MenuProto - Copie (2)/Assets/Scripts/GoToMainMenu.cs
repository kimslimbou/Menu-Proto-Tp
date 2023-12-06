using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMainMenu : MonoBehaviour
{
    public Animator animatorT;
    public Animator animatorB;


    public float transitionTime = 1f;
    public void LoadScene(string sceneName)
    {
        animatorT.SetTrigger("start");
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator LoadAnim(string sceneName)
    {
        

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneName);

    }

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animatorB.SetTrigger("Grow");
        }
    }
}
