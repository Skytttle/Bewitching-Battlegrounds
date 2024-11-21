using UnityEngine;

public class Toggle2 : MonoBehaviour
{
    // Reference to the GameObject you want to toggle
    public GameObject targetObject;

    // Key to toggle the GameObject
    public KeyCode toggleKey = KeyCode.T;

    // Tracks whether external scripts have disabled the object
    private bool externallyDisabled = false;

    void Update()
    {
        // Check if the key is pressed
        if (Input.GetKeyDown(toggleKey) && !externallyDisabled)
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

    // Public method to disable the object externally
    public void DisableExternally()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(false);
            externallyDisabled = true;
        }
    }

    // Public method to re-enable control from the script
    public void EnableControl()
    {
        externallyDisabled = false;
    }
}
