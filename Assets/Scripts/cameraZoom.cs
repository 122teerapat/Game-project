using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    private float zoom;
    private float zoomMultiplier = 4f;
    private float minZoom = 0.8f;
    private float maxZoom = 2f;
    private float zoomVelocity = 0f;
    private float smoothTime = 0.50f;

    private Vector3 offset = new Vector3(0.0f, 0.0f, -10f);
    private Vector3 velocity = Vector3.zero;


    [SerializeField] private turnController turnController;
    [SerializeField] private Camera cam;
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    void Start()
    {
        zoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (turnController.player1Active && zoom < 1.5f)
        {
            Vector3 targetPosition = player1.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
        else if (!turnController.player1Active && zoom < 1.5f)
        {
            Vector3 targetPosition = player2.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            zoom = 1.9f;
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(0.0f, 0.0f, -10f), ref velocity, 0.20f);
        }

        if (zoom > maxZoom - 0.5)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(0.0f, 0.0f, -10f), ref velocity, smoothTime);
        }


        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom -= scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref zoomVelocity, smoothTime);
        */
    }
}
