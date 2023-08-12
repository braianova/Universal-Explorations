using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private bool isHovering = false;
    private GUIStyle guiStyle = new GUIStyle();

    // This method is called when the mouse enters the object's collider
    private void OnMouseEnter()
    {
        isHovering = true;
    }

    // This method is called when the mouse exits the object's collider
    private void OnMouseExit()
    {
        isHovering = false;
    }

    // This method is called every frame
    private void OnGUI()
    {
        if (isHovering)
        {
            guiStyle.fontSize = 24;
            guiStyle.normal.textColor = Color.white;

            Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position + transform.up * 0.5f); // Adjust the offset based on the object's position on the sphere
            GUI.Label(new Rect(screenPosition.x, Screen.height - screenPosition.y, 200, 50), "Hovering over object", guiStyle);
        }
    }
}
