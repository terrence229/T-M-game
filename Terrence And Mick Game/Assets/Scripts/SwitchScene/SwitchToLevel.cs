using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToLevel : MonoBehaviour
{
    private FadeInAndOut _fade;

    public void Start()
    {
        _fade = GameObject.Find("FadeAway").GetComponent<FadeInAndOut>();
    }

    //switch to 2d platformer
    public void To2DPlatformer()
    {
        _fade.FadeToLevel("2DPlatformer");
    }

    //switch to shooter
    public void ToShooter()
    {
        _fade.FadeToLevel("Shooter");
    }


    //if collision with portal, To2DPlatformer()/shooter() etc.........
}
