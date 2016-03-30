using UnityEngine;
using System.Collections;

public class EditEvent : MonoBehaviour
{
    public GUISkin[] s1;
    private float vSValue = Screen.width;
    private float hSValue = Screen.height;
    public Db Db1;
    public Testo tst1;
    public ArrayList dbresult;
    public string addval = " Start ";

    void Start()
    {
    }
    void Update()
    {


    }
    void OnGUI()
    {


        if (GUI.Button(new Rect(-vSValue / 10, -10, 3 * vSValue / 4, hSValue / 4), "Add item \n to your events?"))
            Destroy(this);

        addval = GUI.TextField(new Rect(vSValue / 10, hSValue / 7 + 1 * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), addval, 25);
        addval = GUI.TextField(new Rect(vSValue / 10, hSValue / 7 + 1 * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), addval, 25);

        if (GUI.Button(new Rect(vSValue / 10, hSValue / 7 + 2 * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), "Add as event"))
        {

            Application.LoadLevel("EditEvent");

        }

    }
}