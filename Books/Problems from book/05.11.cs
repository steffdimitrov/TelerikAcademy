using System;

namespace BookHomeworks
{
    class Chapter05Problem11
    {
        static void Main(string[] args)
        {
            Console.Write("�������� ����� �� 1 �� 999: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 999 || number < 1)
            {
                number = -1; //�� ������ ������ ������ � �� ������ ������ �� ����
            }
            int number100 = number / 100;
            int number10 = (number - 100 * number100) / 10;
            int number1 = number - number100 * 100 - number10 * 10;
            string sayNumber100 ="";
            string sayNumber10 ="";
            string sayNumber1 ="";
            switch (number100)
            {
                case 0: sayNumber100 = ""; break;
                case 1: sayNumber100 = "���"; break;
                case 2: sayNumber100 = "������"; break;
                case 3: sayNumber100 = "������"; break;
                case 4: sayNumber100 = "������������"; break;
                case 5: sayNumber100 = "���������"; break;
                case 6: sayNumber100 = "����������"; break;
                case 7: sayNumber100 = "�����������"; break;
                case 8: sayNumber100 = "����������"; break;
                case 9: sayNumber100 = "�����������"; break;
                default: break;
            }
            switch (number10)
            {
                case 0: sayNumber10 = ""; break;
                case 1:
                    {
                        switch (number1)
                        {
                            case 0: sayNumber10 = "�����"; break;
                            case 1: sayNumber10 = "����������"; break;
                            case 2: sayNumber10 = "����������"; break;
                            case 3: sayNumber10 = "����������"; break;
                            case 4: sayNumber10 = "�������������"; break;
                            case 5: sayNumber10 = "����������"; break;
                            case 6: sayNumber10 = "�����������"; break;
                            case 7: sayNumber10 = "������������"; break;
                            case 8: sayNumber10 = "�����������"; break;
                            case 9: sayNumber10 = "������������"; break;
                            default: break;
                        }
                    } break;
                case 2: sayNumber10 = "��������"; break;
                case 3: sayNumber10 = "��������"; break;
                case 4: sayNumber10 = "�����������"; break;
                case 5: sayNumber10 = "��������"; break;
                case 6: sayNumber10 = "���������"; break;
                case 7: sayNumber10 = "����������"; break;
                case 8: sayNumber10 = "���������"; break;
                case 9: sayNumber10 = "����������"; break;
                default: break;
            }
             switch (number1)
            {
                case 0: sayNumber1 = ""; break;
                case 1: sayNumber1 = "����"; break;
                case 2: sayNumber1 = "���"; break;
                case 3: sayNumber1 = "���"; break;
                case 4: sayNumber1 = "������"; break;
                case 5: sayNumber1 = "���"; break;
                case 6: sayNumber1 = "����"; break;
                case 7: sayNumber1 = "�����"; break;
                case 8: sayNumber1 = "����"; break;
                case 9: sayNumber1 = "�����"; break;
                default: break;
            }
             if (number10 == 1)
             {
                 number1 = 0;
             }
            if (number100 > 0)
            {
                if (number10 > 0)
                {
                    if (number1 > 0)
                    {
                        Console.WriteLine("� ����: " + sayNumber100 + " " + sayNumber10 + " � " + sayNumber1);
                    }
                    else
                    {
                        Console.WriteLine("� ����: " + " " + sayNumber100 + " � " + sayNumber10);
                    }
                }
                else
                {
                    if (number1 > 0)
                    {
                        Console.WriteLine("� ����: " + sayNumber100 + " � " + sayNumber1);
                    }
                    else
                    {
                        Console.WriteLine("� ����: " + sayNumber100);
                    }
                }
            }
            else
            {
                if (number10 > 0)
                {
                    if (number1 > 0)
                    {
                        Console.WriteLine("� ����: " + sayNumber10 + " � " + sayNumber1);
                    }
                    else
                    {
                        Console.WriteLine("� ����: " + sayNumber10);
                    }
                }
                else
                {
                    if (number1 > 0)
                    {
                        Console.WriteLine("� ����: " + sayNumber1);
                    }
                    else
                    {
                        Console.WriteLine("���������� ����� �� � � ��������� �� 1 - 999");
                    }
                }
            }
        }
    }
}