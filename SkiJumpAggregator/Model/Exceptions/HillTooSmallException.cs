using System;

public class HillTooSmallException : Exception
{
	public HillTooSmallException(string message)
        :base(message)
	{
	}
}