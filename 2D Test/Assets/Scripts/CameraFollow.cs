using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   public Transform target;

   public float smoothSpeed = 12.5f;
   public Vector3 offset;

   private void LateUpdate()
   {
      //Vector3 desiredPosition = target.position + offset;

      //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
      //transform.position = smoothedPosition;
      transform.position = new Vector3(target.position.x + offset.x, /*target.position.y +*/ offset.y, offset.z);

      //transform.LookAt(target);
   }
}
