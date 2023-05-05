using System;
using Mirage;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerColorSetter : NetworkBehaviour
{
    [SyncVar(hook = nameof(UpdateMaterialColor))]
    public Color generatedColor;

    public float from = 0.3f;
    public float to = 0.8f;

    public MeshRenderer renderer;

    private void Awake()
    {
        Identity.OnStartServer.AddListener(InitializeColor);
    }

    public Color GetRandomColor()
    {
        return new Color
        {
            r = Random.Range(from, to),
            g = Random.Range(from, to),
            b = Random.Range(from, to),
            a = 1
        };
    }

    private void InitializeColor()
    {
        generatedColor = GetRandomColor();
    }

    private void UpdateMaterialColor(Color _, Color newValue)
    {
        generatedColor = newValue;
        renderer.material.color = newValue;
    }
}
