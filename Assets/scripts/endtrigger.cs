
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public gamemanger gamemanger;

    void OnTriggerEnter()
    {
        gamemanger.levelcomplete();
    }
}
