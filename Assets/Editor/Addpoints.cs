using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(WhenToMove))]
public class Addpoints :Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        WhenToMove myScript = (WhenToMove)target;

        if (GUILayout.Button("Add Point"))
        {
            myScript.NextMove();
        }

        if (GUILayout.Button("Remove Last Point"))
        {
            myScript.RemovePoint();
        }
    }
}
