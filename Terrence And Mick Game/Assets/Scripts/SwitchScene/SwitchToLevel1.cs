using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToLevel1 : MonoBehaviour
{
    private FadeInAndOut _fade;

    public void Start()
    {
        _fade = GameObject.Find("FadeAway").GetComponent<FadeInAndOut>();
    }

    public void To2DPlatformer()
    {
        _fade.FadeToLevel("2DPlatformer");
    }

    //if collision with portal, To2DPlatformer();
}
