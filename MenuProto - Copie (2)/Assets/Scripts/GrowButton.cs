using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrowButton : MonoBehaviour
{
    [SerializeField]
    Animator animator;


    private void Start()
    {
        animator.SetTrigger("UnGrow");
    }

}
