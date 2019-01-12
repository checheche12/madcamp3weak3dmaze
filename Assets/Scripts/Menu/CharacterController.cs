using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterController : NetworkBehaviour
{
    public GameObject Player;
    public Camera PlayerCamera;
    public Vector3 DifferPlayerAndCamera;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            PlayerCamera.enabled = false;
            return;
        }

        var x = 0.0f;
        var z = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x =  Time.deltaTime * 50.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = -1 * Time.deltaTime * 50.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z = Time.deltaTime * 50.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z = -1 * Time.deltaTime * 50.0f;
        }
        var a = new Vector3(z, 0, 0);
        PlayerCamera.transform.Rotate(0, 0, x);
        PlayerCamera.transform.RotateAround(Player.transform.position , a, 10.0f );

    }

    [Command]
    void CmdMove(float x, float z)
    {
        
    }

    public override void OnStartLocalPlayer()
    {
        Player.GetComponent<MeshRenderer>().material.color = Color.blue;
    }

}
