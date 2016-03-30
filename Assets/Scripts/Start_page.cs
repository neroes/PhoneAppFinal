using UnityEngine;
using System.Collections;

public class Start_page : MonoBehaviour
{
    public GUISkin[] s1;
    private float vSValue = Screen.width;
    private float hSValue = Screen.height;
    public Data Db1;
    public Testo tst1;
    public ArrayList dbresult;
    public bool died;
    void Start()
    { 
    }
    void Update()
    {


    }
    void OnGUI()
    {
    
        Db1 = FindObjectOfType(typeof(Data)) as Data;
        dbresult =Db1.get(0);
        
        if (GUI.Button(new Rect(-vSValue / 10, -10, 3*vSValue / 4, hSValue / 4), "What you did\nlast 2 hours?"))
            Debug.Log("Button has been pressed");
        int i= 0;
        foreach (string value in dbresult)
        {i=i+1;
            {
                if (GUI.Button(new Rect(vSValue / 10, hSValue / 7 + i * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), value))
                {
                    Debug.Log("Button has been pressed " + value);
                }
            }
           
       
        }
        i = i + 1;
        if (GUI.Button(new Rect(vSValue / 10, hSValue / 7 + i * (hSValue / 10 + 5), 3 * vSValue / 4, hSValue / 10), "Add"))
        {

            Application.LoadLevel("Addcat");

        }
    }
}