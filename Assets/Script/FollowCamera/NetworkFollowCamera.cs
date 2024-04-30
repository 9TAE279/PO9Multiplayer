using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using Unity.Netcode;
using Cinemachine;

public class NetworkFollowCamera :NetworkBehaviour
{
    [SerializeField] GameObject cameraRoot;
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
     
        FollowCamera();
       

    }
    void FollowCamera()
    {
        if (!IsOwner) { return; }
        cameraRoot = GameObject.Find("PlayerCameraRoot");
        Debug.Log("wowowow");
        if (cameraRoot != null)
            cameraRoot = GameObject.Find("PlayerCameraRoot");
        if (virtualCamera.Follow == null && IsOwner)
        {
            virtualCamera.Follow = cameraRoot.transform;
        }

    }
}
