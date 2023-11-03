using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    public GameObject parent; // Assign the "parent" object in the Unity Inspector

    private void Start()
    {
        // Ensure that the "parent" object is assigned
        if (parent == null)
        {
            Debug.LogError("Parent object is not assigned. Please assign it in the Inspector.");
            return;
        }
    }
        // Function to toggle the mesh renderer of child objects "a1" and "a2"
    public void ToggleMeshRenderers(bool isActive, string name)
    {
        foreach (Transform child in parent.transform)
        {
            if (child.name == "zap")
            {
                foreach (Transform zapChild in child.transform)
                {
                    if (zapChild.name == name)
                    {
                        MeshRenderer meshRenderer = zapChild.GetComponent<MeshRenderer>();
                        if (meshRenderer != null)
                        {
                            meshRenderer.enabled = isActive;
                        }
                    }
                }
            }
        }
    }

    public void showOn(){
        Debug.Log("OnWorks");
        ToggleMeshRenderers(false, "a1");
    }

    public void showOff(){
        Debug.Log("OffWorks");
        ToggleMeshRenderers(true, "a1");
    }
}

