using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    public Vector3 cameraOffset = new Vector3(0f, 1.2f, -2.6f);
    private Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame

    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(cameraOffset);
        this.transform.LookAt(target);
    }
}
