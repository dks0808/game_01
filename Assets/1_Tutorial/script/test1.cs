using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    private Transform trans; //private �� �������൵ ����Ʈ�� ������ �����̺���
    private Vector3 move = new Vector3(0f, 0f,0f); //�ۺ��� ���ζ���� �ܺ� �������� ����
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        Debug.Log("Test Log");
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.W)){
            move = new Vector3(-0.5f*speed*Time.deltaTime, 0f, 0.5f*speed*Time.deltaTime); //deltaTime�� �����༭ �ð��� �� ������ ������ ������ sec
        }
        else if(Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.D)){
            move = new Vector3(0.5f*speed*Time.deltaTime, 0f, 0.5f*speed*Time.deltaTime); //deltaTime�� �����༭ �ð��� �� ������ ������ ������ sec
        }
        else if(Input.GetKey(KeyCode.S)&&Input.GetKey(KeyCode.A)){
            move = new Vector3(-0.5f*speed*Time.deltaTime,0f,-0.5f*speed*Time.deltaTime); //deltaTime�� �����༭ �ð��� �� ������ ������ ������ sec
        }
        else if(Input.GetKey(KeyCode.S) &&Input.GetKey(KeyCode.D) ){
            move = new Vector3(0.5f*speed*Time.deltaTime,0f,-0.5f*speed*Time.deltaTime); //deltaTime�� �����༭ �ð��� �� ������ ������ ������ sec
        }
        else if(Input.GetKey(KeyCode.W)){
            move = new Vector3(0f,0f,speed* Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A)){
            move = new Vector3(-speed*Time.deltaTime,0f,0f);
        }
        else if(Input.GetKey(KeyCode.D)){
            move = new Vector3(speed*Time.deltaTime,0f,0f);
        }
        else if(Input.GetKey(KeyCode.S)){
            move = new Vector3(0f,0f,-speed*Time.deltaTime); //deltaTime�� �����༭ �ð��� �� ������ ������ ������ sec
        }
        else{
            move = new Vector3(0f,0f,0f);
        }
        trans.Translate(move);
    }
}
