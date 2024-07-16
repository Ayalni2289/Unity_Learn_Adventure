using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    float horizontal = 0.0f;
    float vertical = 0.0f;
    if (Keyboard.current.leftArrowKey.isPressed)
    {
        horizontal = -.10f;
 	    }
    else if (Keyboard.current.rightArrowKey.isPressed)
    {
        horizontal = .10f;
    }
    if(Keyboard.current.upArrowKey.isPressed)
    {
        vertical = .10f;
    }
    else if(Keyboard.current.downArrowKey.isPressed)
    {
        vertical = -.10f;
    }
    Debug.Log(horizontal);
    Debug.Log(vertical);


    Vector2 position = transform.position;
    position.y = position.y + 0.1f * vertical;
    position.x = position.x + 0.1f * horizontal;
    transform.position = position;
}

}
