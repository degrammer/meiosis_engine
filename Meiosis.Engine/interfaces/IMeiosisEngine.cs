namespace Meiosis.Engine
{
    public interface IMeiosisEngine<T1, T2>
    {

        T2 Create(int times, T1 defaultTemplate);

    }
}