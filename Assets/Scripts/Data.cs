using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour {
    public Db Db2;
    public ArrayList dbresult1;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public ArrayList get(int subcat) {

        Db2 = FindObjectOfType(typeof(Db)) as Db;
        return Db2.Select("select * from cats where upid="+ subcat);

    }
}
