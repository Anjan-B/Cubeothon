using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
