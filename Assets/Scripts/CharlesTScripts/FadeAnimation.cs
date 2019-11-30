using UnityEngine;

public class FadeAnimation : MonoBehaviour
{

    public Animator fadeAnimator;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayFadeIn()
    {
        fadeAnimator.SetBool("PlayFade", true);
    }

    public void PlayFadeOut()
    {
        fadeAnimator.SetBool("PlayFade", false);
    }
}
