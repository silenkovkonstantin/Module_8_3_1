using System;
using System.IO;
using System.Reflection;

class Module_8_3_1
{
    public static void Main()
    {
        string filePath = "C:\\VS_Projects\\Module_8\\Module_8_3_1\\Module_8_3_1\\Program.cs"; // ������ ����
        var fileInfo = new FileInfo(filePath);
        
        using (StreamWriter sw = fileInfo.AppendText())
        {
            sw.WriteLine("// " + TimeOnly.FromDateTime(DateTime.Now));
        }

        // ������� ���� � ��������� ��� ����������
        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null) // ���� �� �������� ������ - ��������� �� ����� �� ����� � ������� � �������
            {
                Console.WriteLine(str);
            }
        }
    }
}// 5:14
// 5:15
// 5:15
