using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    // Reference to the GameObject you want to toggle
    public GameObject targetObject;

    // Key to toggle the GameObject
    public KeyCode toggleKey = KeyCode.T;

    void Update()
    {
        // Check if the key is pressed
        if (Input.GetKeyDown(toggleKey))
        {
            // Toggle the active state of the targetObject
            if (targetObject != null)
            {
                targetObject.SetActive(!targetObject.activeSelf);
            }
            else
            {
                Debug.LogWarning("Target Object is not assigned!");
            }
        }
    }
}
