#if UNITY_EDITOR

using UnityEditor;

/**
* Planeta/EnableDebugMode
*/
public static class DebugMode
{
    [MenuItem("Planeta/EnableDebugMode", false, 20)]
    public static void EnableDebugMode()
    {
        //各種フラグを立てる
        Planeta.Common.PnGlobalParameter.globalDebugLogFlag = true;
        EditorPrefs.SetBool("PnA_SDKUseDebugFlag", true);
    }
}

#endif