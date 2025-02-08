using UnityEngine;
using UnityEngine.Rendering;

public class PortalBehavior : MonoBehaviour
{
    [SerializeField] CompareFunction OnEnterFunction;
    [SerializeField] CompareFunction OnExitFunction;
    [SerializeField] MeshRenderer _360WorldRenderer;
    Material _360WorldMaterial;
    bool isInside = false;
    void Awake()
    {
        _360WorldMaterial = _360WorldRenderer.material;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        isInside = !isInside;

        if (isInside)
            _360WorldMaterial.SetInt("_StencilOP", (int)OnEnterFunction);
        else
            _360WorldMaterial.SetInt("_StencilOP", (int)OnExitFunction);
    }
}
