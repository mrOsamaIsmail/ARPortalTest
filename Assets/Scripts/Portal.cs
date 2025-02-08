using UnityEngine;

public class Portal : MonoBehaviour
{

   [SerializeField] Camera renderingCam;
   [SerializeField] Camera portalCam;
   [SerializeField] bool useMainCamera;
   [SerializeField] Transform PortalPt1;
   [SerializeField] Transform PortalPt2;
    private void Awake()
    {
        if(useMainCamera)
            renderingCam = Camera.main;
    }

    private void Update()
    {
        AllignCamToView();
    }

    void AllignCamToView() 
    {
        // get the local tranformation matrix of the camera relative to the portal it's facing (assume Pt1 for now)
        Matrix4x4 camRelativeToPt1 = PortalPt1.worldToLocalMatrix * renderingCam.transform.localToWorldMatrix;

        portalCam.transform.position = (PortalPt2.transform.localToWorldMatrix) * (camRelativeToPt1).GetColumn(3);
        portalCam.transform.rotation = (renderingCam.transform.rotation);
    }
}
