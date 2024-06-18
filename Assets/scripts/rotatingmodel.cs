using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatingmodel : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationMin = 0.0f;
    public float rotationMax = 45.0f;
    public Slider rotateslider;

    [SerializeField] float currentRotation = 0f;
    void Start() 
    {
        rotateslider = GameObject.Find("rotateslider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0.0f, rotateslider.value, 0.0f);
    }

    private void OnGUI()
    {
        currentRotation = GUI.HorizontalSlider(new Rect(-280f, 165.0f, 228.0f, 57.0f), currentRotation, 0.0f, 45.0f);
        transform.localEulerAngles = new Vector3(0.0f, currentRotation, 0.0f);
        /*currentRotation= GUI.HorizontalSlider(new Rect(-230f, 165.0f, 0f, 57.0f),currentScal)*/
    }
    public void AdjustAngle(float angle)
    {

    }
}
