using System;
using UnityEditor;
using UnityEngine;


    public class DebugConsole : EditorWindow 
    {
        public GameObject analogController;
        public GameObject joystickController;

        [MenuItem("Window/Debug Console")]
        public static void ShowWindow()
        {
            GetWindow<DebugConsole>("Debug");
        }
        private void OnGUI()
        {
            GUILayout.Label("Debug Console", EditorStyles.boldLabel);
            
            GUILayout.Label("Input Method");
            
            
        }

   
    }

