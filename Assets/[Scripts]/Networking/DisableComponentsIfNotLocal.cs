using System.Collections.Generic;
using Mirage;
using UnityEngine;

public class DisableComponentsIfNotLocal : NetworkBehaviour
{
    public List<MonoBehaviour> observedComponents = new List<MonoBehaviour>();
    
    private void Update()
    {
        bool shouldBeEnabled = Identity.IsLocalPlayer;

        foreach (var component in observedComponents)
        {
            component.enabled = shouldBeEnabled;
        }
    }
}
