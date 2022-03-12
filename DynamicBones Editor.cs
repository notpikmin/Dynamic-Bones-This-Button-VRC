using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DynamicBone))]
public class DynamicBonesEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("This"))
        {
            Selection.activeGameObject.GetComponent<DynamicBone>().m_Root = Selection.activeGameObject.transform ;
        }

        DrawDefaultInspector();
    }

}
