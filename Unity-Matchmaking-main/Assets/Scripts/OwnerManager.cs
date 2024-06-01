using UnityEngine;
using Unity.Netcode;

public class OwnerManager : NetworkBehaviour
{
    [SerializeField]
    Camera _camera;
    [SerializeField]
    Canvas _canvas;

    public override void OnNetworkSpawn()
    {
        if (!IsOwner)
        {
            enabled = false;
            _camera.enabled = false;
            _canvas.enabled = false;
            return;
        }
    }
}
