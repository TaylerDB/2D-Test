using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField]
   private float moveRight;
   [SerializeField]
   private float moveLeft;
   [SerializeField]
   private float jumpHeight;

   // Start is called before the first frame update
   void Start()
   {
        
   }

   // Update is called once per frame
   void Update()
   {
        
   }

   void FixedUpdate()
   {
      if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
      {
         transform.Translate(new Vector2(moveRight * Time.fixedDeltaTime, 0));
         
         // Rotates player according to local coordinate
         transform.eulerAngles = new Vector3(0, 0, 0);
      }

      if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
      {
         transform.Translate(new Vector2(moveLeft * Time.fixedDeltaTime, 0));

         // Rotates player 180 on Y axis according to local coordinate
         //transform.Rotate(0, 180, 0, Space.Self);
         transform.eulerAngles = new Vector3(0, 180, 0);
      }
      
      if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
      {
         Debug.Log("Jump!");
         transform.Translate(new Vector2(0, jumpHeight * Time.fixedDeltaTime));
         //rigidbody2D.velocity = Vector2.up * jumpHeight;
         //transform.Translate(new Vector2(0, jumpHeight));
      }

   }


}
