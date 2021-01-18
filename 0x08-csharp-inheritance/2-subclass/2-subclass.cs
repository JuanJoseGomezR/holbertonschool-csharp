using System;

///<summary> class obj </summary>
class Obj {
	///<summary>basetyper </summary>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
		return derivedType.IsSubclassOf(baseType);
	}
}
