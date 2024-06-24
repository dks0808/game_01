using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigid;
    public float jumpForce;
    private bool enableJump = false;
    int enabledou = 0;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
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
    // private void OnCollisionExit(Collision other){
    //     if(other.gameObject.layer == 6){
    //         enableJump = false;
    //     }
    // }
}
