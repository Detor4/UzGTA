using Unity.Netcode;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] Rigidbody _rb;
    [SerializeField] private Camera _camera;
    [SerializeField] Canvas _canvas;

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

    /*private void Update()
    {
        var dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _rb.velocity = dir * _speed;

       
    }*/

    public void TestButton()
    {
        transform.Translate(new Vector3(10f, 0, 0));
    }

    



}