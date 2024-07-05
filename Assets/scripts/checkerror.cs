// Ensure you include the TextMeshPro namespace
using TMPro;
using UnityEngine;

public class checkerror : MonoBehaviour
{
    public TextMeshPro yAxisTextMeshPro;
    public TextMeshPro xTextTextMeshPro;
    public TextMeshPro zAxisTextMeshPro;

    void Start()
    {
        if (yAxisTextMeshPro == null)
        {
            yAxisTextMeshPro = GetComponent<TextMeshPro>();
            if (yAxisTextMeshPro == null)
            {
                Debug.LogError("TextMeshPro component missing on y axis GameObject.");
            }
        }

        if (xTextTextMeshPro == null)
        {
            xTextTextMeshPro = GetComponent<TextMeshPro>();
            if (xTextTextMeshPro == null)
            {
                Debug.LogError("TextMeshPro component missing on Xtext GameObject.");
            }
        }

        if (zAxisTextMeshPro == null)
        {
            zAxisTextMeshPro = GetComponent<TextMeshPro>();
            if (zAxisTextMeshPro == null)
            {
                Debug.LogError("TextMeshPro component missing on zaxis GameObject.");
            }
        }
    }
}
