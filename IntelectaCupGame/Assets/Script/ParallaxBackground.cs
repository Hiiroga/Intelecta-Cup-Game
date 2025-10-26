using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [Header("Parallax Settings")]
    public Camera cam;
    public float parallaxEffect = 0.3f;

    private Vector3 lastCamPos;

    private void Start()
    {
        if (cam == null)
            cam = Camera.main;
        lastCamPos = cam.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cam.transform.position - lastCamPos;
        transform.position += deltaMovement * parallaxEffect;
        lastCamPos = cam.transform.position;
    }
}
