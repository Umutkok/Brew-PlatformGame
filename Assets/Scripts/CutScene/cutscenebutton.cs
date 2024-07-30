using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscenebutton : MonoBehaviour
{
    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
