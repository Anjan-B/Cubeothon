using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float forwordforce = 2000f;
    public float key = 500;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwordforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(key * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-key * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<gamemanger>().endgame();
        }
    }
}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    //variables
    public float moveSpeed = 120;
    public GameObject character;

    private Rigidbody rb;
    private float ScreenWidth;


    // Use this for initialization
    void Start()
    {
        ScreenWidth = Screen.width;
        rb = character.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        //loop over every touch found
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //move right
                RunCharacter(100f);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                //move left
                RunCharacter(-100f);
            }
            ++i;
        }
    }
    void FixedUpdate()
    {
#if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
#endif
    }

    private void RunCharacter(float horizontalInput)
    {
        //move player
        rb.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));

    }
}*/
