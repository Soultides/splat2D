using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoadButton : MonoBehaviour
{
    public Texture2D fadeOutTexture;
    public Button levelChangeButton;
    public float fadeInSpeed = 0.8f;
    public float fadeOutSpeed = 0.8f;
    public bool fadeIn = true;
    public bool fadeOut = true;

    private float fadeSpeed = 0.8f;
    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    public string level;
    public float time;

    private bool allowLoad = false;
    private double loadtime = 0;
    private bool fadingOut = false;
    //private bool loadScene = false;



    void Start()
    {
        fadeSpeed = fadeInSpeed;
    }

    public void Wrapper()
    {
        StartCoroutine(LevelLoad());
    }



    IEnumerator LevelLoad()
    {
        //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        //watch.Start();


        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        stopwatch.Start();

        AsyncOperation async = SceneManager.LoadSceneAsync(level);
        async.allowSceneActivation = false;

        while (async.progress < 0.9f)
        {
            yield return null;
        }
        stopwatch.Stop();
        loadtime = stopwatch.Elapsed.TotalSeconds;
        allowLoad = false;
        StartCoroutine(Timer());

        while (!allowLoad)
        {
            yield return null;
        }

        async.allowSceneActivation = true;
    }

    IEnumerator Timer()
    {
        float wait = time - (float)loadtime;
        if (wait > 0)
        {
            yield return new WaitForSeconds(time);
        }
        if (fadeOut)
        {
            alpha = 0;
            fadingOut = true;
            fadeSpeed = fadeOutSpeed;
            BeginFade(1);
        }
        else
        {
            allowLoad = true;
        }

    }

    void OnGUI()
    {
        if (fadeIn || fadingOut)
        {
            alpha += fadeDir * fadeSpeed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);

            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
            GUI.depth = drawDepth;
            if (alpha >= 1 && fadingOut == true)
            {
                allowLoad = true;
            }
        }
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnLevelWasLoaded()
    {
        if (fadeIn)
        {
            alpha = 1;
            fadeSpeed = fadeInSpeed;
            BeginFade(-1);
        }
    }
}