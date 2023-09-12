using UnityEngine.SceneManagement;
using UnityEngine;

public class levelcomplete : MonoBehaviour
{
    public void Loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
