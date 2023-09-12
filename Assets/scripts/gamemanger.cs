using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanger : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject completelevelui;
    public void levelcomplete ()
    {
        completelevelui.SetActive(true);
    }
 public void endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("game over");
            Invoke("Restart", restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
