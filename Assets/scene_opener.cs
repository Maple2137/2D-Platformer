using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_opener : MonoBehaviour
{
    public string sceneName;
    public void OpenScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
