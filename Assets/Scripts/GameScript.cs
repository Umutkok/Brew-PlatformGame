using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public float transitionDuration = 4f;
    public float autoTransitionDelay = 5f;
    public RawImage blackoutImage;

    void Start()
    {
        StartCoroutine(StartAutoTransition());
    }

    IEnumerator StartAutoTransition()
    {
        yield return new WaitForSeconds(autoTransitionDelay);

        float t = 0f;
        Color startingColor = blackoutImage.color;
        Color targetColor = new Color(0f, 0f, 0f, 1f);

        while (t < 1)
        {
            blackoutImage.color = Color.Lerp(startingColor, targetColor, t);
            t += Time.deltaTime / transitionDuration;
            yield return null;
        }

    }
}