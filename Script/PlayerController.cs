using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    [SerializeField]
    private float Speed;

    [SerializeField]
    private float lookSensitivity;

    [SerializeField]
    private float applySpeed;


    [SerializeField]
    private float cameraRotationLimit;
    private float currentCameraRotationX = 0;
    private float currentCameraRotationY = 0;

    [SerializeField]
    private Camera theCamera;
    [SerializeField]
    private Rigidbody myRigid;

    private GameObject canvas;
    

    // Use this for initialization
    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        canvas = GameObject.Find("Canvas");
        
    }

    // Update is called once per frame
    void Update()
    {
        canvas.SetActive(true);
        Move();
        if (Input.GetMouseButton(1))
        {
            canvas.SetActive(false);
            CameraRotation();
            //cameraMove();
        }
        

    }

    private void Move()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void CameraRotation()
    {
        // 상하 카메라 회전
        float _xRotation = Input.GetAxisRaw("Mouse Y");
        float _yRotation = Input.GetAxisRaw("Mouse X");
        float _cameraRotationX = _xRotation * lookSensitivity;
        float _cameraRotationY = _yRotation * lookSensitivity;
        currentCameraRotationX -= _cameraRotationX;
        currentCameraRotationY += _cameraRotationY;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);
        currentCameraRotationY = Mathf.Clamp(currentCameraRotationY, -cameraRotationLimit, cameraRotationLimit);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, currentCameraRotationY, 0f);
    }

    //private void cameraMove()
    //{
    //    float _moveDirX = Input.GetAxisRaw("Horizontal");
    //    float _moveDirZ = Input.GetAxisRaw("Vertical");

    //    Vector3 _moveHorizontal = transform.right * _moveDirX;
    //    Vector3 _moveVertical = transform.forward * _moveDirZ;

    //    Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * applySpeed;

    //    myRigid.MovePosition(transform.position + _velocity * Time.deltaTime);
    //}


}



