using System;

///<summary>Class Shape</summary>
class Shape
{
	///<summary>Throw error "is not implemented"</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

///<summary> </summary>
class Rectangle : Shape
{
	private int width;
	private int height;
	///<summary> Rectangle width </summary>
	public int Width {
		get {
			return width;
		}

		set {
			if (value < 0)
			{
				throw new System.ArgumentException("Width must be greater than or equal to 0");
			}
			else {
				this.width = value;
			}
		}
	}
	///<summary> Rectangle height </summary>
	public int Height
	{
		get
		{
			return height;
		}
		set
		{	
			if(value < 0)
				throw new System.ArgumentException("Height must be greater than or equal to 0");
			else
				height = value;
		}
	}
}
