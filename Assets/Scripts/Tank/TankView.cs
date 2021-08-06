using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image), typeof(Rigidbody2D))]
public class TankView : MonoBehaviour
{
    public TankType tankType;
    // private Image image;
    // public BulletController bulletController;
    private void Awake()
    {
        // image = GetComponent<Image>();
        // if (image == null)
        // {
        //     Debug.LogError("image not found");
        // }
        // bulletController = GetComponent<BulletController>();
    }
    private void Start()
    {
        Debug.Log("Tank view created");
        // if (image != null)
        // {
        //     // Update Sprite
        // }
    }

    private void Update()
    {
        Vector2 position2 = (Vector2)transform.position;
        Vector3 position3 = SetZ(transform.position, 0f);
        Vector3 position4 = transform.position.SetZ(0f);
        transform.position.RemoveYZ();

        VectorExtensions.SetZNew(transform.position, 0f);
    }

    private static Vector3 SetZ(Vector3 vector, float newZ)
    {
        return new Vector3(vector.x, vector.y, newZ);
    }
}
