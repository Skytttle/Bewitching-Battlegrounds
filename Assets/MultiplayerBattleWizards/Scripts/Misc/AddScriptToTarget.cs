using UnityEngine;
using UnityEngine.UI;

public class AddScriptOnButtonClick : MonoBehaviour
{
    [Header("Settings")]
    public GameObject targetObject; // The GameObject to add the script to.
    public string scriptName;       // The name of the script to add (must match the script's class name).
    public Button button;           // The UI Button to trigger the action.

    void Start()
    {
        // Ensure the button is assigned and add a listener for the click event
        if (button != null)
        {
            button.onClick.AddListener(AddScriptToTarget);
        }
        else
        {
            Debug.LogError("No button assigned. Please assign a UI Button in the Inspector.");
        }
    }

    void AddScriptToTarget()
    {
        // Ensure the target object is assigned
        if (targetObject == null)
        {
            Debug.LogError("No target object assigned. Creating a new GameObject.");
            targetObject = new GameObject("NewTargetObject");
        }

        // Check if the script is already attached
        if (targetObject.GetComponent(scriptName) != null)
        {
            Debug.LogWarning($"The script '{scriptName}' is already attached to the target object.");
            return;
        }

        // Dynamically add the script by name
        System.Type scriptType = System.Type.GetType(scriptName);

        if (scriptType == null)
        {
            Debug.LogError($"The script '{scriptName}' was not found. Ensure the name matches the class exactly.");
            return;
        }

        targetObject.AddComponent(scriptType);
        Debug.Log($"The script '{scriptName}' has been added to '{targetObject.name}'.");
    }
}
