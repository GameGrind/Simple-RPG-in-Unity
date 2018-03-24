using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

[ExecuteInEditMode]
public class CameraController : MonoBehaviour {
    public float PlayerCameraDistance { get; set; }
    public Transform cameraTarget;

    Camera playerCamera;
    float zoomSpeed = 35f;

    void Start()
    {
        PlayerCameraDistance = 12f;
        playerCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Mouse ScrollWheel") != 0 && !EventSystem.current.IsPointerOverGameObject())
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            playerCamera.fieldOfView -= scroll * zoomSpeed;
            playerCamera.fieldOfView = Mathf.Clamp(playerCamera.fieldOfView, 0, 180);
        }

        transform.position = new Vector3(cameraTarget.position.x, cameraTarget.position.y + PlayerCameraDistance, cameraTarget.position.z - PlayerCameraDistance);
    }
}
