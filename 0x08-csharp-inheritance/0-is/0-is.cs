using System;

/// <summary> </summary>
class Obj
{
    /// <summary> </summary>
    public static bool IsOfTypeInt(object obj) {

        if (obj.GetType() == typeof(int))
        {
            return true;
        } else {
            return false;
        }
    }
}