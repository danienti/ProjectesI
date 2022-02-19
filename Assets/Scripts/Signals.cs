
public class Signal1 { }
public class Signal2
{
	public int param;
}

public class Signal3 : ISignalA
{
	public string param;
	public string interfaceParam => param;
}

public interface ISignalA
{
	public string interfaceParam { get; }
}