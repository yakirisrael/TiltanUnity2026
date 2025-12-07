using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       bool keyPressed = Input.GetKey(KeyCode.D);
       Debug.Log(keyPressed);
       if (keyPressed)
       {
           transform.position += new Vector3(0.1f, 0, 0);
       }
    }
}
