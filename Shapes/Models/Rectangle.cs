namespace Shapes.Models
{
public class Rectangle     // class
{
private int _length;     // properties
private int _width;

public Rectangle(int sideLength, int sideWidth)     // constructor
{
	_length = sideLength;
	_width = sideWidth;
}

public int GetLength()
{
	return _length;
}
public void SetLength(int newLength)
{
	_length = newLength;
}
public int GetWidth()
{
	return _width;
}
public void SetWidth(int newWidth)
{
	_width = newWidth;
}

public int GetArea()
{
	return _length * _width;
}

public bool IsSquare()
{
	if(_length == _width)
	{
		return true;
	}
	else
	{
		return false;
	}
}
}
}
