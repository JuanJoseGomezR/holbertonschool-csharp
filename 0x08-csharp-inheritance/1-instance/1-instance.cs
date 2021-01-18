using System;

///<summary> calss onj </summary>
class Obj {
	///<summary> returns true of fasle</summary>
	public static bool IsInstanceOfArray(object obj) {
		if (obj is Array) {
			return true;
		} else {
			return false;
		}
	}
}
