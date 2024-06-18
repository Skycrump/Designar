using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    public GameObject targetObject;

    public void TransferToTarget()
    {
        if (targetObject.GetComponent<MeshRenderer>().isVisible)
        {
            transform.SetParent(targetObject.transform.parent, false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
