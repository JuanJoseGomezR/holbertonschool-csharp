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
	///<summary> override method are </summary>
	public override int Area()
	{
		return height * width;
	}

	public override string ToString()
	{
		return String.Format("[Rectangle] {0} / {1}", width, height);
	}
}
///<summary>new class square inherited from rectangle</summary>
class Square : Rectangle
{
	private int size;

	///<summary> size of square</summary>
	public int Size
	{
		get
		{
			return size;
		}
		set
		{
			if (value < 0)
			{
				throw new System.ArgumentException("Size must be greater than or equal to 0");
			}
			else
			{
				size = value;
				Height = value;
				Width = value;
			}
		}
	}
	///<summary> override string</summary>
	public override string ToString()
	{
		return String.Format("[Square] {0} / {0}", size);
	}
}
