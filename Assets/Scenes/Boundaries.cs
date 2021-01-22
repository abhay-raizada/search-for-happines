using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z)
        );
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 viewPos = transform.position;
        Debug.Log("transform position x = " + viewPos.x + "TransformPsoition y =" + viewPos.y + "Screenbound = " + screenBounds);
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x *-1, screenBounds.x);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1, screenBounds.y);
        Debug.Log("New transform position x = " + viewPos.x + "New TransformPsoition y =" + viewPos.y);
        transform.position = viewPos;
    }
}
