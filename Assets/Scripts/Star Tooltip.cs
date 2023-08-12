using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTooltip : MonoBehaviour
{
    private Camera mainCamera;
    private List<GameObject> starObjects;

    private void Start()
    {
        /* mainCamera = Camera.main;
        List<GameObject> starObjects = GetComponent<StarField>().starObjects; */
    }

    private void Update()
    {
        /* Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        
        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.collider.gameObject;
            Debug.Log(hitObject);
            int starIndex = starObjects.IndexOf(hitObject);
            Debug.Log(starIndex);

            if (starIndex != -1)
            {
                Debug.Log(starIndex);
                DisplayTooltip(starIndex);
            }
            else
            {
                HideTooltip();
            }
        }
        else
        {
            HideTooltip();
        } */
    }

    private void DisplayTooltip(int starIndex)
    {
        //StarDataLoader.Star star = GetComponent<StarField>().stars[starIndex];

        //string tooltipText = $"Name: HR {star.catalog_number}\n";
        //tooltipText += $"Distance: {Vector3.Distance(mainCamera.transform.position, starObjects[starIndex].transform.position):F2} units\n";
        //tooltipText += $"Magnitude: {star.magnitude:F2}";

        // You can display the tooltip text using your preferred method (UI Canvas, TextMesh, etc.).
        // For example, using UI Text on a Canvas:
        // tooltipTextComponent.text = tooltipText;
    }

    private void HideTooltip()
    {
        // Hide or clear the tooltip (e.g., set text to an empty string).
    }
}
