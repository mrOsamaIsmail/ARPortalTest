using UnityEngine;
using UnityEngine.Rendering;

public class PortalBehavior : MonoBehaviour
{
    [SerializeField] CompareFunction OnEnterFunction;
    [SerializeField] CompareFunction OnExitFunction;
    [SerializeField] CullMode OnEnterCullMode;
    [SerializeField] CullMode OnExitCullMode;
    [SerializeField] MeshRenderer _360WorldRenderer;
    [SerializeField] MeshRenderer _PortalRenderer;
    [SerializeField] string CameraTag;
    Material _360WorldMaterial;
    Material _PortalMaterial;
    bool isInside = false;
    void Awake()
    {
        _360WorldMaterial = _360WorldRenderer.material;
        _PortalMaterial = _PortalRenderer.material;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(CameraTag))
            return;
        isInside = !isInside;

            _PortalMaterial.SetInt("_CullFace", (int)OnEnterCullMode);
        if (isInside)
        {
            _360WorldMaterial.SetInt("_StencilOP", (int)OnEnterFunction);
        }
        else
        { 
            _360WorldMaterial.SetInt("_StencilOP", (int)OnExitFunction);
        }
    }

    private void OnTriggerExit(Collider other)
    {
            _PortalMaterial.SetInt("_CullFace", (int)OnExitCullMode);

    }
}
