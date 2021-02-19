using System;
using System.Collections.Generic;

namespace Security.Cryptography
{
    class Program
    {
       static List<User> users = new List<User>();
        static void Main(string[] args)
        {
        //   //  EncryptionAndDecryption
           
        //     string plainText = "helloWorlD";
        //     string ciperText = EncryptionAndDecryption.Encrypt(plainText);
        //     System.Console.WriteLine(plainText +" is encypted to " + ciperText);
        //     plainText = EncryptionAndDecryption.Decrypt(ciperText);
        //     System.Console.WriteLine(ciperText +" is Decrypted to " + plainText);
        //     Console.WriteLine("Hello World!");

            //Hashing
        bool isLoginSuccess = false;
        System.Console.WriteLine("Enter userName");
        string userName = Console.ReadLine();
        System.Console.WriteLine("Enter Password");
        string password = Console.ReadLine();
       
        users.Add(new User(){UserName = userName, PasswordHash = PasswordHasher.HashPassword(password)});
        System.Console.WriteLine(userName + " Added ");
        //While Login is not success ask to login.
        
        while(!isLoginSuccess)
        {
        System.Console.WriteLine("Now Login");
        System.Console.WriteLine("Enter UserName");
        string userNameToLogin = Console.ReadLine();
        System.Console.WriteLine("Enter Password");
        string passwordToVerify = Console.ReadLine();
        bool veryfy = PasswordHasher.VerifyPassword(users, userNameToLogin, passwordToVerify);
        string check = veryfy? "Login Success" : "Password Error";
        isLoginSuccess = veryfy;
        System.Console.WriteLine(check);
        }
        }
    }
}
