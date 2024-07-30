using System.Collections;
using UnityEngine;
using UnityEngine.UI;
// Type Writer Script, Author : witnn .

[RequireComponent(typeof(AudioSource))]
public class MetinYazýcý : MonoBehaviour
{
    public float delay = 0.1f;
    public AudioClip TypeSound;
    [Multiline]
    public string yazi;

    AudioSource audSrc;
    Text thisText;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
        thisText = GetComponent<Text>();

        StartCoroutine(TypeWrite());
    }

    IEnumerator TypeWrite()
    {
        foreach (char i in yazi)
        {
            thisText.text += i.ToString();

            audSrc.pitch = Random.Range(0.8f, 1.2f);
            audSrc.PlayOneShot(TypeSound);

            if (i.ToString() == ".") { yield return new WaitForSeconds(1); }
            else { yield return new WaitForSeconds(delay); }
        }
    }
}
