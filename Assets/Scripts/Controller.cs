using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 MousePosition;
    public LayerMask whatIsGround;
    public GameObject boomClone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D overCollider2d = Physics2D.OverlapCircle(MousePosition, 0.01f, whatIsGround);
            if (overCollider2d != null)
            {
                overCollider2d.transform.GetComponent<Ground>().MakeDot(MousePosition);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            MousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Instantiate(boomClone, MousePosition, Quaternion.identity); 
        }
    }
}
