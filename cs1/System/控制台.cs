public static class ����̨
{
    public static int ���ڸ߶�
    {
        get { return Console.WindowHeight; }
        set { Console.WindowHeight = value; }
    }
    public static void �������()
    {
        Console.WriteLine();
    }
    public static event ConsoleCancelEventHandler? ȡ��������
    {
        add { Console.CancelKeyPress += value; }
        remove { Console.CancelKeyPress -= value; }
    }
}