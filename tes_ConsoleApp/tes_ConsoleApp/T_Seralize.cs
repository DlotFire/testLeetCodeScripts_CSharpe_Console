using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public class T_Seralize
{
    /// <summary>
    /// 序列化类
    /// </summary>
    public T_Seralize()
    {

    }

    /// <summary>
    /// 测试序列化
    /// </summary>
    void test_BinaryFormatter()
    {
        //序列化
        FileStream fileStream = new FileStream(@"E:/ObjRecordTrans.txt", FileMode.OpenOrCreate);
        byte[] streamByte = new byte[fileStream.Length];
        fileStream.Read(streamByte, 0, (int)fileStream.Length);
        Console.WriteLine(Encoding.ASCII.GetString(streamByte));
        FileStream fs = new FileStream("fs.dat", FileMode.Create);

        BinaryFormatter binaryFormat = new BinaryFormatter();
        binaryFormat.Serialize(fs, streamByte);
        fileStream.Close();
        fs.Close();

        //反序列化
        FileStream fileSteam = new FileStream("fs.dat", FileMode.Open);

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        byte[] str = (byte[])binaryFormatter.Deserialize(fileSteam);

        Console.WriteLine(Encoding.Default.GetString(str));
        fileSteam.Close();
    }
}
