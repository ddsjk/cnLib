public class ���
{
    Random ������;
    public ���()
    {
        ������ = new Random();
    }
    public ���(int ����)
    {
        ������ = new Random(����);
    }

    public int ��һ��(int ��Сֵ, int ���ֵ)
    {
        return ������.Next(��Сֵ, ���ֵ);
    }


    public double ��һ��˫����()
    {
        return ������.NextDouble();
    }
}
