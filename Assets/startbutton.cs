using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{
    public string sceneName;
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
