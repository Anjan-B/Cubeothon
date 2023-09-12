
using UnityEngine;

public class collision : MonoBehaviour
{
    public playermovement movement;
    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag == "obstrucal")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanger>().endgame();
        }
    }
}
