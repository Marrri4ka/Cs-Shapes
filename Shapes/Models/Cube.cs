public int GetVolume()
{
  int length = _face.GetLength();
  return length * length * length;
}

public int GetSurfaceArea()
{
  int length = _face.GetLength();
  return (length * length) * 6;
}
