using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class talkthing : MonoBehaviour {
    public static Flowchart FlowchartManager;
    public Flowchart talkFlowchart;
    public string onCollosionEnter;
    public string onMouseDown;

	// Use this for initialization
	void Awake () {
        FlowchartManager = GameObject.Find("對話管理器").GetComponent<Flowchart>();
	}

    public static bool isTalking
    {
        get
        {
            return FlowchartManager.GetBooleanVariable("對話中");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            Block talkblock = talkFlowchart.FindBlock(onCollosionEnter);
            talkFlowchart.ExecuteBlock(talkblock);
        }
    }

    private void OnMouseDown()
    {
        Block talkBlock = talkFlowchart.FindBlock(onMouseDown);
        talkFlowchart.ExecuteBlock(talkBlock);
    }
}
