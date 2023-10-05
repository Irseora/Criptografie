using System;
using System.Linq;

class CaesarCypher
{
    static int offset = 3;
    static int overflowEncryptModifier = 23;
    static int overflowDecryptModifier = 26;

    public static string Encrypt(string text)
    {
        string encrypted = "";

        for (int i = 0; i < text.Length; i++)
        {
            if (Char.IsLetter(text[i]))
            {
                char temp = text[i];
                temp = (char)(temp + offset);

                if ((temp > 'Z' && temp < 'a') || temp > 'z')
                    temp = (char)(temp - overflowEncryptModifier);

                encrypted += temp;
            }
            else
                encrypted += text[i];
        }

        return encrypted;
    }

    public static string Decrypt(string encrypted)
    {
        string text = "";

        for (int i = 0; i < encrypted.Length; i++)
        {
            if (Char.IsLetter(encrypted[i]))
            {
                char temp = (char)(encrypted[i] - offset);

                if (temp < 'A' || (temp < 'a' && temp > 'Z'))
                    temp = (char)(temp + overflowDecryptModifier);

                text += temp;
            }
            else
                text += encrypted[i];
        }

        return text;
    }


}