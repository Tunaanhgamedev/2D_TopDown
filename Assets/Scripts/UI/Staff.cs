using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour, IWeapon
{
    private void Update()
    {
        MouseFollowWithOffset();
    }

    public void Attack()
    {
        Debug.Log("Staff attack");
        ActiveWeapon.Instance.ToggleIsAttacking(false);
    }

    private void MouseFollowWithOffset()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 playerScreenPos = Camera.main.WorldToScreenPoint(PlayerController.Instance.transform.position);

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;

        if(mousePos.x < playerScreenPos.x)
        {
            ActiveWeapon.Instance.transform.rotation = Quaternion.Euler(0, -180, angle);
        }    
        else
            {
                ActiveWeapon.Instance.transform.rotation = Quaternion.Euler(0, 0, angle);
            }
    }
}
