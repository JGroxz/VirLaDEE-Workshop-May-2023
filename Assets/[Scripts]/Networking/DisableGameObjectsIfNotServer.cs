using System.Collections.Generic;
using Mirage;
using UnityEngine;

public class DisableGameObjectsIfNotServer : NetworkBehaviour
{
    public List<GameObject> observedComponents = new List<GameObject>();

    private void Update()
    {
        bool shouldBeEnabled = Identity.IsServer;

        foreach (var go in observedComponents)
        {
            go.SetActive(shouldBeEnabled);
        }
    }
}