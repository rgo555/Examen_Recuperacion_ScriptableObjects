using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * horizontal * 8 * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PickableObjects pickable = other.gameObject.GetComponent<PickableObjects>();
        {
            if( pickable != null)
            {
                InventoryManager.Instance.AddWeapon(pickable.weapon);
                Destroy(other.gameObject);
            }
        }
    }
}
