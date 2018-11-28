
using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public Transform player;
    public Transform camera;
    public Vector3 offset;
    
    private void Start()
    {
          offset = camera.position - player.position;    
    }
    // Update is called once per frame
    void Update () {
        transform.position = player.position + offset;
	}
}
