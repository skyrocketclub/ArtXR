using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class XRGrabNetworkInteractable : XRGrabInteractable
{
    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //dynamically changing ownership of game objects when grabbed in multiplayer instances...
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        photonView.RequestOwnership();
        base.OnSelectEntering(args);
    }
}
