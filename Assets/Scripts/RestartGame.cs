using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
