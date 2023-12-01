using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovement : MonoBehaviour
{
    public float CharacterSize;
    public float speed;
    public float JumpHight;
    private new Rigidbody2D rigidbody;
    private GameObject mobileCanvas;

    public Animator animator;
    private float velocityRef;
    float directionX;
    public float smoothTime;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        mobileCanvas = GameObject.FindGameObjectWithTag("MobileCanvas");
        if (SystemInfo.deviceType == DeviceType.Desktop)
            mobileCanvas.SetActive(false);

        if (SystemInfo.deviceType == DeviceType.Handheld)
            mobileCanvas.SetActive(true);

    }


    void Update()
    {

        if(SystemInfo.deviceType == DeviceType.Desktop)
        {
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxisRaw("Jump") > 0.001f && Mathf.Abs(rigidbody.velocity.y) < 0.001F) 
        {
            rigidbody.AddForce(new Vector2(rigidbody.velocity.x, JumpHight), ForceMode2D.Impulse);
        }


        if(Input.GetAxisRaw("Horizontal") < 0) 
        {
            characterScale.x = CharacterSize * -1;
            characterScale.y = CharacterSize;
        }
        if (Input.GetAxisRaw("Horizontal") > 0) 
        {
            characterScale.x = CharacterSize;
            characterScale.y = CharacterSize;
        }
        transform.localScale = characterScale;
        float directionX = Input.GetAxis("Horizontal"); 
        rigidbody.velocity = new Vector2(directionX * speed, rigidbody.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(directionX));
        }



        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            Vector3 characterScale = transform.localScale;
            if (CrossPlatformInputManager.GetAxisRaw("Jump") > 0.001f && Mathf.Abs(rigidbody.velocity.y) < 0.001F)
            {
                rigidbody.AddForce(new Vector2(rigidbody.velocity.x, JumpHight), ForceMode2D.Impulse);
            }


            if (CrossPlatformInputManager.GetAxisRaw("Horizontal") < 0)
            {
                characterScale.x = CharacterSize * -1;
                characterScale.y = CharacterSize;
            }
            if (CrossPlatformInputManager.GetAxisRaw("Horizontal") > 0)
            {
                characterScale.x = CharacterSize;
                characterScale.y = CharacterSize;
            }
            transform.localScale = characterScale;
            directionX = Mathf.SmoothDamp(directionX, CrossPlatformInputManager.GetAxisRaw("Horizontal"), ref velocityRef, smoothTime);
            rigidbody.velocity = new Vector2(directionX * speed, rigidbody.velocity.y);
            animator.SetFloat("speed", Mathf.Abs(directionX));
        }


    }
        private void OnCollisionEnter2D()  //hier ändern, falls andere Collisions existieren, die keine Platform sind
        {
        animator.SetBool("isJumping", false);
        }

        private void OnCollisionExit2D()
        {
        animator.SetBool("isJumping", true);
        }
}
        

     
    
