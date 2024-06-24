using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody rigid;
    public float jumpForce;
    private bool enableJump = false;
    int enabledou = 0;
    public float moveSpeed;
    public Transform HeadPivot;
    public float rotateXSpeed ;
    public float rotateYSpeed ;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 moveVector = Vector3.zero;
        if(Input.GetKey(KeyCode.W)){
            moveVector += Vector3.forward;

        }
        if(Input.GetKey(KeyCode.S)){
            moveVector += Vector3.back;

        }
        if(Input.GetKey(KeyCode.A)){
            moveVector += Vector3.left;

        }
        if(Input.GetKey(KeyCode.D)){
            moveVector += Vector3.right;

        }
        moveVector.Normalize();
        transform.Translate(moveVector*(moveSpeed*Time.deltaTime));
        //rotate
        Vector3 headRotation = HeadPivot.localEulerAngles;
        if(headRotation.x < 260f &&headRotation.x > 40f){
            float big = Mathf.Abs(headRotation.x - 260f);
            float small = Mathf.Abs(headRotation.x - 40f);
            if(big < small ){
                HeadPivot = f;
            }else if(small < big){
                HeadPivot = 40f;
            }
        }
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * rotateXSpeed*Time.deltaTime);
        HeadPivot.Rotate(Vector3.left, Input.GetAxis("Mouse Y") * rotateYSpeed*Time.deltaTime);
        

        
        // if(headRotation.x > 90f && headRotation.x< 270f) headRotation.x = 90f;
        // HeadPivot.localEulerAngles = headRotation;
        if(Input.GetKeyDown(KeyCode.Space)&&enabledou < 2){
            rigid.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            enabledou++;
            
        } 
            
    
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == 6){//비트 플레그? 6번째만 활성화
            enabledou = 0;
        }
        
    }
}
