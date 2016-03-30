using UnityEngine;
using System.Collections;

public class Editcat : MonoBehaviour
{
    public GUISkin[] s1;
    private float vSValue = Screen.width;
    private float hSValue = Screen.height;
    public Db Db1;
    public Testo tst1;
    public ArrayList dbresult;
    public string addval=" input ";
    private TouchScreenKeyboard keyboard;

    void Start()
    {
    }
    void Update()
    {


    }
    void OnGUI()
    {


        if (GUI.Button(new Rect(-vSValue / 10, -10, 3 * vSValue / 4, hSValue / 4), "Add item \n to your category?"))
            Destroy(this);

        addval = GUI.TextField(new Rect(vSValue / 10, hSValue / 7 + 1 * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), addval, 25);
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        if (GUI.Button(new Rect(vSValue / 10, hSValue / 7 + 2 * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), "Add as category"))
        {

            Db1 = FindObjectOfType(typeof(Db)) as Db;
            dbresult = Db1.Select("insert into cats (upid,name) values (0,'"+ addval + "')");
            Application.LoadLevel("Start");

        }
        if (GUI.Button(new Rect(vSValue / 10, hSValue / 7 + 2 * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), "Add as event"))
        {

            Application.LoadLevel("EditEvent");

        }

    }
}