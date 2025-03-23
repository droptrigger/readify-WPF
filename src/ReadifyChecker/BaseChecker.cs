namespace ReadifyChecker
{
    /// <summary>
    /// ������� ����� ��� ���������� ��������
    /// </summary>
    public abstract class BaseChecker<P>
    {
        /// <summary>
        /// ������������ ��� ���������� ��������
        /// </summary>
        /// <param name="parameter">��������</param>
        /// <returns>True - ���� �������� ��������</returns>
        public abstract bool Check(P parameter);
    }

}
