using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInAndOut : MonoBehaviour
{
    public Animator animator;
    private SceneSwitcher _sceneSwitcher;
    public string nextScene;

    public void Start()
    {
        _sceneSwitcher = new SceneSwitcher();
    }

    public void FadeToLevel(string nextSceneName)
    {
        //saves the name of the next scene in a variable
        nextScene = nextSceneName;

        //trigger to play animation
        animator.SetTrigger("FadeAway");
    }

    public void OnFadeComplete() //AnimationEvent after fade out animation finishes
    {
        //switch scene
        _sceneSwitcher.LoadScene(nextScene);
    }
}
