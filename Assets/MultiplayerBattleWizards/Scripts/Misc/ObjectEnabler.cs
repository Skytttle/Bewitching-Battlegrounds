using UnityEngine;

public class ObjectEnabler : MonoBehaviour
{
    // Reference to the GameObject to enable
    public GameObject targetObject;

    // Public method to enable the GameObject
    public void EnableObject()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Target Object is not assigned!");
        }
    }
}
