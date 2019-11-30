using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator fadeAnimator;
    private int levelToLoad;

    // FadeToLevel( int ); 
    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        fadeAnimator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
