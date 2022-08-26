using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(EnemyInfo))]
public class EnemyInfo_Inspector : Editor
{
    #region SerializedProperties
    SerializedProperty _sprite;
    SerializedProperty _typeOfEnemy;
    SerializedProperty _effect;
    SerializedProperty _value;
    SerializedProperty _maxLvl;


    SerializedProperty HealthProgression;
    SerializedProperty DmgProgression;
    SerializedProperty SpeedProgression;
    SerializedProperty RadiusDmgProgression;

    #endregion

    DmgType TypeOfDmg; 
    bool main, specifications = false;

    private void OnEnable()
    {
        _sprite = serializedObject.FindProperty("_sprite");
        _typeOfEnemy = serializedObject.FindProperty("_typeOfEnemy");
        _effect = serializedObject.FindProperty("_effect");
        _value = serializedObject.FindProperty("_value");
        _maxLvl = serializedObject.FindProperty("_maxLvl");

        HealthProgression = serializedObject.FindProperty("HealthProgression");
        DmgProgression = serializedObject.FindProperty("DmgProgression");
        SpeedProgression = serializedObject.FindProperty("SpeedProgression");
        RadiusDmgProgression = serializedObject.FindProperty("RadiusDmgProgression");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        EditorGUILayout.PropertyField(_sprite);

        main = EditorGUILayout.BeginFoldoutHeaderGroup(main, "Main");
        if (main)
        {
            EditorGUILayout.PropertyField(_typeOfEnemy);
            EditorGUILayout.PropertyField(_effect);
            EditorGUILayout.PropertyField(_value);
            EditorGUILayout.PropertyField(_maxLvl);
        }
        EditorGUILayout.EndFoldoutHeaderGroup();

        specifications = EditorGUILayout.Foldout(specifications, "Specifications");
        if(specifications)
        {

            EditorGUILayout.PropertyField(HealthProgression);
            EditorGUILayout.PropertyField(DmgProgression);
            EditorGUILayout.PropertyField(SpeedProgression);
            TypeOfDmg = (DmgType)EditorGUILayout.EnumPopup("Type of Damage", TypeOfDmg);
            if(TypeOfDmg == DmgType.Splash)
            {
                EditorGUILayout.PropertyField(RadiusDmgProgression);
            }
        }

        serializedObject.ApplyModifiedProperties();
    }
}
