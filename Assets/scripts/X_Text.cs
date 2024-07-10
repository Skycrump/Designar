using UnityEngine;
using System.Collections;
using TMPro;

public class X_Text : MonoBehaviour
{
    public GameObject GamePose1, GamePose2;
    public GameObject LengthX;
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
        position1 = GamePose1.GetComponent<Pose>().pos;
        position2 = GamePose2.GetComponent<Pose2>().pos2;

        float distance = position2.x - position1.x;
        //distance = Mathf.RoundToInt(distance);
        GetComponent<TextMeshPro>().text = distance.ToString("f1");
        textMeshPro.text = distance.ToString("f1");

        //the lines below might be the issue

        pos_temp = LengthX.GetComponent<LinkPoseX>().pos_tempX;
        pos_temp.x = pos_temp.x + distance / 2;
        transform.position = pos_temp;

        //code out the midpoint formula for the 2 text and find mid point to put the ui in it

        //position1 - position2 (midpoint)
        //text.transform.position
    }
}
