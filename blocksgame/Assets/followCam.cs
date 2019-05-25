
using UnityEngine;

public class followCam : MonoBehaviour
{
    public Transform player;
    public Vector3 offest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offest;
    }
}
