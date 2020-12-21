using System;

/// <summary> new class obj<</summary>
class Obj
{
    /// <summary> boolean </summary>
    public static bool IsOfTypeInt(object obj) {

        if (obj.GetType() == typeof(int))
        {
            return true;
        } else {
            return false;
        }
    }
}
