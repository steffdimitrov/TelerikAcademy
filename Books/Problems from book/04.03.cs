using System;

namespace BookHomeworks
{
    class Chapter04Problem03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("�������� ����� �� �������");
            string companyName = Console.ReadLine();
            Console.WriteLine("�������� ������ �� �������");
            string companyAdress = Console.ReadLine();
            Console.WriteLine("�������� ��������� ����� �� �������");
            int companyPhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("�������� ������ �� ����� �� �������");
            int companyFaxNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("�������� ��� ������ �� �������");
            string companyWebAdress = Console.ReadLine();
            Console.WriteLine("�������� ���������� �� ��������� �� �������:");
            Console.Write("���: ");
            string managerName = Console.ReadLine();
            Console.Write("�������: ");
            string managerSirname = Console.ReadLine();
            Console.Write("��������� �����: ");
            int managerPhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("����� {0}", companyName);
            Console.WriteLine("�����: {0}", companyAdress);
            Console.WriteLine("�������: {0:(0#) ### ####}", companyPhoneNumber);
            Console.WriteLine("����: {0:(0#) ### ####}", companyFaxNumber);
            Console.WriteLine("��� �����: {0}", companyWebAdress);
            Console.WriteLine("���������");
            Console.WriteLine(managerName + " " + managerSirname);
            Console.WriteLine("�������: {0:(0#) ### ####}", managerPhoneNumber);
        }
    }
}
