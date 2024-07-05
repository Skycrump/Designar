using UnityEngine;
using System.Collections;
using TMPro;

public class Y_Text : MonoBehaviour
{

    public GameObject GamePose1, GamePose2;
    public GameObject LenthY;
    public Vector3 position2, position1;
    Vector3 position_difference, pos_temp, size_temp;
    float C, B;

    private TextMeshPro textMeshPro;

    // Use this for initialization
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshPro component not found on " + gameObject.name);
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        position_difference = transform.position;
        pos_temp = transform.position;
        position1 = GamePose1.GetComponent<Pose>().pos; //GET COMPONENT FROM THE CUBE 1 
        position2 = GamePose2.GetComponent<Pose2>().pos2; // GET COMPONENT FROM CUBE 2 

        float distance = position1.y - position2.y;
        //GetComponent<TextMesh>().text = distance.ToString("f1");
        textMeshPro.text = distance.ToString("f1");


        pos_temp = LenthY.GetComponent<LinkPoseY>().pos_tempY;
        pos_temp = position2;
       // pos_temp.y = Mathf.Abs((position2.y - position1.y) / 2);
        transform.position = pos_temp;

    }


}
